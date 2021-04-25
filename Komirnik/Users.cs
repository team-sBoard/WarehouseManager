using System.Collections.Generic;

namespace Komirnik
{
    public class User
    {
        public List<User> users;

        public User(List<User> users)
        {
            this.users = users;
        }
    }
}
