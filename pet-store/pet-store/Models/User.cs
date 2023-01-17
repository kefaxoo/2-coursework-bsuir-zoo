using System;
using System.Collections.Generic;
using System.Text;

namespace pet_store
{
    public class User
    {
        private readonly int id;
        private string login;
        private string password;
        private string role;

        public User(int id, string login, string password, string role)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.role = role;
        }

        public int GetID() => id;

        public string GetLogin() => login;

        public string GetPassword() => password;

        public string GetRole() => role;

        public void SetLogin(string login) => this.login = login;

        public void SetPassword(string password) => this.password = password;

        public void SetRole(string role) => this.role = role;
    }
}
