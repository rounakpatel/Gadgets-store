using System;

namespace Gadgets
{
    class Program
    {
        static void Main(string[] args)
        {
            Headphones headphones = new Headphones("Sony", 100, 2020, "Audio", true, false, true);
            Mobiles mobiles = new Mobiles("Apple", 1000, 2021, "Electronics", true, 5.5, false);
            Laptops laptops = new Laptops("HP", 500, 2021, "Electronics", "i7", 1024, 14.5);

            Console.WriteLine("Different Gadgets:\n1. HeadPhones\n2. Mobiles\n3. Laptops");
            while (true)
            {
                try
                {
                    Console.Write("\\n\nFor which gadget youw ant to see dateils (Enter 0 for exit): ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if(n==0)
                    {
                        break;
                    }
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Details are:");
                            Console.WriteLine(headphones.ToString());
                            break;
                        case 2:
                            Console.WriteLine("Details are:");
                            Console.WriteLine(mobiles.ToString());
                            break;
                        case 3:
                            Console.WriteLine("Details are:");
                            Console.WriteLine(laptops.ToString());
                            break;
                        default:
                            Console.WriteLine("Enter a valid option");
                            break;
                    }

                }
                catch
                {
                    Console.WriteLine("Only integer number is allowed!");
                }
            }

        }
    }
}
