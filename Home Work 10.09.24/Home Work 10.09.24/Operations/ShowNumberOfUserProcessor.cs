using Home_Work_10._09._24.Manager;

namespace Home_Work_10._09._24.Operations
{
    internal class ShowNumberOfUserProcessor
    {
        private UserManager userManager = new UserManager();

        public void showCount()
        {
            Console.WriteLine($"Number of users: {userManager.Count}");
        }
    }
}
