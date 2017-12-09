using System;
using System.Collections.Generic;
using System.Net;

using Xamarin.Forms;


namespace XamTut
{
    public partial class LoginPage : ContentPage
    {

        String userString, Password;
        public LoginPage()
        {
            InitializeComponent();
            if (Device.Idiom == TargetIdiom.Tablet)
            {
                Login.FontSize = 36;
            }
            else Login.FontSize = 24;

            var messageTile = new MessageTiles("Andrew","Watson","Message");
            messageTile.HeightRequest = 34;
            messageTile.WidthRequest = 30;
            messageTile.IsEnabled = true;
            griddy.Children.Add(messageTile);
        }


        void Handle_Submit(object sender, System.EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://wwww.");
        }


        void Handle_Username(object sender, System.EventArgs e)
        {
            Set_User(sender as Entry);
        }
        void Handle_Password(object sender, System.EventArgs e)
        {
            Set_Pass(sender as Entry);
        }
        void Set_User(object sender)
        {
            userString = (sender as Entry).Text;
        }
        void Set_Pass(object sender)
        {
            Password = (sender as Entry).Text;
        }

    }
}
