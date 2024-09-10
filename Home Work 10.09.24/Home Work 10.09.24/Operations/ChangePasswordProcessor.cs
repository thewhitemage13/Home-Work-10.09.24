using Home_Work_10._09._24.Manager;
using Home_Work_10._09._24.Validate;

namespace Home_Work_10._09._24.Operations
{
    internal class ChangePasswordProcessor
    {
        private UserManager userManager = new UserManager();

        public void changePassword()
        {
            Console.Write("Enter the login name of the user for whom you want to change the password:  ");
            string login = Console.ReadLine();
            Console.Write("Enter a new password: ");
            char[] password = ValidatePassword.ReadPassword();
            if (userManager.EditUser(login, password))
                Console.WriteLine("Password's been changed.");
            else
                Console.WriteLine("User not found.");
        }
    }
}
