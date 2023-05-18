using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
           return num1 + num2;
            
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
            
        }
        public static void Add(int money1, int money2, bool isTrue)
        {
            
            var moneyAnswer = money1 + money2; 

            if (moneyAnswer >= 1 && isTrue)
            {
                Console.WriteLine(moneyAnswer + " dollars");
            }
             else if (moneyAnswer == 1 && isTrue)
         
            {
                Console.WriteLine(moneyAnswer + " dollar");
            }
            else
            {
                Console.WriteLine(moneyAnswer);
            }
        }
        static void Main(string[] args)
        {
           var firstAnswer =  Add(2, 2);
            Console.WriteLine(firstAnswer);
           var secondAnswer = Add(3.3, 3.3);
            Console.WriteLine(secondAnswer);
             Add(11, 13, true);
                
        }
    }
}
