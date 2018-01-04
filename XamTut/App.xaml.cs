using System;

using Xamarin.Forms;
using XamTut.Services;

namespace XamTut
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = false;
        public static string BackendUrl = "https://localhost:5000";
        public static string UserName { get; set; }
        public static string RecipientUserName { get; set; }
        public static IDataStore DataStore { get; set; }

        public App()
        {
            InitializeComponent();
            //JUST FOR TESTING
            UserName = "Danny";
            DataStore = new MockDataStore();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new NavigationPage( new LoginPage());
            else
                MainPage = new NavigationPage(new MainPage());
        }
    }
}
