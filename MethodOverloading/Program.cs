namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isCurrency)
        {
            var sum = a + b;

            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return $"{sum}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 3));
            
            Console.WriteLine(Add(2.5m, 2.5m));
            
            Console.WriteLine(Add(2, 2, true));
        }
    }
}
