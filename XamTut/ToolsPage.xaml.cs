using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Linq;
using XamTut.Models;


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

       
        void ToMessagesPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(messages);
        }

        async void Test_Node(object sender, System.EventArgs e)
        {
            string userName = "Danny";
            IList<Message> dummyMessages = await ConnectionManager.GetMessagesAsync(userName);
            foreach(Message message in dummyMessages){
                await DisplayAlert(userName + " Messages", message.Content, "OK");
            }
        }

    }
}
 

