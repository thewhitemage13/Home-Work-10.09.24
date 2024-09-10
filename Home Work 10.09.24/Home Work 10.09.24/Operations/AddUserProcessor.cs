using Home_Work_10._09._24.Manager;
using Home_Work_10._09._24.Menu;

namespace Home_Work_10._09._24.Operations
{
    internal class AddUserProcessor
    {
        private UserManager userManager = new UserManager();

        public void addUser()
        {
            Console.Write("Enter the login name of the new user: ");
            string login = Console.ReadLine();
            Console.Write("Enter the password for the new user: ");
            char[] password = Validate.ValidatePassword.ReadPassword();
            try
            {
                userManager.AddUser(login, password);
                Console.WriteLine("User Added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
