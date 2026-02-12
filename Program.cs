namespace FizzBuzzCsharp
{
    public class Rule
    {
        public int Divisor { get; set; }
        public string Output { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var rules = new List<Rule>
            {
                new Rule { Divisor = 3, Output = "Fizz" },
                new Rule { Divisor = 5, Output = "Buzz" },
                new Rule { Divisor = 7, Output = "Foo" },
                new Rule { Divisor = 11, Output = "Bar" }
            };

            RunFizzBuzz(1, 100, rules);
        }

        static void RunFizzBuzz(int start, int end, List<Rule> rules)
        {
            for (int i = start; i <= end; i++)
            {
                var output = new System.Text.StringBuilder();
                foreach (var rule in rules)
                {
                    if (i % rule.Divisor == 0)
                    {
                        output.Append(rule.Output);
                    }
                }

                if (output.Length == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(output.ToString());
                }
            }
        }
    }
}
