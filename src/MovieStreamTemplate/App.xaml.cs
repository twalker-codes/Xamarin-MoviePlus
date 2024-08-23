using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MovieStreamTemplate.Services;
using MovieStreamTemplate.Views;
using MovieStreamTemplate.DataStores.MockDataStore;

namespace MovieStreamTemplate
{
    public partial class App : Application
    {
        /*
         * PersonDetailPage
         */

        public App ()
        {
            InitializeComponent();

            DependencyService.RegisterSingleton(new PersonDataStore());
            DependencyService.RegisterSingleton(new ReviewDataStore());
            DependencyService.RegisterSingleton(new MovieDataStore());
            DependencyService.RegisterSingleton(new WatchlistItemDataStore());
            DependencyService.RegisterSingleton(new DownloadItemDataStore());
            DependencyService.RegisterSingleton(new ProfileDataStore());
            DependencyService.RegisterSingleton(new SearchItemDataStore());

            DependencyService.Register<IService, MockService>();

            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

