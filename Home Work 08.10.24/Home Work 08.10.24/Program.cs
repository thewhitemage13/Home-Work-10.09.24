namespace WordsInWarAndPeace
{
    class TextAnalizator
    {

        public void Top()
        {
            FileStream file = new FileStream(@"C:\Users\lolim\Desktop\kobzar.txt", FileMode.Open);

            StreamReader stream = new StreamReader(file);
            string text = stream.ReadToEnd();
            text = text.Replace(',', ' ');
            text = text.Replace('\n', ' ');
            string[] words = text.Split(' ');

            //select chars that we want to trim
            char[] charsToTrim = { ',', '.', '!', '-', '?', '\n', ':', ';' };

            for (int i = 0; i < words.Length; ++i)
            {
                words[i] = words[i].TrimEnd(charsToTrim).ToLower();

            }

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var s in words)
            {
                if (!dict.Keys.Contains(s))
                {
                    if (s.Length > 5)
                    {
                        dict.Add(s, 1);
                    }
                }
                else
                {
                    dict[s] += 1;
                }

            }

            dict = dict.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            int count = 0;

            Console.WriteLine("+----+----------+------------+");
            Console.WriteLine("| {0, -5} | {1, -10} | {2, -5} |", "N", "Words", "Count");
            Console.WriteLine("+----+----------+------------+");

            
            foreach (var pair in dict)
            {
                count++;
                Console.WriteLine("| {0, -5} | {1, -10} | {2, -5} |", count, pair.Key, pair.Value);
                if (count == 50) break;

            }
            Console.WriteLine("+----+----------+-----------+");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TextAnalizator textAnalizator = new TextAnalizator();
            textAnalizator.Top();
        }
    }
}
