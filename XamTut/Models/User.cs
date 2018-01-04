using System;
using System.Collections.Generic;

namespace XamTut.Models
{
    public class User
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public IList<string> Contacts { get; set; }
    }
}
