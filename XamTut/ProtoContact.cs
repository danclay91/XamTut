/*
 *  This will hopefully be a customized menuItem bound to a listview in the messages page. 
 * 
 */



using System;
using Xamarin.Forms;

namespace XamTut
{
    public class ProtoContact : MenuItem
    {
        
        public ConversationPage conversation;
        public ProtoContact(ConversationPage conversation)
        {
            this.conversation = conversation;
        }
        public String Name { get; set;}
        public String Number { get; set; }
        public override String ToString()
        {
            return Name;
        }



    }
}
