using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace XamTut
{
    public partial class MessageTiles : ContentView
    {
        String sender, receiver, message;
        public MessageTiles(String sender, String receiver, String message )
        {
            this.sender = sender;
            this.receiver = receiver;
            this.message = message;
            InitializeComponent();

            //DateTime dateTime = new DateTime();
            //TimeStamp.Text = dateTime.ToString();
            Message.Text = message;
        }

        
    }
}
