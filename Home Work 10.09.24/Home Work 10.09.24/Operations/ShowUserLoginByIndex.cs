using Home_Work_10._09._24.Manager;

namespace Home_Work_10._09._24.Operations
{
    internal class ShowUserLoginByIndex
    {
        private UserManager userManager = new UserManager();

        public void ShowUserLogin()
        {
            Console.Write("Enter the user's index: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                try
                {
                    Console.WriteLine($"User Login: {userManager[index]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Incorrect index.");
            }
        }
    }
}
