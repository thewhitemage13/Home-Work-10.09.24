namespace Home_Work_19._09._2024
{
    internal class Program
    {
        static void NewGame()
        {
            Console.WriteLine("The new game has begun!");
        }
        static void LoadGame()
        {
            Console.WriteLine("The game is loading");
        }
        static void Rules()
        {
            Console.WriteLine("Here are the rules of the game");
        }
        static void AboutAuthor()
        {
            Console.WriteLine("Program Author: LOLO MUKHAMMED");
        }
        static void Exit()
        {
            Console.WriteLine("Exiting the program");
        }

        delegate void Menu();

        static void Main(string[] args)
        {
            Menu[] menus = [NewGame, LoadGame, Rules, AboutAuthor, Exit];

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1 - New game");
                Console.WriteLine("2 - Download the game");
                Console.WriteLine("3 - Rules");
                Console.WriteLine("4 - About the author");
                Console.WriteLine("0 - Exit");
                Console.Write("Select a menu item (enter a number): ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 0 && choice <= 4)
                    {
                        menus[choice]();
                        if (choice == 0) exit = true;
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите корректное число.");
                }
            }
        }
    }
}
