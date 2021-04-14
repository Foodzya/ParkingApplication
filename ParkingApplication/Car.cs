using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApplication
{
    public class Car : IMovable
    {
        static List<Car> cars = new List<Car>();

        public string DriveUnit()
        {
            //switch (driveUnit)
            //{
            //    case "1":
            //        Console.WriteLine("You drive a front-wheel drive car!");
            //        break;
            //    case "2":
            //        Console.WriteLine("You drive a rear wheel drive car");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown input");
            //        break;
            //}
            return null;
        }

        public double Speed()
        {
            return 0;
        }

        public static void AddToList(Car car)
        {
            cars.Add(car);
        }

        public string Transmission()
        {
            return null;
        }

        private string Brand { get; set; }
        private uint ProdYear { get; set; }
        private double Price { get; set; }


        public Car(string brand, uint prodYear, double price)
        {
            Brand = brand; ProdYear = prodYear; Price = price;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Brand - {Brand}\nYear of issue - {ProdYear}\nPrice - ${Price}");
        }

        public static void RentImplementation()
        {
            int index = 1;
            foreach (Car car in cars)
            {
                Console.Write($"{index}) ");
                car.GetInfo();
                index++;
            }

            Console.WriteLine("Choose car you want to rent: ");
            char rentChoice = Console.ReadKey().KeyChar;

            if (char.IsDigit(rentChoice))
            {
                int intRentChoice = (int)Char.GetNumericValue(rentChoice); 
                try
                {
                    Console.WriteLine($"You have rented {cars.ElementAt(intRentChoice - 1).Brand}");
                    cars.RemoveAt(intRentChoice - 1);

                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Task.WaitAll()
        }
    }
}
