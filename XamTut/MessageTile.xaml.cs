using System;
using System.Collections;
using System.Collections.Generic;

using Xamarin.Forms;

/*
 * This is the message tile used to display messages in the conversation page It takes a message object and time string
 * 
 */
namespace XamTut
{
    public partial class MessageTile : ContentView, IEnumerable<MessageTile>
    {
        
        object message, timeString;
        public MessageTile(OldMessage message, String timeString, Color backGroundColor)
        {
            this.BackgroundColor = backGroundColor;
            this.message = message;
            this.timeString = timeString;
            InitializeComponent();

            Message.Text = message.message;
            TimeStamp.Text = timeString;

        }

        public IEnumerator<MessageTile> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
