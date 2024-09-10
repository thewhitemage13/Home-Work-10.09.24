using Home_Work_10._09._24.Manager;

namespace Home_Work_10._09._24.Operations
{
    internal class ViewAllUsersProcessor
    {
        private UserManager userManager = new UserManager();

        public void showAllUsers()
        {
            userManager.ViewAllUsers();
        }
    }
}
