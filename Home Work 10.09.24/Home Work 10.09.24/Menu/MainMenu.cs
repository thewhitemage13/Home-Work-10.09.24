using Home_Work_10._09._24.Manager;
using Home_Work_10._09._24.Operations;

namespace Home_Work_10._09._24.Menu
{
    class MainMenu
    {
        private bool exit = true;
        private AddUserProcessor addUserProcessor = new AddUserProcessor();
        private ViewAllUsersProcessor viewAllUsersProcessor = new ViewAllUsersProcessor();
        private DeleteUserProcessor deleteUserProcessor = new DeleteUserProcessor();
        private ChangePasswordProcessor changePasswordProcessor = new ChangePasswordProcessor();
        private ShowUserLoginByIndex ShowUserLoginByIndex = new ShowUserLoginByIndex();
        private ShowNumberOfUserProcessor showNumberOfUserProcessor = new ShowNumberOfUserProcessor();

        public void menu()
        {
            Console.Write("Main Menu: ");
            while (exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. View all users");
                Console.WriteLine("2. Add a new user");
                Console.WriteLine("3. Delete user");
                Console.WriteLine("4. Change user password");
                Console.WriteLine("5. Show number of users");
                Console.WriteLine("6. Show user login by index");
                Console.WriteLine("7. Exit");

                Console.Write("Select an action: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        viewAllUsersProcessor.showAllUsers();
                        break;
                    case 2:
                        addUserProcessor.addUser();
                        break;
                    case 3:
                        deleteUserProcessor.deleteUser();
                        break;
                    case 4:
                        changePasswordProcessor.changePassword();
                        break;
                    case 5:
                        showNumberOfUserProcessor.showCount();
                        break;
                    case 6:
                        ShowUserLoginByIndex.ShowUserLogin();
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect choice.");
                        break;
                }
            }
        }
    }
}
