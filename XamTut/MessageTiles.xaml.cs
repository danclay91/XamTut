using System;
using System.Collections.Generic;

using Xamarin.Forms;

/*
 * This is the message tile used to display messages in the conversation page It takes a message object and time string
 * 
 */
namespace XamTut
{
    public partial class MessageTiles : ContentView
    {
        
        object message, timeString;
        public MessageTiles(Message message, String timeString)
        {
            
            this.message = message;
            this.timeString = timeString;
            InitializeComponent(); 

            Message.Text = message.getMessageBody();
            TimeStamp.Text = timeString;
            Padding = new Thickness(0, 20, 0, 0);


        }

       
    }
}
