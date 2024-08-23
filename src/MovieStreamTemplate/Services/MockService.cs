using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using MovieStreamTemplate.DataStores;
using MovieStreamTemplate.Models;
using Xamarin.Forms;

namespace MovieStreamTemplate.Services
{
    public class MockService: IService
    {
        IMovieDataStore dataMovie = DependencyService.Get<IMovieDataStore>();
        IPersonDataStore dataPerson = DependencyService.Get<IPersonDataStore>();
        IReviewDataStore dataReview = DependencyService.Get<IReviewDataStore>();
        IWatchlistItemDataStore dataWatchlistItem = DependencyService.Get<IWatchlistItemDataStore>();
        IDownloadItemDataStore dataDownloadItem = DependencyService.Get<IDownloadItemDataStore>();
        IProfileDataStore dataProfile = DependencyService.Get<IProfileDataStore>();
        ISearchItemDataStore dataSearchItem = DependencyService.Get<ISearchItemDataStore>();

        // Methods for movie entities

        public async Task<Movie> GetMovieAsync(string id)
        {
            var movie = await dataMovie.GetAsync(id);

            movie.Director = await dataPerson.GetAsync(movie.DirectorId);
            movie.Actors = (await dataPerson.GetByAsync(p => movie.ActorIds.Contains(p.Id))).ToArray();

            return movie;
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync(string personId, MovieGenre genre = MovieGenre.ALL,
                                string[] movieIds = null, string name = null, bool onlyInWatchList = false,
                                bool onlyNew = false, bool onlyFeatured = false, bool onlyTrending = false,
                                bool onlyDownloaded = false, SortBy sortBy = SortBy.UNSORTED)
        {
            var result = (await dataMovie.GetByAsync(m => (genre == MovieGenre.ALL || m.Genre == genre) &&
                                    (movieIds == null || movieIds.Contains(m.Id)) &&
                                    (string.IsNullOrEmpty(name) || m.Name.ToLower().Contains(name.ToLower())) &&
                                    (onlyNew == false || m.IsNew) &&
                                    (onlyFeatured == false || m.IsFeatured) &&
                                    (onlyTrending == false || m.IsTrending))).ToList()
                                .Select(i => {
                                    i.RatingCount = dataReview.GetByAsync(r => r.MovieId == i.Id).Result.Count();

                                    i.AverageRating = i.RatingCount > 0 ?
                                        (float)dataReview.GetByAsync(r => r.MovieId == i.Id).Result.Sum(r => r.Star) / i.RatingCount : 0;

                                    i.IsInWatchlist = dataWatchlistItem.IsExistAsync(w => w.PersonId == personId && w.MovieId == i.Id).Result;

                                    var status = dataDownloadItem.GetByAsync(d => d.MovieId == i.Id).Result.FirstOrDefault();
                                    i.DownloadStatus = status != null ? status.Status : DownloadStatus.NoDownload;

                                    return i;
                                }).Where(m => (onlyInWatchList == false || m.IsInWatchlist) &&
                                                (onlyDownloaded == false || m.DownloadStatus != DownloadStatus.NoDownload));

            switch(sortBy)
            {
                case SortBy.HIGHEST_RATE: result = result.OrderByDescending(i => i.AverageRating); break;
                case SortBy.NAME_AZ: result = result.OrderBy(i => i.Name); break;
                case SortBy.NAME_ZA: result = result.OrderByDescending(i => i.Name); break;
                case SortBy.MOST_RATED: result = result.OrderByDescending(i => i.RatingCount); break;
            }

            return await Task.FromResult(result);
        }

        // Methods for review entity

        public async Task<IEnumerable<Review>> GetReviewsAsync(string movieId)
        {
            return (await dataReview.GetByAsync(r => r.MovieId == movieId)).ToList()
                            .Select(i => {
                                var p = dataPerson.GetAsync(i.PersonId).Result;
                                i.AuthorName = p.FullName;
                                i.AuthorPhoto = p.Photo;
                                return i;
                            }).OrderByDescending(t => t.DateGmt);
        }

        public async Task<Review> AddReviewAsync(Review review)
        {
            return await dataReview.AddAsync(review);
        }

        // Methods for person entity

        public async Task<Person> GetPersonAsync(string id)
        {
            return await dataPerson.GetAsync(id);
        }

        public async Task<bool> UpdatePersonAsync(Person person)
        {
            return await dataPerson.UpdateAsync(person);
        }

        // Methods for items on the watchlist

        public async Task<WatchlistItem> AddWatchlistItemAsync(string personId, string movieId)
        {
            return await dataWatchlistItem.AddAsync(new WatchlistItem
            {
                Id = Guid.NewGuid().ToString(),
                PersonId = personId,
                MovieId = movieId
            });
        }

        public async Task<bool> RemoveWatchlistItemAsync(string personId, string movieId)
        {
            var item = dataWatchlistItem.GetByAsync(i => i.PersonId == personId && i.MovieId == movieId)
                                .Result.FirstOrDefault();

            if (item == null) return false;

            return await dataWatchlistItem.DeleteAsync(item.Id);
        }

        public async Task<bool> IsOnWatchlistAsync(string personId, string movieId)
        {
            return await dataWatchlistItem.IsExistAsync(w => w.PersonId == personId && w.MovieId == movieId);
        }

        // Methods for items on the download list

        public async Task<IEnumerable<DownloadItem>> GetDownloadItemsAsync()
        {
            var result = (await dataDownloadItem.GetAllAsync()).ToList()
                    .Select(i =>
                    {
                        var m = dataMovie.GetAsync(i.MovieId).Result;
                        i.MoviePoster = m.Poster;
                        i.MovieTitle = m.Name;
                        i.MovieGenre = m.Genre;
                        i.Year = m.Year;
                        i.Minutes = m.Minutes;

                        return i;
                    }).OrderByDescending(i => i.DateGmt);

            return result;
        }

        public async Task<DownloadItem> AddDownloadItemAsync(string movieId)
        {
            return await dataDownloadItem.AddAsync(new DownloadItem
            {
                Id = Guid.NewGuid().ToString(),
                MovieId = movieId,
                DateGmt = DateTime.Now,
                Status = DownloadStatus.Downloading
            });
        }

        public async Task<bool> RemoveDownloadItemAsync(string movieId)
        {
            var item = dataDownloadItem.GetByAsync(i => i.MovieId == movieId)
                        .Result.FirstOrDefault();

            if (item == null) return false;

            return await dataDownloadItem.DeleteAsync(item.Id);
        }

        public async Task<bool> RemoveAllDownloadItemAsync()
        {
            return await dataDownloadItem.DeleteAllAsync();
        }

        public async Task<bool> IsOnDownloadList(string movieId)
        {
            return await dataDownloadItem.IsExistAsync(i => i.MovieId == movieId);
        }

        // Methods for profile entities

        public async Task<Profile> GetProfileAsync(string id)
        {
            return await dataProfile.GetAsync(id);
        }

        public async Task<Profile> AddProfileAsync(Profile profile)
        {
            return await dataProfile.AddAsync(profile);
        }

        public async Task<bool> UpdateProfileAsync(Profile profile)
        {
            return await dataProfile.UpdateAsync(profile);
        }

        public async Task<bool> DeleteProfileAsync(string id)
        {
            return await dataProfile.DeleteAsync(id);
        }

        public async Task<IEnumerable<Profile>> GetProfilesAsync(string personId)
        {
            return (await dataProfile.GetByAsync(i => i.PersonId == personId)).OrderBy(i => i.Name);
        }

        // Methods for search items

        public async Task<IEnumerable<SearchItem>> GetAllSearchItems()
        {
            return (await dataSearchItem.GetAllAsync()).OrderByDescending(i => i.DateTimeGmt);
        }

        public async Task<SearchItem> AddSearchItem(SearchItem searchItem)
        {
            return await dataSearchItem.AddAsync(searchItem);
        }

        public async Task<bool> DeleteAllSearchItems()
        {
            return await dataSearchItem.DeleteAllAsync();
        }

        public async Task<bool> DeleteSearchItemAsync(string id)
        {
            return await dataSearchItem.DeleteAsync(id);
        }
    }
}

