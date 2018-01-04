using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamTut.Models;

namespace XamTut.Services
{
    public interface IDataStore
    {
        Task<List<Message>> GetMessagesAsync(string username);
    }
}
