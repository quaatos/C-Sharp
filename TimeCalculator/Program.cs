using System;

namespace journeyTime
{
    class Program
    {
        static void Main(String[] args)
        {
            static void Exchanger()
            {
               Console.WriteLine("How many miles?");
               int miles = Convert.ToInt32(Console.ReadLine());

                //Convert miles to kilometers.
                double MilesValue = 1.609344;
                double milesToKilometers = miles * MilesValue;

                Console.WriteLine(miles + " miles = " + milesToKilometers + " KM");
            }

            static void speedCalculator()
            {
                Console.WriteLine("How many Kilometers is your journey >> ");
                double kilometers = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How fast is your vehicle moving >> ");
                int vehicleSpeed = Convert.ToInt32(Console.ReadLine());

                double speedToKilometers = kilometers / vehicleSpeed;
                Console.WriteLine("your journey lasts " + speedToKilometers + " hours");
            }

            Console.WriteLine("Conver miles to kilometers? [Y / N]");
            string answer = Console.ReadLine();

            if (answer == "Y" || answer == "y") {
                Exchanger();

            } else if (answer == "N" || answer == "n") {
                Console.WriteLine("Calculate your traveltime? [Y / N]");
                string JourneyTime = Console.ReadLine();

                if (JourneyTime == "Y" || JourneyTime == "y") {
                    speedCalculator();

                } else if (JourneyTime == "N" || JourneyTime == "n") {
                    return;
                }

            } else {
                Console.WriteLine("No vallid input registerd");
                return;
            }
		//developed by Quaatos with <3
        }
    }
}