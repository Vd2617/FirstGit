using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebUsersApp.Data.Models
{
    public class User
    {
        private int id;

        private String email;

        private DateTime dateRegistration;

        private DateTime lastLogining;

        private String login;

        private String password;

        private bool status;

        public User(String login,String password) {
            
            this.password = password;
            
            this.login = login;
            
            this.dateRegistration = new DateTime();

            DateRegistration = DateTime.Now;
            
            this.lastLogining = new DateTime();
            
            LastLogining = DateTime.Now;
            
            Status = false;
            

        }

        public int Id { get => id; set => id = value; }

        public string Email { get => email; set => email = value; }

        public DateTime DateRegistration { get => dateRegistration; set => dateRegistration = value; }

        public string Password { get => password; set => password = value; }

        public bool Status { get => status; set => status = value; }

        public DateTime LastLogining { get => lastLogining; set => lastLogining = value; }
    }
}
