using System;
namespace XamTut.Models
{
    public class Message
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Content { get; set; }
        public bool IsSentMessage
        {
            get
            {
                if (Recipient == App.UserName)
                {
                    return true;
                }
                else{
                    return false;
                }
            }
        }
    }
}
