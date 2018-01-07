using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamTut.Models;

namespace XamTut
{
    public partial class ConversationPage : ContentPage
    {
        public Command LoadMessagesCommand { get; set; }

        String recipient;

        List<MessageTile> MessageTile = new List<MessageTile>();
        ObservableCollection<Message> UserMessages; 

        public ConversationPage(string recipient)
        {
            this.recipient = recipient;
            UserMessages = new ObservableCollection<Message>();
            InitializeComponent();
            messageList.ItemsSource = UserMessages;
            LoadMessagesCommand = new Command(async () => await LoadMessages());
            LoadMessagesCommand.Execute(null);

        }

        async Task LoadMessages()
        {
            UserMessages.Clear();
            List<Message> messages = await App.DataStore.GetMessagesAsync(this.recipient);
            foreach(Message msg in messages){
                UserMessages.Add(msg);
            }
        }

        public ConversationPage(){
            InitializeComponent();
        }


        void SendMessage(object sender, System.EventArgs e)
        {
            Message msgToSend = new Message();
            msgToSend.Sender = App.UserName;
            msgToSend.Content = MessageField.Text;
            msgToSend.Recipient = this.recipient;
            App.DataStore.AddMessageAsync(msgToSend);
            LoadMessagesCommand.Execute(null);
        }

    }
}