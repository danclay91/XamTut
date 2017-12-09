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


           
        }

        /*
            This event handler will eventually send the data entered into the Username and Password Entries 
                To server for verification
        */
        void Handle_Submit(object sender, System.EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://wwww.");
        }

        /*
         *  RETURN KEY MUST BE PRESSED TO CALL THE HANDLER
         *  This handler calls the Set_User method to set the userString field equal to the 
         *  data entered into the username Entry
         *      
         */
        void Handle_Username(object sender, System.EventArgs e)
        {
            Set_User(sender as Entry);
        }

        /*
         *  RETURN KEY MUST BE PRESSED TO CALL THE HANDLER
         *  This handler does the same as Handle_Username except for the password field
         */
        void Handle_Password(object sender, System.EventArgs e)
        {
            Set_Pass(sender as Entry);
        }

        /*
         *  Setter for userString field. Called by user handler 
         */
        void Set_User(object sender)
        {
            userString = (sender as Entry).Text;
        }

        /*
         *  Setter for password field. Called by password handler
         */
        void Set_Pass(object sender)
        {
            Password = (sender as Entry).Text;
        }

        /*
         *  Temporary navigation handler to Test Conversation page. Called
         *  after pressing ToolsPage button
         */
        void ToConversationPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConversationPage("Who cares"));
        }
    }
}
