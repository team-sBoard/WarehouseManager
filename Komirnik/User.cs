using System.Collections.Generic;

namespace Komirnik
{
    public class User
    {
        public string login;
        public string password;

        public List<User> users;

        public User(List<User> users)
        {
            this.users = users;
        }

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
