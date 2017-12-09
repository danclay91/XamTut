using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTut
{
    public partial class ConversationPage : ContentPage
    {
        String recipient, bodyToSend;
        public ConversationPage(String recipient)
        {
            this.recipient = recipient;
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
        public void setText(String text){
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
            grid.Children.Add(new MessageTiles(new Message(recipient, bodyToSend), stamp ));
        }

        /*
         *  Dummy receive message method that will be used for testing conversation page 
         */
        public void ReceiveMessage(Message message){
            var stamp = DateTime.Now.ToString("hh:mm");
            grid.Children.Add(new MessageTiles(message, stamp));
        }

    }
}