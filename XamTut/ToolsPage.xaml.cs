using System;
using System.Collections.Generic;

using Xamarin.Forms;
/*  This page will hold tiles that link to tools in the application
 * 
 * 
 */


namespace XamTut
{
    public partial class ToolsPage : ContentPage
    {
        Messages messages = new Messages();
        ConversationPage conversation = new ConversationPage("Andrew");
        public ToolsPage()
        {
            InitializeComponent();

        }

        /*
         *  Temporary navigation handler to Test Messages page. Called
         *  after pressing Messages button
         */
        void ToMessagesPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(messages);

        }
    }
}
