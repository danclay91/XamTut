using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamTut.Models;

namespace XamTut.Services
{
    public class MockDataStore : IDataStore
    {
        List<Message> messages;

        public MockDataStore()
        {
            messages = new List<Message>();

            //Add Mock Messages
            messages.Add(new Message() { Sender="Danny", Recipient="Andrew", Content="Blue messages"});
            messages.Add(new Message() { Sender = "Danny", Recipient = "Andrew", Content = "from me" });
            messages.Add(new Message() { Sender = "Andrew", Recipient = "Danny", Content = "Red messages from me" });
            messages.Add(new Message() { Sender = "Nobody", Recipient = "Danny", Content = "Poo" });
            messages.Add(new Message() { Sender = "Nobody", Recipient = "Peabody", Content = "Pooooop" });


        }

        public async Task<List<Message>> GetMessagesAsync(string username)
        {
            List<Message> messagesToReturn = new List<Message>();

            foreach(Message message in messages)
            {
                if(message.Sender == username || message.Recipient == username)
                {
                    messagesToReturn.Add(message);
                }
            }
            return await Task.FromResult(messagesToReturn);
        }

        public async Task<bool> AddMessageAsync(Message message){
            messages.Add(message);
            return await Task.FromResult(true);
        }


    }
}
