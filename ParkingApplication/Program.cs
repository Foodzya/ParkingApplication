using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApplication
{
    class Program
    {

        static void Welcome()
        {
            Console.WriteLine("\t\t\tWelcome to \"Rent Car\" application" + "\n" +
                "\t\t\t________________________\n" +
                "by TMS student Alexander Borisyonok");

            BudgetInput();
        }

        static void BudgetInput()
        {
            double budget;

            Console.WriteLine("Enter your budget in dollars: ");
            do
            {
                while (!double.TryParse(Console.ReadLine(), out budget))
                {
                    Console.WriteLine("Wrong input. Try again..");
                }
            }
            while (budget < 0);

        }

        static void Menu()
        {
            Console.WriteLine("What do you want? \n" +
                "A) Rent a car\n" +
                "B) Return a car" +
                "C) Check for the cars in the parking lot");

            char usersChoice = Console.ReadKey().KeyChar;
            char.ToLower(usersChoice);

            switch (usersChoice)
            {
                case 'a':

                    break;
                case 'b':

                    break;
                case 'c':

                    break;
            }
        }

        static void CarList()
        {
            Car car = new Car("Audi", 2000, 2000);
            Car.AddToList(car);
            Car car1 = new Car("BMW", 2005, 5000);
            Car.AddToList(car1);
            Car car2 = new Car("Volkswagen", 2010, 10000);
            Car.AddToList(car2);


            Console.WriteLine("Do you want to rent a car? y/n");
            if (Console.ReadKey().KeyChar == 'y')
            {
                Console.Clear();
                Car.RentImplementation();
            }
            else
            {

            }

        }


        static void Main(string[] args)
        {
            CarList();


            Console.ReadLine();
        }
    }
}
