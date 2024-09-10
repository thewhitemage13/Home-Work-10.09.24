namespace Home_Work_10._09._24.Entity
{
    class User
    {
        private string login;
        //если не ошибаюсь, то пароль безопаснее задвать используя char,
        //потому что string более уязвим для взлома-перехвата пароля
        private char[] password;

        public User() { }

        public User(string login, char[] password)
        {
            this.login = login;
            this.password = password;
        }

        public char[] GetPassword()
        {
            return password;
        }

        public void SetLogin(string login)
        {
            this.login = login;
        }
        public string GetLogin()
        {
            return login;
        }

        public override string ToString()
        {
            return "Login: " + this.login + " Password: " + this.password;
        }

        private static char[] EncryptPassword(char[] password)
        {
            char xorKey = 'K';
            char[] encryptedPassword = new char[password.Length];
            for (int i = 0; i < password.Length; i++)
            {
                encryptedPassword[i] = (char)(password[i] ^ xorKey);
            }
            return encryptedPassword;
        }

        public char[] DecryptPassword()
        {
            return EncryptPassword(password);
        }

        public void SetPassword(char[] newPassword)
        {
            password = EncryptPassword(newPassword);
        }
    }
}
