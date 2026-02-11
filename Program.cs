namespace FizzBuzzCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rules = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };

            RunFizzBuzz(1, 100, rules);
        }

        static void RunFizzBuzz(int start, int end, Dictionary<int, string> rules)
        {
            for (int i = start; i <= end; i++)
            {
                string output = "";
                foreach (var rule in rules)
                {
                    if (i % rule.Key == 0)
                    {
                        output += rule.Value;
                    }
                }

                if (string.IsNullOrEmpty(output))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(output);
                }
            }
        }
    }
}
