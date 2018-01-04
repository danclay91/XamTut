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
        String recipient, bodyToSend;
        int count = 0;
        List<MessageTile> MessageTile = new List<MessageTile>();
        ObservableCollection<Message> UserMessages; 

        public ConversationPage(string recipient)
        {
            this.recipient = recipient;
            UserMessages = new ObservableCollection<Message>();
            InitializeComponent();
            messageList.ItemsSource = UserMessages;
            var msg = LoadMessages();



        }

        async Task<List<Message>> LoadMessages()
        {
            List<Message> messages = await App.DataStore.GetMessagesAsync(this.recipient);
            return messages;

        }

        public ConversationPage(){
            InitializeComponent();
        }



        /*
         * MUST HIT RETURN FOR THIS HANDLER TO BE CALLED
         *  Event Handler for message Entry completion
         */

        void Complete_Message_Event(object sender, System.EventArgs e)
        {
            setText((sender as Entry).Text);
        }

        /*
         *  Method used to set bodyToSend field equal to message Entry  
         */
        public void setText(String text)
        {
            bodyToSend = text;
        }

        /*
         *  handler for submit button on Conversation Page. Creates time stamp and Message object 
         *  to initialize MessageTile. 
         *  new Message Tile added to children of Grid named grid
         */
        void Send_Message_Event(object sender, System.EventArgs e)
        {
            var stamp = DateTime.Now.ToString("hh:mm");
            MessageTile.Add(new MessageTile(new OldMessage { Recipient = recipient, message=bodyToSend }, stamp, Color.Red));
            grid2.Children.Add(MessageTile[count]);
            (MessageTile[count] as MessageTile).HorizontalOptions = LayoutOptions.FillAndExpand;
            Grid.SetRow(MessageTile[count], count);
            count++;
        }
        /*
         * 
         * 
         */
        void Handle_Receipt(object sender, System.EventArgs e)
        {
            ReceiveMessage(new OldMessage { Recipient="Andrew", message="Hey bro" } );
        }

        /*
         *  Dummy receive message method that will be used for testing conversation page 
         */
        public void ReceiveMessage(OldMessage message)
        {
            var stamp = DateTime.Now.ToString("hh:mm");
            MessageTile.Add(new MessageTile(message, stamp, Color.Blue));
            grid2.Children.Add(MessageTile[count]);
            Grid.SetRow(MessageTile[count], count);
            count++;

        }

    }
}