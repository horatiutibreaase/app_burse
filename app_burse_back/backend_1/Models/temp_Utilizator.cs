using System;

namespace backend_1
{
    public class temp_Utilizator
    {
        public temp_Utilizator(string username,string password) { 
            this.username = username;
            this.password = password;
        }
        public string? username { get; set; }

        public string? password { get; set; }

    }

}
