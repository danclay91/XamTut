using System;
namespace XamTut
{
    public class Message
    {
        String recipient, messageBody;

        public Message(String recipient, String messageBody)
        {
            this.recipient = recipient;
            this.messageBody = messageBody;
        }

        public String getMessageBody(){
            return messageBody;
        }
        public String getRecipient(){
            return recipient;
        }
    }
}
