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

        public static bool operator == (User u1, User u2)
        {
            if (u1.GetID() == u2.GetID())
            {
                if (u1.GetLogin() == u2.GetLogin())
                {
                    if (u1.GetPassword() == u2.GetPassword())
                    {
                        if (u1.GetRole() == u2.GetRole())
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static bool operator != (User u1, User u2)
        {
            return !(u1 == u2);
        }
    }
}
