using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;
namespace XamTut
{
    public class OldMessage : IEnumerable<OldMessage>
    {
        public OldMessage()
        {
        }
        public String message { get; set; }
        public String Recipient { get; set; }

        public IEnumerator<OldMessage> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
