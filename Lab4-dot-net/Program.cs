 using Lab4_dot_net.BeverageFactoryInterface;
using Lab4_dot_net.BeverageInterface;
using Lab4_dot_net.Factories;
using System.Drawing;

namespace Lab4_dot_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("What beverage do you want?");
                Console.WriteLine("1. Tea");
                Console.WriteLine("2. Latte");
                Console.WriteLine("3. Espresso");

                string choice = Console.ReadLine();
                IBeverageFactory factory;

                if (choice == "1")
                {
                    factory = new TeaFactory();
                }
                else if (choice == "2")
                {
                    factory = new LatteFactory();
                }
                else if (choice == "3")
                {
                    factory = new EspressoFactory();
                }
                else
                {
                    Console.WriteLine("Невірний вибір.");
                    return;
                }

                Console.Clear();

                Console.WriteLine("What size of cup do you want?" +
                    "\n1.Small" +
                    "\n2.Medium" +
                    "\n3.Large");

                string size;
                string sizeChoice = Console.ReadLine();
                switch (sizeChoice)
                {
                    case "1":
                        size = "Small";
                        break;
                    case "2":
                        size = "Medium";
                        break;
                    case "3":
                        size = "Large";
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        return;
                }

                Console.Clear();

                Barista barista = new Barista(factory);
                barista.PrepareBeverage(size);
                Console.WriteLine("Do you want to repeat the order? +/-");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer == "+");
        }
    }
}
