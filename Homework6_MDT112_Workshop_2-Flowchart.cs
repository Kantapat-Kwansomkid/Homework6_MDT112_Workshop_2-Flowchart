using System;

namespace Homework6_MDT112_Workshop_2-Flowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter to start cooking and eating the spicy bean vermicelli salad.");
            Console.ReadLine();

            Console.WriteLine("Do you brought a bean vermicelli? If you brought that already please enter.");
            Console.ReadLine();

            int time;
            Console.Write("Please input blanching period of bean vermicelli (minute) : ");
            time = int.Parse(Console.ReadLine());

            Console.WriteLine("Now, A bean vermicelli is blanching. Please waiting...");
            Console.WriteLine();
            Console.WriteLine("----------If reaching for {0} minute please enter----------", time);
            Console.ReadLine();

            int bringup;
            Console.Write("Bring a bean vermicelli up from blanching in (minute) : ");
            bringup = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (time <= 3 && bringup <= 3)
            {
                Console.WriteLine("Continue to get blanched bean vermicelli in a bowl.");
            }
            else
            {
                Console.WriteLine("You can't continue to cooking the spicy bean vermicelli salad");
            }
            Console.ReadLine();

            string condiments;
            Console.Write("Please input condiments in a bowl : ");
            condiments = Console.ReadLine();

            string ingredients;
            Console.Write("Please input ingredients in a bowl : ");
            ingredients = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Now...In a bowl have condiments are {0} and ingredients are {1} for cooking the spicy bean vermicelli salad.", condiments, ingredients);
            Console.ReadLine();

            Console.WriteLine("If you want to cook the spicy bean vermicelli salad please enter.");
            Console.ReadLine();

            Console.WriteLine("Now...The spicy bean vermicelli salad is cooking.");
            Console.ReadLine();

            Console.WriteLine("Countdown.... 5");
            Console.ReadLine();

            Console.WriteLine("..............4");
            Console.ReadLine();

            Console.WriteLine("..............3");
            Console.ReadLine();

            Console.WriteLine("..............2");
            Console.ReadLine();

            Console.WriteLine("..............1");
            Console.WriteLine();
            Console.WriteLine("The spicy bean vermicelli salad is cooked already.");
            Console.ReadLine();

            Console.WriteLine("Now, you can eat!!! If you finish to eat the spicy bean vermicelli salad please enter.");
            Console.ReadLine();

            Console.WriteLine("----- Complete to cooking and eating the spicy bean vermicelli salad!!! -----");
            Console.ReadLine();
        }
    }
}
