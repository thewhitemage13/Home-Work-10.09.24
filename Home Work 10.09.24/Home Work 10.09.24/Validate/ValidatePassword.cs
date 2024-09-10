namespace Home_Work_10._09._24.Validate
{
    internal class ValidatePassword
    {
        public static char[] ReadPassword()
        {
            List<char> passwordChars = new List<char>();
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                {
                    passwordChars.Add(key.KeyChar);
                    Console.Write('*');
                }
                else if (key.Key == ConsoleKey.Backspace && passwordChars.Count > 0)
                {
                    passwordChars.RemoveAt(passwordChars.Count - 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return passwordChars.ToArray();
        }
    }
}
