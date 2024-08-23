using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStreamTemplate.Models;

namespace MovieStreamTemplate.Services
{
    /// <summary>
    /// Interface with common tasks
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Get the movie by id
        /// </summary>
        /// <param name="id">Movie id</param>
        /// <returns>Movie object or null</returns>
        Task<Movie> GetMovieAsync(string id);

        /// <summary>
        /// Get movies by parameters
        /// </summary>
        /// <param name="genre">Get only items in the given genre. Default is all.</param>
        /// <param name="title">Keyword that searching in the movie title. Default is null.</param>
        /// <param name="onlyInWatchList">Get only items in the watchlist. Default is false.</param>
        /// <param name="onlyNew">Get only new items. Default is false.</param>
        /// <param name="onlyFeatured">Get only featured items. Default is false.</param>
        /// <param name="onlyTrending">Get only popular items. Default is false.</param>
        /// <param name="onlyDownloaded">Get only downloaded items. Default is false.</param>
        /// <param name="sortBy">SortBy enumaration. Default is unsorted.</param>
        /// <returns>List of movie objects filtered by parameters.</returns>
        Task<IEnumerable<Movie>> GetMoviesAsync(string personId, MovieGenre genre = MovieGenre.ALL,
                                                string[] movieIds = null, string name = null,
                                                bool onlyInWatchList = false, bool onlyNew = false,
                                                bool onlyFeatured = false, bool onlyTrending = false,
                                                bool onlyDownloaded = false, SortBy sortBy = SortBy.UNSORTED);

        /// <summary>
        /// Get list of reviews by movie id.
        /// </summary>
        /// <param name="movieId">Movie id</param>
        /// <returns>List of reviews filtered by movie id.</returns>
        Task<IEnumerable<Review>> GetReviewsAsync(string movieId);

        /// <summary>
        /// Add the new review
        /// </summary>
        /// <param name="review">New review that will be added</param>
        /// <returns>Added comment</returns>
        Task<Review> AddReviewAsync(Review review);

        /// <summary>
        /// Get person by id
        /// </summary>
        /// <param name="id">Person id</param>
        /// <returns>Person object or null</returns>
        Task<Person> GetPersonAsync(string id);

        /// <summary>
        /// Update the person
        /// </summary>
        /// <param name="person">Person object that will be updated</param>
        /// <returns></returns>
        Task<bool> UpdatePersonAsync(Person person);

        /// <summary>
        /// Add watchlist item
        /// </summary>
        /// <param name="personId">Person's Id</param>
        /// <param name="movieId">Id of the movie</param>
        /// <returns>Added object</returns>
        Task<WatchlistItem> AddWatchlistItemAsync(string personId, string movieId);

        /// <summary>
        /// Remove an item from watchlist
        /// </summary>
        /// <param name="id">Id of the movie</param>
        /// <returns>True, if success</returns>
        Task<bool> RemoveWatchlistItemAsync(string personId, string movieId);

        /// <summary>
        /// Is the movie on the watchlist?
        /// </summary>
        /// <param name="personId">Person's id</param>
        /// <param name="movieId">Id of the movie</param>
        /// <returns>True, if exist</returns>
        Task<bool> IsOnWatchlistAsync(string personId, string movieId);

        /// <summary>
        /// Add a movie to downloads
        /// </summary>
        /// <param name="movieId">Movie id that will be added</param>
        /// <returns>Added object</returns>
        Task<DownloadItem> AddDownloadItemAsync(string movieId);

        Task<IEnumerable<DownloadItem>> GetDownloadItemsAsync();

        /// <summary>
        /// Remove a movie from downloads
        /// </summary>
        /// <param name="id">Id of the movie</param>
        /// <returns>True, if success</returns>
        Task<bool> RemoveDownloadItemAsync(string movieId);

        Task<bool> RemoveAllDownloadItemAsync();

        /// <summary>
        /// Is the movie on the download list
        /// </summary>
        /// <param name="movieId">Id of the movie</param>
        /// <returns>True, if exist.</returns>
        Task<bool> IsOnDownloadList(string movieId);

        /// <summary>
        /// Get Profile by id
        /// </summary>
        /// <param name="id">Id of the profile</param>
        /// <returns>Profile object or null</returns>
        Task<Profile> GetProfileAsync(string id);

        Task<Profile> AddProfileAsync(Profile profile);

        Task<bool> UpdateProfileAsync(Profile profile);

        Task<bool> DeleteProfileAsync(string id);

        /// <summary>
        /// Get list of profiles by person id.
        /// </summary>
        /// <param name="personId">Person's id</param>
        /// <returns>List of profiles filtered by person id.</returns>
        Task<IEnumerable<Profile>> GetProfilesAsync(string personId);

        Task<IEnumerable<SearchItem>> GetAllSearchItems();

        Task<SearchItem> AddSearchItem(SearchItem searchItem);

        Task<bool> DeleteAllSearchItems();

        Task<bool> DeleteSearchItemAsync(string id);
    }
}

