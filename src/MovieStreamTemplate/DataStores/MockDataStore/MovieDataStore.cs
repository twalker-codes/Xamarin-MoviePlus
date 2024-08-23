using System;
using System.Collections.Generic;
using MovieStreamTemplate.Models;

namespace MovieStreamTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class MovieDataStore: BaseDataStore<Movie>, IMovieDataStore
    {
        protected override IList<Movie> items { get; }

        public MovieDataStore()
        {
            items = new List<Movie>
            {
                // action

                new Movie
                {
                    Id = "001",
                    Poster = "mov_cras_sodales",
                    Name = "Cras Sodales",
                    Year = 2018,
                    Minutes  = 98,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ACTION,
                    DirectorId = "003",
                    ActorIds = new string[] { "003", "013", "018", "029", "040", "041", "045", "048", "055", "059" },
                    Description = "Etiam consequat eros eget iaculis efficitur. Sed nibh lorem, ullamcorper et hendrerit placerat, vehicula quis nunc. Suspendisse justo arcu, maximus at lobortis eget, efficitur lobortis risus. Nulla facilisi. Mauris efficitur, tortor ac malesuada viverra, urna orci lacinia tortor, at pretium nisi nisi nec odio. Proin ac dignissim quam, ut porttitor libero. Fusce a massa placerat, molestie eros eget, porttitor nibh. Mauris varius mauris et dolor viverra, ut ultricies arcu egestas. Vivamus sit amet sollicitudin nulla. Proin ut ex vitae lorem aliquam cursus. Sed interdum sem eu erat mollis rutrum."
                },

                new Movie
                {
                    Id = "002",
                    Poster = "mov_magna_accumsan",
                    Name = "Magna Accumsan",
                    Year = 1996,
                    Minutes = 103,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = true,
                    IsTrending = false,
                    Genre = MovieGenre.ACTION,
                    DirectorId = "011",
                    ActorIds = new string[] { "002", "018", "031", "038", "047", "049", "053", "057" },
                    Description = "Cras aliquet nibh non convallis auctor. Pellentesque euismod vitae odio sed pharetra. Vestibulum nec molestie risus, et mattis odio. Integer tincidunt vestibulum augue, in rutrum sem aliquet nec. Nulla viverra fringilla purus, ut maximus arcu sodales eu. Suspendisse volutpat mattis tincidunt. Quisque ipsum diam, malesuada nec justo ac, auctor maximus massa. Cras lobortis mauris lectus. Ut id mollis quam, vel placerat quam. Maecenas congue tellus ut magna venenatis, venenatis suscipit lacus luctus. Donec nec elit eu dui porttitor ultricies ac et lorem. Curabitur lacinia mi sem, quis viverra sem ornare eget. Aenean auctor, nunc sit amet lobortis mattis, risus enim faucibus tortor, vitae scelerisque nibh dui ut lacus. Aenean bibendum enim in bibendum facilisis. Sed vitae mi quis mi varius semper et et arcu." },

                new Movie
                {
                    Id = "003",
                    Poster = "mov_mollis",
                    Name = "Mollis",
                    Year = 2009,
                    Minutes = 107,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ACTION,
                    DirectorId = "026",
                    ActorIds = new string[] { "001", "019", "024", "027", "029", "031", "037", "044", "049", "050", "052" },
                    Description = "Phasellus et viverra eros. Nulla facilisi. Nunc tristique metus ac imperdiet iaculis. Etiam id aliquet ipsum, vitae viverra nisi. Sed et commodo ipsum. Proin non scelerisque dui, a consequat tortor. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Ut est neque, egestas pulvinar urna at, pretium varius mauris. Sed varius vitae orci vel placerat. Phasellus ut maximus nibh. Donec vel volutpat urna. Etiam a urna non enim dignissim volutpat. Pellentesque tempor accumsan malesuada. Phasellus vestibulum eu erat id gravida. Suspendisse id dictum quam."
                },

                new Movie
                {
                    Id = "004",
                    Poster = "mov_rutrum_semper",
                    Name = "Rutrum Semper",
                    Year = 2020,
                    Minutes = 89,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ACTION,
                    DirectorId = "036",
                    ActorIds = new string[] { "017", "014", "046", "049", "053", "059", "060" },
                    Description = "Sed sagittis justo velit, a posuere ipsum ultricies et. Nulla facilisi. Donec tincidunt suscipit lectus, eget gravida nisl sagittis eleifend. Nam a varius dui, vel tincidunt nibh. Phasellus eleifend convallis mauris at vestibulum. Sed nulla est, fermentum eu vulputate vitae, accumsan ac dolor. Aenean posuere diam vel tortor tempus consectetur. Sed neque velit, luctus a purus eu, mattis posuere massa. Proin augue lorem, varius eget dolor in, dignissim auctor ex. Ut non iaculis lorem. Proin auctor ornare ultrices. Sed vulputate maximus sem, a malesuada risus ornare sit amet. Quisque tempor, neque non pharetra egestas, eros nulla vulputate lacus, in vulputate leo tellus sed urna. Vestibulum rhoncus dictum velit, vitae tristique sem rutrum nec. Mauris vulputate in eros id vehicula."
                },

                new Movie
                {
                    Id = "005",
                    Poster = "mov_suspendisse",
                    Name = "Suspendisse",
                    Year = 2013,
                    Minutes = 97,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ACTION,
                    DirectorId = "032",
                    ActorIds = new string[] { "008", "009", "016", "019", "025", "049", "051", "054", "057", "059", "060" },
                    Description = "Aenean egestas, est id condimentum efficitur, est nulla vulputate eros, a pulvinar dolor elit ac lorem. Vivamus rhoncus libero nec ipsum venenatis, sit amet blandit quam lobortis. Ut luctus est sit amet commodo efficitur. In finibus risus in libero pharetra, vel vehicula lacus tincidunt. Mauris vestibulum justo sit amet purus lacinia rhoncus. Nullam vel diam ut orci bibendum egestas. Pellentesque eget dignissim odio. Duis in sapien convallis, eleifend eros ac, posuere felis. Nam tristique neque at luctus aliquam. Nullam sodales molestie elit, eget dictum mi vulputate a. Proin id scelerisque leo, sed aliquam enim. Quisque vel risus et libero scelerisque sollicitudin vel nec purus. Nullam sed euismod ligula."
                },

                new Movie
                {
                    Id = "006",
                    Poster = "mov_tellus_in_finibus",
                    Name = "Tellus In Finibus",
                    Year = 2005,
                    Minutes = 86,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = true,
                    IsTrending = false,
                    Genre = MovieGenre.ACTION,
                    DirectorId = "011",
                    ActorIds = new string[] { "004", "005", "012", "028", "039", "044", "050", "053", "056", "059" },
                    Description = "Mauris vel vehicula ligula. Phasellus non imperdiet felis. Sed sit amet ipsum eget libero vulputate aliquet id convallis eros. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vivamus rutrum urna sagittis, semper mi sit amet, maximus augue. Ut fermentum urna nec suscipit tincidunt. Praesent vulputate tempor libero, ut fermentum augue suscipit nec. Integer at ultrices sem, a ullamcorper nulla. Cras erat est, ultrices non tincidunt sed, pharetra at arcu. Pellentesque mi magna, feugiat et fringilla bibendum, aliquet a metus. Etiam rutrum convallis vehicula. Aenean eleifend bibendum est, ut ultrices nibh hendrerit nec. Quisque at cursus sapien."
                },

                new Movie
                {
                    Id = "007",
                    Poster = "mov_vivamus_augue",
                    Name = "Vivamus Augue",
                    Year = 1989,
                    Minutes = 102,
                    IsInWatchlist = false,
                    IsFeatured = true,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ACTION,
                    DirectorId = "003",
                    ActorIds = new string[] { "001", "007", "035", "036", "041", "047", "053", "056", "057", "059", "060" },
                    Description = "Suspendisse potenti. Pellentesque iaculis purus in enim viverra congue. Duis tincidunt, tortor eu euismod facilisis, neque leo aliquet lectus, vitae tempus erat dui non elit. Nulla facilisi. Proin eget ante eget risus luctus euismod sit amet in tortor. Nulla quam eros, elementum et massa sit amet, imperdiet fermentum nisi. Maecenas tincidunt, purus in pretium hendrerit, orci elit eleifend metus, a malesuada elit tortor at velit. Nulla eget finibus nisl. Sed tortor ligula, faucibus quis nulla eget, lacinia fringilla risus. Pellentesque nec tempus ligula, ullamcorper tempor tellus. Vivamus congue metus eget velit tempus accumsan. Donec dictum eget sem et ornare. Fusce id laoreet lorem."
                },

                new Movie
                {
                    Id = "008",
                    Poster = "mov_volutpat",
                    Name = "Volutpat",
                    Year = 1984,
                    Minutes = 105,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ACTION,
                    DirectorId = "037",
                    ActorIds = new string[] { "009", "023", "028", "031", "039", "044", "045", "054" },
                    Description = "Fusce semper placerat eros et blandit. Morbi iaculis rutrum fringilla. Sed luctus condimentum commodo. Aenean condimentum risus lacus, a commodo ex sodales eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam sit amet velit quis massa consequat porttitor a sed diam. Praesent consequat commodo urna vel rhoncus. Duis facilisis dictum dolor, et gravida turpis commodo ut. Donec ultricies ipsum elit, ac venenatis libero mattis varius. Sed in sem erat. Interdum et malesuada fames ac ante ipsum primis in faucibus. Vestibulum condimentum eros vel maximus volutpat."
                },

                // adventure

                new Movie
                {
                    Id = "009",
                    Poster = "mov_eget_placerat",
                    Name = "Eget Placerat",
                    Year = 1996,
                    Minutes = 116,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ADVENTURE,
                    DirectorId = "026",
                    ActorIds = new string[] { "028", "034", "038", "042", "044", "051" },
                    Description = "Aenean sollicitudin, velit id posuere pharetra, quam dui finibus diam, sed interdum dolor urna a ipsum. Aenean sit amet est dolor. Vestibulum lorem lectus, convallis eget ante eget, vulputate accumsan diam. Sed laoreet leo ex, vel mollis felis efficitur pulvinar. Nullam et lacus auctor, cursus metus vitae, blandit quam. Praesent pulvinar, mauris pretium mattis molestie, arcu nisi efficitur dolor, vitae dapibus enim ante tincidunt ipsum. Quisque eu egestas purus, eu vulputate dui."
                },

                new Movie
                {
                    Id = "010",
                    Poster = "mov_elementum",
                    Name = "Elementum",
                    Year = 2015,
                    Minutes = 98,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ADVENTURE,
                    DirectorId = "032",
                    ActorIds = new string[] { "008", "021", "027", "045", "059" },
                    Description = "Nam nulla ligula, fringilla in quam sit amet, auctor pellentesque neque. Nunc nec metus mi. Quisque porttitor ipsum massa, eu posuere nibh malesuada ut. Nam eget dictum elit. Curabitur sed sollicitudin est. Nunc metus leo, tempus sed nisi id, vehicula imperdiet arcu. Fusce tempus at felis quis interdum. Cras sed ex nisi. Aliquam non tortor id justo dignissim rutrum. Mauris et arcu libero. Quisque vestibulum quis sapien consequat fermentum. Nulla feugiat lacus a arcu malesuada sagittis. Duis tempor libero vel mauris viverra, a tristique tortor viverra. Suspendisse nec fringilla ante. Cras libero libero, tempus at lacus sed, tincidunt tempus quam. Aliquam quam eros, sodales non porta sed, finibus ut nisi."
                },

                new Movie
                {
                    Id = "011",
                    Poster = "mov_fermentum",
                    Name = "Fermentum",
                    Year = 1981,
                    Minutes = 84,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = true,
                    IsTrending = false,
                    Genre = MovieGenre.ADVENTURE,
                    DirectorId = "021",
                    ActorIds = new string[] { "014", "017", "023", "028", "032", "038", "039", "052", "056", "057", "059", "060" },
                    Description = "Nam sit amet egestas mauris. Sed sit amet lobortis nisi, id finibus lacus. Donec interdum purus felis, et imperdiet augue lacinia nec. Integer urna odio, imperdiet vestibulum vestibulum quis, porttitor sed tellus. Aenean molestie, augue vitae varius hendrerit, dui ante finibus quam, vehicula gravida nibh ante non massa. Nullam nec sem venenatis velit egestas facilisis. Vestibulum in purus enim. Pellentesque tristique arcu sit amet libero volutpat, ut ultrices augue auctor. Nunc egestas risus velit, ac euismod purus euismod at."
                },

                new Movie
                {
                    Id = "012",
                    Poster = "mov_maximus_odio",
                    Name = "Maximus Odio",
                    Year = 2018,
                    Minutes = 90,
                    IsInWatchlist = false,
                    IsFeatured = true,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ADVENTURE,
                    DirectorId = "003",
                    ActorIds = new string[] { "017", "024", "036", "042", "047", "053", "057", "058" },
                    Description = "Nam iaculis lectus nec velit commodo gravida ut vitae neque. Vestibulum rhoncus odio odio, eu viverra libero pulvinar at. Nam nulla arcu, pulvinar vel rutrum nec, ullamcorper nec ligula. Sed urna magna, dignissim nec consectetur sed, tincidunt non nisl. Sed dui felis, sagittis eu nibh ornare, cursus scelerisque diam. In blandit placerat dolor, id viverra diam tincidunt a. Pellentesque consequat turpis at nibh tincidunt tempor. Suspendisse luctus justo ac nunc lacinia, eu efficitur velit varius. Donec dignissim euismod ultrices. Vestibulum feugiat mauris ex, sit amet hendrerit sapien porttitor sed. Sed quis dui convallis, maximus sem vitae, tempus odio. Aenean rhoncus mauris enim, et tincidunt ipsum tempor et. Aenean tempus tempor libero ac posuere. Integer iaculis orci ligula, dignissim ullamcorper sem condimentum eget. Curabitur lacinia, urna non scelerisque condimentum, tellus massa sollicitudin felis, ac blandit ex odio ac sem. Integer viverra ante quis tellus vehicula dapibus."
                },

                new Movie
                {
                    Id = "013",
                    Poster = "mov_porttitor",
                    Name = "Porttitor",
                    Year = 2019,
                    Minutes = 94,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ADVENTURE,
                    DirectorId = "040",
                    ActorIds = new string[] { "005", "019", "023", "025", "032", "039", "041", "045", "047", "049", "051" },
                    Description = "Quisque vel molestie lacus. Sed luctus, nisi sit amet placerat sollicitudin, elit felis commodo enim, at ultrices est enim in odio. Duis laoreet lacus a justo tristique tincidunt. Maecenas in quam rutrum, molestie nunc ac, hendrerit nisi. Aenean nec diam at nibh sodales dictum. Donec iaculis lorem non rhoncus condimentum. Morbi sed placerat nisi. Nunc interdum orci quis varius elementum. Suspendisse cursus, libero quis feugiat aliquam, nunc erat ornare nisi, eget ultricies lorem mauris eget orci. Proin eget dolor rhoncus, imperdiet elit quis, venenatis ipsum. Pellentesque suscipit orci vitae interdum porttitor. Praesent mattis varius quam."
                },

                new Movie
                {
                    Id = "014",
                    Poster = "mov_ut_efficitur_vel",
                    Name = "Ut Efficitur Vel",
                    Year = 2010,
                    Minutes = 87,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ADVENTURE,
                    DirectorId = "040",
                    ActorIds = new string[] { "006", "008", "017", "025", "029", "032", "036", "037", "048", "049", "050", "055", "057", "059", "060" },
                    Description = "Quisque nibh dui, laoreet vel pulvinar ut, laoreet sit amet ipsum. Mauris ut sollicitudin arcu, sit amet faucibus nisl. Cras interdum justo a tristique condimentum. Sed porta lacus id ipsum fermentum, ac fringilla turpis vestibulum. Nunc mi urna, fringilla quis libero a, egestas laoreet felis. Duis id cursus diam. Mauris tempor et purus non commodo. Fusce ut libero lorem. Curabitur nec ex venenatis, facilisis urna at, tristique erat. Maecenas cursus sit amet velit a dapibus. Curabitur elementum elit ut nisi lacinia lobortis. Praesent auctor dolor eros, eu interdum eros posuere consectetur. Nullam non efficitur quam, id luctus quam. Donec convallis, augue nec cursus interdum, ex orci lobortis urna, vitae hendrerit odio erat a ante."
                },

                new Movie
                {
                    Id = "015",
                    Poster = "mov_vehicula_purus",
                    Name = "Vehicula Purus",
                    Year = 2008,
                    Minutes = 101,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ADVENTURE,
                    DirectorId = "036",
                    ActorIds = new string[] { "022", "028", "034", "037", "041", "042", "049", "055", "058", "059", "060" },
                    Description = "Suspendisse at eros ex. Maecenas mauris neque, laoreet et dictum vitae, rhoncus scelerisque elit. Cras elit turpis, sagittis a eros id, mattis luctus erat. Maecenas euismod laoreet leo. Phasellus nec ligula suscipit, laoreet nibh eu, finibus erat. Mauris eu scelerisque odio. Praesent venenatis nunc id massa bibendum molestie. Curabitur sit amet aliquam erat. Pellentesque odio risus, finibus id auctor ac, dictum eu erat. Nulla vitae mauris dapibus magna gravida pretium. Ut imperdiet imperdiet tristique. Sed in pharetra mi, sed auctor magna. Vivamus fringilla nunc quis lorem ornare finibus. Proin tincidunt euismod ex, ut dignissim justo. Sed fermentum sodales risus, id venenatis velit."
                },

                new Movie
                {
                    Id = "016",
                    Poster = "mov_venenatis_nec",
                    Name = "Venenatis Nec",
                    Year = 2014,
                    Minutes = 92,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.ADVENTURE,
                    DirectorId = "037",
                    ActorIds = new string[] { "002", "019", "028", "030", "047", "055", "057", "059", "060" },
                    Description = "Donec viverra fermentum lorem at auctor. Etiam tristique leo at ipsum tempus elementum a et mauris. Donec in euismod risus. Suspendisse lacinia quis dui in posuere. Nullam vehicula porta tellus, vulputate vulputate est commodo eget. Mauris sed mauris placerat, iaculis nibh a, tristique nibh. Nullam in sodales ex. Nullam vitae varius dolor. Sed laoreet, odio eu eleifend mollis, sapien purus consectetur massa, eget imperdiet sapien nisi non velit. Fusce ut malesuada libero."
                },

                // fantasy

                new Movie
                {
                    Id = "017",
                    Poster = "mov_dignissim_enim",
                    Name = "Dignissim Enim",
                    Year = 2000,
                    Minutes = 88,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = true,
                    IsTrending = false,
                    Genre = MovieGenre.FANTASY,
                    DirectorId = "054",
                    ActorIds = new string[] { "008", "010", "017", "018", "023", "028", "031", "035", "043", "048", "052", "055", "056", "058" },
                    Description = "Aliquam nibh felis, elementum sit amet nisl sed, ornare mollis sem. Maecenas maximus non nulla sed vestibulum. Nam scelerisque tincidunt mi vitae porta. Nulla ut lorem eu nibh lobortis fringilla ut ut magna. Phasellus ac neque ut neque bibendum commodo. Phasellus congue ex ligula, a lobortis orci finibus vitae. Proin at egestas risus, non malesuada lacus. Praesent diam est, volutpat a dolor eget, sagittis volutpat neque. Nunc fermentum mauris lectus, sed imperdiet urna lacinia at. Fusce quam libero, vehicula ut dui ut, interdum sodales est. Phasellus fermentum, lectus eu vestibulum consequat, lacus dui fringilla quam, ut aliquet eros nibh eu neque."
                },

                new Movie
                {
                    Id = "018",
                    Poster = "mov_et_erat",
                    Name = "Et Erat",
                    Year = 2003,
                    Minutes = 92,
                    IsInWatchlist = false,
                    IsFeatured = true,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.FANTASY,
                    DirectorId = "054",
                    ActorIds = new string[] { "002", "007", "017", "019", "024", "028", "031", "033", "036", "038", "42", "047", "050", "060" },
                    Description = "Fusce viverra risus nunc, non fermentum dui suscipit eget. Suspendisse imperdiet ac sem nec tincidunt. Maecenas non ante id augue pharetra dignissim nec eu enim. Sed at feugiat enim. Etiam lorem nulla, pellentesque vitae imperdiet sodales, ultricies vestibulum leo. Vivamus molestie elementum mi, eget ultrices libero consequat ut. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Proin sollicitudin tincidunt eleifend. Curabitur efficitur fringilla nisl, id tristique est pellentesque id. Nunc mollis arcu in neque auctor, nec faucibus erat consequat. Morbi egestas pellentesque molestie."
                },

                new Movie
                {
                    Id = "019",
                    Poster = "mov_gravida_risus",
                    Name = "Gravida Risus",
                    Year = 2014,
                    Minutes = 99,
                    IsInWatchlist = false,
                    IsFeatured = true,
                    IsNew = false,
                    IsTrending = true,
                    Genre = MovieGenre.FANTASY,
                    DirectorId = "037",
                    ActorIds = new string[] { "007", "013", "019", "023", "026", "029", "030", "034", "039", "045", "051", "054", "055", "059" },
                    Description = "Etiam dictum ultrices nisl et laoreet. Ut vitae viverra massa. Nam euismod blandit vulputate. Donec vitae convallis tellus, ut rutrum ante. Nunc fermentum nibh malesuada bibendum tempor. Nulla fringilla lorem volutpat, eleifend sapien non, accumsan leo. Suspendisse ex mauris, tempus eu finibus quis, suscipit ut tellus. Suspendisse sed mattis velit, lacinia ultrices enim. Maecenas maximus ligula vel nisi luctus mollis. Phasellus non massa rhoncus, convallis felis sit amet, commodo diam. Sed rhoncus condimentum facilisis. Mauris eget vulputate libero, a convallis dolor. Curabitur malesuada aliquam diam nec hendrerit. Sed vehicula quam viverra vestibulum viverra. Donec tempor metus ut tellus tristique lacinia."
                },

                new Movie
                {
                    Id = "020",
                    Poster = "mov_hendrerit_ac_ligula",
                    Name = "Hendrerit Ac Ligula",
                    Year = 2000,
                    Minutes = 91,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.FANTASY,
                    DirectorId = "021",
                    ActorIds = new string[] { "019", "023", "026", "027", "031", "036", "038", "040", "048", "052", "053", "058", "059" },
                    Description = "Mauris maximus interdum orci ac iaculis. Sed facilisis eleifend suscipit. Aliquam ultrices in sapien at posuere. Nullam eu purus et sem ullamcorper accumsan quis non nisi. Mauris mollis porta aliquet. Fusce non nisl volutpat sem feugiat vulputate. Nunc ac ultricies sem. Ut eleifend erat erat, vel auctor sapien bibendum vitae. Maecenas cursus vulputate magna et sollicitudin."
                },

                new Movie
                {
                    Id = "021",
                    Poster = "mov_lobortis_ipsum",
                    Name = "Lobortis Ipsum",
                    Year = 2006,
                    Minutes = 95,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = true,
                    IsTrending = false,
                    Genre = MovieGenre.FANTASY,
                    DirectorId = "003",
                    ActorIds = new string[] { "003", "004", "010", "022", "027", "033", "039", "045", "048", "049", "052", "054", "056" },
                    Description = "Nunc eleifend, mi eu tincidunt porta, ipsum turpis lacinia ipsum, varius vestibulum libero dui facilisis sem. Duis at massa aliquam, faucibus nisl et, viverra erat. Integer condimentum vitae nulla ac hendrerit. Donec sed finibus nisi. Donec ut pellentesque lectus. Vivamus quis dapibus nunc. Nam nec ex mollis libero rutrum pharetra in sit amet ipsum. Proin ac felis finibus, dignissim odio et, elementum eros. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sollicitudin risus id tortor euismod cursus."
                },

                new Movie
                {
                    Id = "022",
                    Poster = "mov_molestie",
                    Name = "Molestie",
                    Year = 1997,
                    Minutes = 103,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.FANTASY,
                    DirectorId = "036",
                    ActorIds = new string[] { "001", "004", "008", "012", "018", "023", "033", "040", "046", "048", "049", "050", "053", "057", "059" },
                    Description = "Phasellus scelerisque libero sit amet nibh ornare, eget efficitur enim interdum. Aliquam cursus consequat mi. In blandit imperdiet sapien imperdiet scelerisque. Vivamus tincidunt id lacus vel blandit. Integer viverra tellus dolor, vel congue felis auctor imperdiet. Donec a sem dignissim justo consectetur hendrerit lacinia vel ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin lectus massa, faucibus in leo ac, vehicula consequat metus. In porttitor quam sit amet elementum imperdiet. Integer elementum nibh ac odio hendrerit accumsan. In dapibus leo nisl. Sed convallis tempus augue non dignissim."
                },

                new Movie
                {
                    Id = "023",
                    Poster = "mov_nulla_dui",
                    Name = "Nulla Dui",
                    Year = 2004,
                    Minutes = 90,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.FANTASY,
                    DirectorId = "051",
                    ActorIds = new string[] { "009", "011", "016", "020", "021", "027", "028", "031", "034", "035", "038", "041", "043", "046", "049", "050", "055", "057" },
                    Description = "Etiam condimentum nisl in quam ornare egestas. Suspendisse pulvinar, diam id hendrerit ultrices, felis urna pulvinar tellus, vitae imperdiet ipsum purus ut ligula. Aenean sollicitudin, eros sed maximus sodales, est odio euismod diam, vitae iaculis nunc lorem vel massa. Mauris iaculis gravida velit, nec venenatis sem lacinia sit amet. Suspendisse in porta neque. Nam dignissim lacus in diam vulputate facilisis. Phasellus orci augue, pellentesque non feugiat blandit, finibus sed nulla."
                },

                new Movie
                {
                    Id = "024",
                    Poster = "mov_vel_dolor_viverra",
                    Name = "Vel Dolor Viverra",
                    Year = 2006,
                    Minutes = 101,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.FANTASY,
                    DirectorId = "054",
                    ActorIds = new string[] { "012", "016", "017", "019", "021", "026", "029", "030", "033", "037", "038", "044", "047", "048", "050", "053", "055" },
                    Description = "Vivamus placerat dictum urna vel volutpat. Aliquam sed tempus est, sed varius sapien. Curabitur interdum sed leo quis interdum. Nam eros nisl, ornare eget ex id, aliquet sodales sapien. Donec sit amet mollis erat. Nam sagittis dui ut leo cursus, nec venenatis odio tristique. Vestibulum consequat consequat volutpat. Praesent sodales libero nec magna ultrices ultrices. In tempus eget eros eu rhoncus. Fusce id neque vitae neque vulputate molestie in et tortor. Cras euismod augue vestibulum blandit tristique."
                },

                // horror

                new Movie
                {
                    Id = "025",
                    Poster = "mov_bibendum_ligula",
                    Name = "Bibendum Ligula",
                    Year = 1993,
                    Minutes = 87,
                    IsInWatchlist = false,
                    IsFeatured = true,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.HORROR,
                    DirectorId = "040",
                    ActorIds = new string[] { "010", "015", "020", "025", "030", "035", "036", "038", "039", "040", "041", "042", "045", "050" },
                    Description = "Integer a nisi rutrum enim sodales vehicula in nec neque. Duis convallis elit a ornare eleifend. Curabitur tincidunt diam in augue consectetur facilisis. Nunc fringilla fringilla feugiat. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Phasellus rhoncus, lacus ut aliquam porttitor, odio elit consectetur risus, sed efficitur ipsum enim et dui. Vivamus vehicula augue quis justo efficitur ultrices. In ac libero tincidunt, pellentesque purus sit amet, tincidunt nisi. Sed in urna ut quam pulvinar porta eu ut metus. In a faucibus massa. Vivamus commodo tincidunt lacinia. Suspendisse tristique nulla et nunc varius pulvinar. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam fermentum lectus id augue commodo imperdiet."
                },

                new Movie
                {
                    Id = "026",
                    Poster = "mov_diam_ultrices",
                    Name = "Diam Ultrices",
                    Year = 2010,
                    Minutes = 94,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = true,
                    Genre = MovieGenre.HORROR,
                    DirectorId = "032",
                    ActorIds = new string[] { "002", "004", "009", "013", "017", "019", "020", "031", "034", "037", "039", "041", "044", "048" },
                    Description = "Integer sed arcu pretium elit elementum hendrerit at semper arcu. Morbi vestibulum felis diam, vel condimentum felis feugiat nec. In pharetra lacus sit amet urna faucibus, at rutrum ante auctor. Maecenas venenatis commodo lectus, nec volutpat odio semper eget. Aenean sit amet velit pellentesque, placerat enim ac, sollicitudin sapien. Nulla ut luctus purus. Vivamus sollicitudin libero et ipsum dictum, eget lobortis velit dictum. Integer tempor ipsum et ante malesuada mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus nec condimentum ex. Nulla facilisi. Quisque molestie mauris at massa suscipit, in auctor libero ullamcorper. Nullam euismod semper fringilla. Curabitur id malesuada orci. Vivamus felis lorem, dictum vitae semper id, condimentum eu odio. Quisque auctor, mauris ut tempor elementum, tellus nisl tristique massa, semper tristique risus elit a libero."
                },

                new Movie
                {
                    Id = "027",
                    Poster = "mov_justo_quis",
                    Name = "Justo Quis",
                    Year = 2009,
                    Minutes = 100,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.HORROR,
                    DirectorId = "021",
                    ActorIds = new string[] { "009", "013", "016", "018", "032", "036", "039", "040", "041", "044", "047", "048", "049" },
                    Description = "Sed vel eleifend dolor. Donec pretium diam ac tellus volutpat posuere. In et aliquam enim. Maecenas viverra varius dictum. Sed maximus consequat orci. Aenean ut imperdiet risus, ut ultricies enim. Proin porta nisl massa. Suspendisse a massa sagittis lectus ultrices cursus."
                },

                new Movie
                {
                    Id = "028",
                    Poster = "mov_ligula_a_semper",
                    Name = "Ligula A Semper",
                    Year = 1987,
                    Minutes = 96,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.HORROR,
                    DirectorId = "051",
                    ActorIds = new string[] { "012", "015", "019", "022", "028", "031", "033", "035", "038", "043", "047" },
                    Description = "Integer sed ipsum est. Mauris urna sem, imperdiet id tempor in, tempus a velit. Aenean scelerisque nec justo vitae tristique. Nullam facilisis cursus risus, id convallis ipsum porta pharetra. Vivamus aliquet ut metus nec ornare. Mauris elementum facilisis tempor. Pellentesque lectus massa, posuere non nibh tempus, vulputate egestas libero. Sed porttitor pharetra dui vehicula tristique. Quisque ante dolor, aliquet quis orci quis, rhoncus maximus leo. Suspendisse id bibendum justo. Vestibulum congue, erat ut bibendum condimentum, nulla mi mattis massa, at tempor nisl neque sit amet lacus. Maecenas ut orci nisl. Nam et lacinia nisl, ac dapibus mauris. Nunc id pharetra nunc, dignissim ultrices sapien. Pellentesque sed iaculis augue. Sed rutrum mollis nunc."
                },

                new Movie
                {
                    Id = "029",
                    Poster = "mov_phasellus",
                    Name = "Phasellus",
                    Year = 2005,
                    Minutes = 88,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.HORROR,
                    DirectorId = "054",
                    ActorIds = new string[] { "021", "025", "027", "042", "044", "045", "048", "049", "050", "052", "053" },
                    Description = "Mauris orci felis, blandit ornare dolor vitae, semper auctor sem. Donec nec sapien vitae diam pulvinar commodo. Cras cursus leo arcu, ut varius sapien sodales vel. Curabitur tempor ac magna vel efficitur. Sed consectetur, sapien a dictum sodales, enim nulla pharetra mauris, in pellentesque nulla ex vel dolor. Aenean a ligula elementum, porta lectus a, venenatis nisi. Suspendisse in libero nec turpis tempus scelerisque nec ut erat. Nullam blandit blandit viverra. Morbi sit amet dictum urna. Nam quis venenatis tortor. Nam elit ex, vestibulum ut fermentum at, mattis vitae erat. Sed tempor risus at odio fringilla pellentesque. Suspendisse molestie vestibulum urna, a varius felis euismod nec. Donec tellus arcu, pharetra eu leo quis, sodales tristique dui. Suspendisse fringilla felis enim, at fringilla ante vulputate lacinia."
                },

                new Movie
                {
                    Id = "030",
                    Poster = "mov_ullamcorper",
                    Name = "Ullamcorper",
                    Year = 1992,
                    Minutes = 93,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.HORROR,
                    DirectorId = "003",
                    ActorIds = new string[] { "003", "006", "016", "019", "022", "025", "028", "032", "035", "038", "039", "043", "046", "047", "050", "052", "053" },
                    Description = "Sed egestas commodo massa ut aliquam. Ut ultricies laoreet dolor. Aenean eu mi massa. Nulla laoreet urna et leo luctus, in ultrices augue rhoncus. Donec euismod pulvinar arcu quis scelerisque. Morbi sit amet eros vel sem consectetur accumsan. Vivamus ornare elit lorem, sit amet laoreet mi semper in. Vestibulum vitae erat pulvinar arcu aliquam vulputate. Vivamus vel nibh enim. Donec commodo auctor elit, sit amet tristique metus convallis eget."
                },

                new Movie
                {
                    Id = "031",
                    Poster = "mov_ultrices_bibendum",
                    Name = "Ultrices Bibendum",
                    Year = 2014,
                    Minutes = 103,
                    IsInWatchlist = false,
                    IsFeatured = true,
                    IsNew = true,
                    IsTrending = true,
                    Genre = MovieGenre.HORROR,
                    DirectorId = "040",
                    ActorIds = new string[] { "010", "016", "019", "022", "028", "033", "039", "040", "045", "050", "055" },
                    Description = "Praesent odio lectus, tristique quis est nec, sodales pulvinar ligula. Maecenas rhoncus arcu a magna suscipit auctor. In fermentum massa at ligula feugiat tincidunt. Mauris mattis malesuada tortor, at semper sem elementum ut. Nunc scelerisque vitae elit at ornare. Morbi ut justo felis. Praesent eget eros magna. Mauris euismod leo velit, quis efficitur lacus pharetra ut. Suspendisse efficitur quam ac maximus lacinia. Ut interdum enim et sagittis maximus. Etiam nisl felis, porttitor eget turpis vel, porttitor facilisis tellus."
                },

                new Movie
                {
                    Id = "032",
                    Poster = "mov_urna_sit_amet",
                    Name = "Urna Sit Amet",
                    Year = 2016,
                    Minutes = 89,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.HORROR,
                    DirectorId = "056",
                    ActorIds = new string[] { "006", "010", "013", "018", "024", "025", "027", "032", "036", "039", "042", "045", "051", "052" },
                    Description = "Cras ut gravida ante. Aliquam ligula sapien, lobortis nec mauris ut, auctor tincidunt massa. Maecenas posuere auctor eros et dictum. Nulla at sodales lacus, sed ultricies magna. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer porta facilisis pellentesque. In vestibulum pellentesque arcu, dapibus porta neque semper vel. Curabitur sed nibh accumsan, vestibulum est at, interdum nibh. Morbi vitae lacinia diam. Praesent molestie faucibus libero. Suspendisse potenti. Cras arcu massa, laoreet ac velit rhoncus, tempus eleifend nisi. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer ipsum velit, imperdiet vulputate magna et, fringilla mattis lorem."
                },

                // mystert

                new Movie
                {
                    Id = "033",
                    Poster = "mov_augue",
                    Name = "Augue",
                    Year = 2002,
                    Minutes = 91,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.MYSTERY,
                    DirectorId = "021",
                    ActorIds = new string[] { "004", "011", "017", "022", "025", "029", "030", "032", "036", "039", "040", "042", "044", "046", "048" },
                    Description = "Aenean nec quam at ex faucibus viverra. Donec consequat turpis eget nunc imperdiet, et rutrum dui pellentesque. Quisque rhoncus diam vel enim cursus feugiat. Integer elementum enim ac est sagittis rutrum. Quisque sed justo sodales massa facilisis imperdiet ut non lacus. Sed feugiat leo eu efficitur lacinia. Ut ultricies, leo vitae commodo pulvinar, magna mauris iaculis nisl, id varius urna magna id dolor. Nulla convallis ligula arcu, fermentum suscipit tellus elementum eu. Fusce ut eleifend risus, a tempus quam. Nulla tempus eget turpis eget fringilla."
                },

                new Movie
                {
                    Id = "034",
                    Poster = "mov_condimentum_mi_tristique",
                    Name = "Condimentum Mi Tristique",
                    Year = 1998,
                    Minutes = 101,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.MYSTERY,
                    DirectorId = "037",
                    ActorIds = new string[] { "006", "016", "021", "032", "036", "038", "040", "042", "045", "048", "052", "055", "060" },
                    Description = "Nunc non facilisis magna, et malesuada neque. Cras laoreet dui id felis pharetra lobortis. Proin eros ligula, tincidunt vel finibus quis, tincidunt eget tellus. Donec at nisl a lorem porta consequat vel id mauris. Integer volutpat massa et lacus laoreet, id lacinia risus sollicitudin. Nunc lectus nibh, imperdiet at porttitor et, porta a augue. Suspendisse ullamcorper, metus placerat viverra varius, mauris dolor cursus est, quis mollis quam nisl at orci. Suspendisse in neque dolor. Integer sodales lacus vel arcu mattis, vitae luctus mauris pharetra. Maecenas egestas neque in dui feugiat venenatis. Fusce id ultrices tortor, ut lacinia erat. Ut erat ligula, pulvinar ac lectus in, commodo molestie ante. Sed sed lacus varius, luctus neque et, accumsan sapien. Curabitur neque lorem, sagittis sit amet convallis quis, accumsan quis justo."
                },

                new Movie
                {
                    Id = "035",
                    Poster = "mov_consequat",
                    Name = "Consequat",
                    Year = 2000,
                    Minutes = 91,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.MYSTERY,
                    DirectorId = "056",
                    ActorIds = new string[] { "009", "013", "015", "018", "022", "026", "029", "030", "033", "037", "039", "043", "044", "055" },
                    Description = "Maecenas orci nisi, gravida et imperdiet non, elementum eu orci. Quisque turpis arcu, molestie vel condimentum pharetra, mollis sit amet mi. Praesent non mauris sed sapien rutrum ultricies id ut turpis. Integer convallis tempus feugiat. Ut pulvinar, dolor vitae posuere tincidunt, ipsum libero rutrum mi, in hendrerit ante nisl porta urna. Etiam mattis velit sed consequat porta. Suspendisse non turpis in ipsum vestibulum venenatis. Donec vel porta ipsum, sit amet tempus massa. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Ut aliquam bibendum elit, in tincidunt enim vehicula non. Etiam dapibus aliquam purus et laoreet. Aliquam erat volutpat. Fusce porttitor vestibulum congue. Aenean imperdiet, nulla eget suscipit ullamcorper, lorem nunc lacinia lorem, at feugiat nunc lacus a diam. Vivamus ornare dolor ac erat consectetur, non sollicitudin elit posuere."
                },

                new Movie
                {
                    Id = "036",
                    Poster = "mov_fringilla",
                    Name = "Fringilla",
                    Year = 2013,
                    Minutes = 93,
                    IsInWatchlist = false,
                    IsFeatured = true,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.MYSTERY,
                    DirectorId = "011",
                    ActorIds = new string[] { "010", "011", "017", "019", "022", "025", "027", "028", "030", "031", "050", "054" },
                    Description = "Suspendisse interdum nunc nec mi feugiat consequat. Proin aliquet id est eget gravida. Nunc non dui vitae eros hendrerit tempus non vel nunc. Proin sodales libero ut nulla pretium, at imperdiet sem tempus. In hac habitasse platea dictumst. Donec libero elit, gravida vel mi sit amet, tincidunt porttitor mauris. Praesent sit amet enim erat. Aliquam erat volutpat. Duis suscipit purus non maximus accumsan. Quisque quis ipsum vitae erat lacinia auctor vel pretium diam."
                },
                    
                new Movie
                {
                    Id = "037",
                    Poster = "mov_gravida_rhoncus",
                    Name = "Gravida Rhoncus",
                    Year = 2018,
                    Minutes = 100,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.MYSTERY,
                    DirectorId = "056",
                    ActorIds = new string[] { "005", "018", "020", "023", "029", "033", "036", "038", "039", "043", "047", "049" },
                    Description = "In hac habitasse platea dictumst. Nunc at commodo elit. Maecenas ut feugiat risus. Praesent pretium dui a risus fermentum, luctus consectetur augue congue. Fusce hendrerit vulputate lectus, ac viverra quam dictum vitae. Suspendisse potenti. Praesent nisl leo, accumsan in placerat nec, pulvinar ac erat. Praesent ultrices laoreet justo, eu tristique felis maximus id."
                },

                new Movie
                {
                    Id = "038",
                    Poster = "mov_malesuada",
                    Name = "Malesuada",
                    Year = 2011,
                    Minutes = 97,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.MYSTERY,
                    DirectorId = "058",
                    ActorIds = new string[] { "013", "017", "020", "026", "029", "031", "034", "036", "039", "040", "042", "043", "049", "051", "055" },
                    Description = "Duis eleifend, mi tincidunt eleifend ultrices, dui ligula auctor dui, at rhoncus lectus augue quis magna. Praesent tincidunt nisi vitae massa consequat scelerisque. Phasellus ac dui luctus, cursus enim mollis, consequat lorem. Maecenas ut enim diam. Nunc a lacinia justo, sed vulputate est. Quisque ultricies lacus faucibus turpis ultricies laoreet. Donec sit amet ipsum vitae massa luctus vestibulum. Phasellus laoreet libero odio, vitae congue purus faucibus quis. Aenean eu libero eros."
                },

                new Movie
                {
                    Id = "039",
                    Poster = "mov_proin_dui_nisi",
                    Name = "Proin Dui Nisi",
                    Year = 2011,
                    Minutes = 99,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.MYSTERY,
                    DirectorId = "040",
                    ActorIds = new string[] { "011", "014", "029", "032", "033", "035", "039", "043", "047", "048", "049" },
                    Description = "Aliquam sapien elit, ultricies quis dolor sit amet, bibendum auctor tellus. Nunc tempus pulvinar nibh, et rutrum nunc tempor et. In ornare vitae nulla eu laoreet. Maecenas ac enim id dui volutpat sodales at vitae lectus. Sed nibh enim, varius quis nunc vitae, placerat laoreet odio. Sed hendrerit tortor eget mauris sagittis, et sagittis diam tristique. Praesent euismod nibh ac augue ultricies, porttitor tempor odio mattis. Sed a vehicula est, sit amet ullamcorper lacus. Curabitur nisl sapien, ultricies eu cursus ut, facilisis semper quam. Suspendisse scelerisque mauris vel diam tincidunt, in pharetra metus porta. Curabitur sit amet placerat ex."
                },

                new Movie
                {
                    Id = "040",
                    Poster = "mov_vel_tellus",
                    Name = "Vel Tellus",
                    Year = 2013,
                    Minutes = 104,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = true,
                    Genre = MovieGenre.MYSTERY,
                    DirectorId = "056",
                    ActorIds = new string[] { "025", "028", "030", "033", "037", "040", "044", "053" },
                    Description = "Donec nec congue augue. Morbi tristique a quam vel efficitur. Ut at sodales lacus, nec rutrum libero. Phasellus at lobortis dui, ut commodo sapien. Etiam viverra lacinia metus, quis convallis magna. Ut euismod ultrices purus. Vivamus lobortis ac arcu a varius. Sed dictum, mauris non condimentum iaculis, dui sapien convallis eros, sed sollicitudin augue nunc nec nisi. Nullam pulvinar varius justo ut dignissim. Suspendisse placerat nibh purus, non efficitur mi condimentum a. In at dui at lectus gravida euismod. Pellentesque ornare nibh non finibus viverra."
                },

                // since fiction

                new Movie
                {
                    Id = "041",
                    Poster = "mov_ante_sed",
                    Name = "Ante Sed",
                    Year = 2008,
                    Minutes = 84,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.SCIENCE_FICTION,
                    DirectorId = "051",
                    ActorIds = new string[] { "002", "009", "016", "019", "022", "025", "029", "032", "037", "039", "041", "042", "048", "051", "052" },
                    Description = "Pellentesque at mauris erat. Maecenas et risus posuere, imperdiet nunc non, condimentum quam. Pellentesque mattis efficitur mi, sed pretium orci. Vivamus diam felis, sagittis quis felis ac, laoreet auctor ligula. Mauris convallis, risus sed suscipit semper, nibh nisi fringilla orci, vel finibus augue enim a massa. Quisque sagittis tincidunt fermentum. Nulla pellentesque eget enim quis vestibulum. Curabitur egestas dolor nec ex elementum placerat. Maecenas ullamcorper nisl a ultrices blandit."
                },

                new Movie
                {
                    Id = "042",
                    Poster = "mov_congue_quam",
                    Name = "Congue Quam",
                    Year = 2008,
                    Minutes = 92,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.SCIENCE_FICTION,
                    DirectorId = "037",
                    ActorIds = new string[] { "010", "017", "021", "025", "029", "032", "037", "039", "041", "044", "048", "052", "055", "059" },
                    Description = "Nam ultrices neque porta eros molestie, at elementum neque dictum. Nam eget magna neque. Duis egestas sodales elementum. Mauris feugiat ligula non ante posuere mattis. Nullam sit amet suscipit orci. Suspendisse ultrices rhoncus sodales. Curabitur lectus justo, maximus semper laoreet eu, tincidunt at arcu. Sed vel hendrerit sapien. Morbi sagittis odio lacus, ac vehicula ipsum tincidunt quis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla eget molestie nulla. Sed vitae massa lectus. Donec nisl sapien, pellentesque eu ultricies non, sollicitudin at tortor."
                },

                new Movie
                {
                    Id = "043",
                    Poster = "mov_eleifend_ex_justo",
                    Name = "Eleifend Ex Justo",
                    Year = 2004,
                    Minutes = 99,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = true,
                    Genre = MovieGenre.SCIENCE_FICTION,
                    DirectorId = "044",
                    ActorIds = new string[] { "003", "009", "016", "025", "032", "037", "039", "040", "043", "049" },
                    Description = "Nunc at rutrum elit. Duis vitae gravida magna. Nulla tincidunt lobortis eros et dapibus. Cras tempus urna felis, non aliquam lectus feugiat ac. Maecenas laoreet arcu vitae porta interdum. Integer fringilla risus et tortor sollicitudin, a laoreet nibh lobortis. Nunc ultricies elit eu ligula lobortis rutrum. Vivamus sodales, nunc sit amet semper aliquet, nisi metus pretium magna, id auctor magna urna at ante. Etiam in odio lobortis, imperdiet diam et, vehicula nunc. Nulla iaculis nisi vel erat accumsan, quis scelerisque augue condimentum. Proin ut odio imperdiet, vehicula nulla vel, malesuada risus. Mauris gravida eros at magna lobortis, non congue velit blandit. Maecenas hendrerit fermentum rutrum."
                },

                new Movie
                {
                    Id = "044",
                    Poster = "mov_massa_tempus",
                    Name = "Massa Tempus",
                    Year = 1985,
                    Minutes = 88,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.SCIENCE_FICTION,
                    DirectorId = "051",
                    ActorIds = new string[] { "003", "007", "010", "014", "017", "026", "029", "033", "036", "044", "046", "048" },
                    Description = "Proin sollicitudin urna id quam fermentum viverra. Etiam et leo hendrerit, gravida ipsum vel, rhoncus leo. Etiam ornare arcu quam, dignissim luctus mi pharetra sed. Maecenas blandit sapien sit amet augue finibus, non facilisis diam porttitor. Phasellus vitae iaculis justo. Vestibulum mauris magna, sollicitudin at auctor vitae, viverra sit amet sem. Etiam ligula odio, pharetra ac leo et, lobortis aliquam justo. Nunc maximus tincidunt laoreet. Fusce posuere tincidunt enim, at tristique dolor hendrerit vestibulum. Integer commodo augue eu tristique luctus. Aliquam non varius quam. Morbi consequat ex metus, ut tincidunt ipsum iaculis id. Proin nunc purus, vehicula non quam nec, condimentum egestas diam. In at tempor urna. Nulla pretium dui vel ligula maximus, et porttitor ex cursus."
                },

                new Movie
                {
                    Id = "045",
                    Poster = "mov_molestie_eros",
                    Name = "Molestie Eros",
                    Year = 1999,
                    Minutes = 94,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.SCIENCE_FICTION,
                    DirectorId = "032",
                    ActorIds = new string[] { "006", "007", "012", "017", "021", "025", "029", "030", "033", "036", "039", "041", "045" },
                    Description = "Nam nec orci lobortis, dapibus odio vel, auctor massa. Nulla in nulla pellentesque, fermentum nunc eget, fringilla tellus. Aliquam vitae elit at risus viverra iaculis. Proin orci neque, gravida nec dictum et, mattis in metus. Pellentesque vulputate orci nisi, eget consectetur ipsum cursus ac. Integer tincidunt ut elit quis aliquam. Pellentesque sit amet velit ultricies, tempor nisi eget, consequat nunc. Cras efficitur laoreet risus, ac finibus est sollicitudin quis. Morbi consectetur arcu eget ipsum feugiat, eu viverra lacus rutrum. Quisque condimentum suscipit turpis, quis accumsan risus facilisis sodales. Etiam ante justo, commodo at ullamcorper eu, lobortis vel massa. Sed vel pellentesque nisl. Vestibulum quis urna a nisl feugiat molestie."
                },

                new Movie
                {
                    Id = "046",
                    Poster = "mov_proin_dui",
                    Name = "Proin Dui",
                    Year = 2019,
                    Minutes = 93,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.SCIENCE_FICTION,
                    DirectorId = "040",
                    ActorIds = new string[] { "001", "009", "015", "016", "019", "022", "026", "029", "033", "035", "039", "045", "046", "051" },
                    Description = "Nam fermentum, dui vel tristique molestie, mauris dolor aliquam erat, sed finibus felis massa at mauris. Phasellus sed justo dolor. Etiam lacinia tortor non posuere iaculis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin mollis iaculis maximus. Donec felis ipsum, dignissim quis tincidunt pellentesque, hendrerit ut felis. Maecenas congue libero at est faucibus, id blandit odio rhoncus. Fusce id odio eget purus finibus semper id in nisl. Nam a purus non risus tristique aliquet quis vel nisl. Quisque mauris orci, lacinia et convallis et, tempor eu quam. Duis bibendum luctus sapien. Suspendisse sem turpis, blandit non metus vel, placerat vehicula erat. Ut rhoncus nibh a nunc tincidunt finibus. Nulla quis enim est. Vestibulum varius nunc eu faucibus consectetur."
                },

                new Movie
                {
                    Id = "047",
                    Poster = "mov_risus_at_tincidunt",
                    Name = "Risus At Tincidunt",
                    Year = 2003,
                    Minutes = 103,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = true,
                    Genre = MovieGenre.SCIENCE_FICTION,
                    DirectorId = "056",
                    ActorIds = new string[] { "007", "017", "022", "026", "030", "033", "038", "039", "040", "045", "048", "053", "056", "060" },
                    Description = "Donec bibendum nec risus quis tempor. Proin quam ligula, dictum non aliquet id, auctor nec nisl. Suspendisse non accumsan arcu. Etiam sagittis, mi eget interdum pulvinar, arcu ex accumsan erat, in pellentesque est massa vitae arcu. Integer egestas feugiat odio, vel iaculis sapien gravida quis. Vestibulum cursus commodo molestie. Aliquam facilisis augue vel blandit laoreet. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vivamus ut laoreet augue. In ullamcorper lacus ac aliquet porttitor. Maecenas congue erat a justo semper porta. Nulla porttitor velit sit amet ipsum facilisis tempus. Proin quis justo ac magna vehicula blandit ut vel urna."
                },

                new Movie
                {
                    Id = "048",
                    Poster = "mov_ultrices_etiam",
                    Name = "Ultrices Etiam",
                    Year = 2014,
                    Minutes = 110,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.SCIENCE_FICTION,
                    DirectorId = "058",
                    ActorIds = new string[] { "011", "015", "018", "022", "027", "029", "032", "036", "044", "045", "049", "050", "056" },
                    Description = "Aenean posuere justo lectus. Nam sit amet eros placerat, dignissim sem nec, euismod metus. Sed sollicitudin at lacus ut mattis. Nunc lacinia ipsum urna, hendrerit luctus eros sodales nec. Nulla pretium elit id dui feugiat molestie. Donec imperdiet in mi eu ultrices. Morbi scelerisque enim in gravida pretium. Integer tortor turpis, consequat et nisl ut, lacinia lobortis diam. Nam quis turpis ante."
                },

                // thriller

                new Movie
                {
                    Id = "049",
                    Poster = "mov_adipiscing",
                    Name = "Adipiscing",
                    Year = 2009,
                    Minutes = 99,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.THRILLER,
                    DirectorId = "051",
                    ActorIds = new string[] { "003", "005", "007", "009", "012", "016", "019", "023", "026", "027", "035", "038", "040", "044", "047" },
                    Description = "Nunc a magna erat. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eu euismod risus. Curabitur pretium sagittis felis, ornare venenatis diam. Quisque at quam eget metus dapibus posuere sed eu lorem. Donec gravida augue ut augue suscipit aliquam. Donec egestas nibh eu nulla feugiat sagittis. Donec luctus elit non consectetur faucibus. Donec ut dignissim lorem. Integer quis sagittis ex. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Maecenas sit amet eleifend erat."
                },

                new Movie
                {
                    Id = "050",
                    Poster = "mov_curabitur_posuere",
                    Name = "Curabitur Posuere",
                    Year = 1996,
                    Minutes = 95,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = true,
                    Genre = MovieGenre.THRILLER,
                    DirectorId = "032",
                    ActorIds = new string[] { "006", "016", "022", "025", "031", "037", "041", "045", "048", "050", "053", "056", "059" },
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque maximus blandit leo, a finibus augue egestas a. Praesent euismod tincidunt tellus vitae semper. Phasellus lobortis ut urna sed volutpat. Aliquam a vestibulum nibh. Fusce volutpat nisi porta molestie semper. Integer sit amet lacus in urna lobortis interdum. Sed mattis urna mattis sem imperdiet varius. Aenean non pretium est. Nulla ut aliquet tellus."
                },

                new Movie
                {
                    Id = "051",
                    Poster = "mov_in_consectetur",
                    Name = "In Consectetur",
                    Year = 2003,
                    Minutes = 89,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.THRILLER,
                    DirectorId = "044",
                    ActorIds = new string[] { "008", "009", "010", "014", "017", "019", "021", "022", "025", "027", "032", "035", "038", "042", "044", "048" },
                    Description = "Nulla venenatis dolor ac nulla pretium porttitor. In lobortis augue nibh, sit amet rutrum ligula commodo et. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis dignissim eros orci, sit amet lacinia lacus tempus a. Nulla sapien ligula, feugiat non posuere nec, mattis sit amet velit. Etiam maximus purus nec orci rutrum venenatis. Morbi pharetra a lacus posuere tempus. Fusce eu blandit nibh. Phasellus fringilla aliquam ultricies. Phasellus accumsan mauris nec mollis cursus. Mauris varius quis risus vel fermentum. Sed nec velit non tortor molestie posuere."
                },

                new Movie
                {
                    Id = "052",
                    Poster = "mov_natoque",
                    Name = "Natoque",
                    Year = 2015,
                    Minutes = 84,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.THRILLER,
                    DirectorId = "049",
                    ActorIds = new string[] { "011", "015", "019", "022", "026", "029", "032", "037", "039", "043", "046", "049", "052" },
                    Description = "Morbi congue fermentum feugiat. Proin hendrerit porttitor ipsum ac pharetra. Nulla iaculis, urna ac varius aliquet, ex nisl dictum est, eu sodales mauris ante vitae diam. Aenean augue odio, congue at nulla et, ultrices pellentesque sem. Curabitur aliquam pretium ultricies. Etiam sit amet eros sed tortor rutrum gravida quis in nisi. Quisque vestibulum, augue quis vehicula finibus, lectus metus pulvinar arcu, sit amet placerat metus odio non nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. In vitae libero suscipit, volutpat nulla nec, varius sem. Nulla finibus, nisl at mollis commodo, leo urna imperdiet erat, luctus eleifend mi ligula nec nulla. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Etiam blandit gravida euismod."
                },

                new Movie
                {
                    Id = "053",
                    Poster = "mov_nibh_sapien",
                    Name = "Nibh Sapien",
                    Year = 2007,
                    Minutes = 96,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.THRILLER,
                    DirectorId = "051",
                    ActorIds = new string[] { "008", "012", "020", "025", "029", "035", "039", "044", "049", "052", "056" },
                    Description = "Donec volutpat tempus est, vel laoreet lacus feugiat vel. Integer quis nulla felis. Donec condimentum libero sem, eget accumsan massa cursus vel. Vivamus a lectus nunc. Aliquam nec sapien ut tellus volutpat laoreet. Mauris pulvinar orci nisi, et pulvinar magna tempus eu. Sed congue gravida posuere. Vestibulum vitae molestie ex."
                },

                new Movie
                {
                    Id = "054",
                    Poster = "mov_quis_nisi",
                    Name = "Quis Nisi",
                    Year = 2005,
                    Minutes = 87,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = true,
                    Genre = MovieGenre.THRILLER,
                    DirectorId = "044",
                    ActorIds = new string[] { "021", "025", "027", "030", "033", "038", "039", "041", "044", "047", "050", "055" },
                    Description = "Maecenas quis ipsum facilisis ex ullamcorper vestibulum eu sed arcu. Quisque vel ex in est vehicula tristique. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Etiam egestas metus quis nulla sodales, id efficitur ante cursus. Vivamus felis lorem, interdum vitae interdum pulvinar, finibus eu nisi. Aenean commodo condimentum libero. Vestibulum bibendum ligula sit amet enim hendrerit, vitae ullamcorper nisl blandit. Suspendisse feugiat, elit a consequat mollis, nunc justo ullamcorper purus, vulputate facilisis arcu lectus nec ligula. Cras eget orci tortor. Sed sed lorem ante. Donec eleifend elit quis elementum iaculis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec maximus interdum vulputate. Curabitur facilisis felis orci, vitae aliquet eros fermentum at. Duis non augue pharetra, accumsan eros sed, rhoncus felis. Donec posuere, dolor at porttitor tristique, dolor magna elementum felis, ac interdum lacus felis ac nibh."
                },

                new Movie
                {
                    Id = "055",
                    Poster = "mov_vestibulum",
                    Name = "Vestibulum",
                    Year = 2013,
                    Minutes = 119,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.THRILLER,
                    DirectorId = "049",
                    ActorIds = new string[] { "022", "027", "034", "038", "041", "044", "045", "051", "052" },
                    Description = "Maecenas eget massa sapien. Proin ut erat tortor. Nam at ullamcorper arcu, ut pulvinar nibh. Maecenas aliquam vel metus ac facilisis. Nunc hendrerit pharetra turpis sit amet placerat. Aliquam nec egestas velit. Quisque lacus nisi, facilisis id nunc vel, tempus hendrerit elit."
                },

                new Movie
                {
                    Id = "056",
                    Poster = "mov_vitae_laoreet",
                    Name = "Vitae Laoreet",
                    Year = 1996,
                    Minutes = 88,
                    IsInWatchlist = false,
                    IsFeatured = false,
                    IsNew = false,
                    IsTrending = false,
                    Genre = MovieGenre.THRILLER,
                    DirectorId = "044",
                    ActorIds = new string[] { "012", "015", "017", "018", "021", "023", "027", "029", "034", "039", "040", "044", "047" },
                    Description = "Morbi tincidunt, sapien in blandit posuere, sapien mauris vulputate odio, id tristique erat purus non arcu. Pellentesque ac orci a odio auctor finibus. Morbi gravida nec dui nec consequat. Nunc est neque, auctor at pharetra eu, hendrerit id turpis. Maecenas metus tellus, sagittis quis felis eu, ultrices iaculis quam. Duis consectetur lacus eu interdum posuere. Maecenas rutrum ornare viverra. Donec vitae euismod massa. Sed tortor felis, suscipit convallis scelerisque sed, viverra vel arcu. Pellentesque sollicitudin sollicitudin elit, vel volutpat mi semper in. Suspendisse quis enim ornare, blandit sapien vitae, pharetra dolor. Sed pharetra volutpat lorem, quis blandit ante. Quisque placerat suscipit gravida. Nulla molestie felis dignissim commodo molestie."
                },

            };
        }

    }
}

