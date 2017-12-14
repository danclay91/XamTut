using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;
namespace XamTut
{
    public class Message : IEnumerable<Message>
    {
        public Message()
        {
        }
        public String message { get; set; }
        public String Recipient { get; set; }

        public IEnumerator<Message> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
