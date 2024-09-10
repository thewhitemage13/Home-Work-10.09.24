using Home_Work_10._09._24.Manager;

namespace Home_Work_10._09._24.Operations
{
    internal class DeleteUserProcessor
    {
        private UserManager userManager = new UserManager();

        public void deleteUser()
        {
            Console.Write("Enter the login name of the user you want to delete: ");
            string login = Console.ReadLine();
            if (userManager.RemoveUser(login))
                Console.WriteLine("User Deleted.");
            else
                Console.WriteLine("User not found.");
        }
    }
}
