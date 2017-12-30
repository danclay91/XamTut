using System;
using System.Net.Http;

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
        
        HttpClient client = new HttpClient();
        static Uri local = new Uri("http://localhost:1337");
        HttpRequestMessage requestMessage = new HttpRequestMessage { RequestUri = local };

        HttpResponseMessage responseMessage = new HttpResponseMessage();
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

        async void Test_Node(object sender, System.EventArgs e)
        {

            //client.SendAsync(requestMessage);
            var response = await client.GetAsync(local);
            await DisplayAlert((response.Content.ToString()), "ok", "ok");

        }

    }
}
 