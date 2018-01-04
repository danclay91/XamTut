using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XamTut.Models;

namespace XamTut
{
    /// <summary>
    /// Handles communication with backend server.
    /// </summary>
    public class ConnectionManager
    {
        private const string BASE_PATH = "http://localhost:3000/";
        private const string MESSAGE_ROUTE = "messages/";
        private static HttpClient client = new HttpClient();


        /// <summary>
        /// Used to retrieve messages from database whose username match provided value.
        /// </summary>
        /// <returns>List of Messages</returns>
        /// <param name="username">username to search</param>
        public static async Task<IList<Message>> GetMessagesAsync(string username){
            Uri path = new Uri(BASE_PATH+MESSAGE_ROUTE+username); 
            IList<Message> messages = new List<Message>();

           
            string response = await client.GetStringAsync(path);

            JArray userMessagesJSON = JArray.Parse(response);
            foreach(JObject obj in userMessagesJSON){
                Message message = new Message()
                {
                    Sender = (string)obj.Property("Sender"),
                    Recipient = (string)obj.Property("Recipient"),
                    Content = (string)obj.Property("Content")
                };
                messages.Add(message);
            }
            return messages; 
        }

    }
}
