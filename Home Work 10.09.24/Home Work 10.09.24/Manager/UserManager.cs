using Home_Work_10._09._24.Entity;


namespace Home_Work_10._09._24.Manager
{
    class UserManager
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        public int Count
        {
            get
            {
                return users.Count;
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < users.Count)
                {
                    var userAtIndex = new List<string>(users.Keys)[index];
                    return userAtIndex;
                }
                throw new IndexOutOfRangeException("No user with this index was found.");
            }
        }

        public string AddUser(string login, char[] password)
        {
            if (users.ContainsKey(login))
            {
                throw new ArgumentException("User with Login = " + login + "already exist!");
            }

            users.Add(login, new User(login, password));
            return "User added";
        }

        public bool RemoveUser(string user)
        {
            return users.Remove(user);
        }

        public void ViewAllUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("There are no registered users.");
            }
            else
            {
                Console.WriteLine("Registered Users:");
                int index = 1;
                foreach (var login in users.Keys)
                {
                    Console.WriteLine($"{index}. {login}");
                    index++;
                }
            }
        }

        public bool EditUser(string login, char[] newPassword)
        {
            if (users.TryGetValue(login, out User user))
            {
                user.SetPassword(newPassword);
                return true;
            }
            return false;
        }
    }
}
