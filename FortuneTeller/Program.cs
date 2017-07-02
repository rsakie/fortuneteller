using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome header 
            Console.WriteLine("Welcome to the Wonderful, Amazing, Extrordinary Bobo The Fortune Teller!! \n");
            Console.WriteLine("I am going to predict your future. \n");
            //have user enter info as promted f/l name,birth month
            //age as digit(int)
            //enter fav roygbiv, if dont know ask for help
            //
            Console.WriteLine("Please enter your First Name :");
            string fName = Console.ReadLine();

            Console.WriteLine("Please enter your Last Name :");
            string lName = Console.ReadLine();

            Console.WriteLine("Please enter your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Wow, You look good for your age!! \n");
            Console.WriteLine("Please enter your Birth Month as a Digit");
            int birthM = int.Parse(Console.ReadLine());
            //could not get code to error out or restart if birthM <1 or birthM>12

            Console.WriteLine("Please enter your Favorite ROYGBIV Color:  if you do not know what ROYGBIV is   enter \"Help\" ");
            string color = Console.ReadLine();
            if (color.ToLower() == "help")
            {
                Console.WriteLine("The Colors are Red, Orange, Yellow, Green, Blue, Indigo, Violet\n");
                Console.WriteLine("Please enter your Favorite ROYGBIV Color");
                color = Console.ReadLine();
            }
            Console.WriteLine("How many Siblings do you have?");

            int sibs = int.Parse(Console.ReadLine());

            //// attemted stretch goal
            ////if user want to quit, type quit
            //Console.WriteLine("If you would like to Quit at any time, Just type Quit.");
            //String quit = Console.ReadLine();
            // if age is odd retire x years
            // if age is even retire x years
            {
                Console.Write(fName + " " + lName);
            }
            if (age % 2 == 0)
            {
                Console.Write(" you will Retire in 35 years,\n");
            }
            else
            {
                Console.Write(" you will Retire in 40 years,\n");
            }
            if (birthM >= 1 && birthM <= 4)
            {
                Console.Write("You will be Blessed with a fortune of $42,000 in the bank upon retirement,\n");
            }
            else if (birthM >= 5 && birthM <= 8)
            {
                Console.Write("You will be blessed with a fortune of $90,000.90 in the bank upon retirement,\n");
            }
            else if (birthM >= 9 && birthM <= 12)
            {
                Console.Write("You will be blessed with $35,000.55 in the bank upon retirement,\n");
            }
            else if (birthM > 12 && birthM < 1)
            {
                Console.Write("You will be Poor with not even a penny in the bank,\n");
            }
            //how many sibs 0-you will have a  vac home in (loc), 2 vac home loc, 3 ..., 3 or more...
            if (sibs == 0)
            {
                Console.Write("You will have a Vacation Home in Argentina,\n");
            }
            else if (sibs == 1)
            {
                Console.Write("You will have a Vacation Home in Paris,\n");
            }
            else if (sibs == 2)
            {
                Console.Write("You will have a Vacation Home in Hawaii,\n");
            }
            else if (sibs == 3)
            {
                Console.Write("You will have a Vacation Home in Florida,\n");
            }
            else if (sibs > 3)
            {
                Console.Write("You will have a Vacation Home in Colorado,\n");
            }
            else if (sibs >= 0)
            {
                Console.Write("You will have a Vacation Home in Rural Pennslyvania,\n");
            }
            //still need to figue out how to streamline my code to less lines
            //need to work on switch statements
            if (color == "red")
            {
                Console.Write("with a Pickup Truck as transportation. \n");
            }
            else if (color == "orange")
            {
                Console.Write("with a Vespa Scooter as Transportation. \n");
            }
            else if (color == "yellow")
            {
                Console.Write("with a Bmx Bicycle as Transportation. \n");
            }
            else if (color == "green")
            {
                Console.Write("with a Station Wagon as Transportation. \n");
            }
            else if (color == "blue")
            {
                Console.Write("with a Sportscar as Transportation. \n");
            }
            else if (color == "indigo")
            {
                Console.Write("and have a Unicorn as Transportation. \n");
            }
            else if (color == "violet")
            {
                Console.Write("You will have a Vehicle of your choice as Transportation. \n");
            }
            //end statement
            Console.WriteLine(" \n Thank you for letting me predict your future!!");


        }
    }
}


    
