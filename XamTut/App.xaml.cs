using System;

using Xamarin.Forms;

namespace XamTut
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = false;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new NavigationPage( new LoginPage());
            else
                MainPage = new NavigationPage(new MainPage());
        }
    }
}
