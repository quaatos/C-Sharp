using System;

namespace age
{
    public class Program
    {
       static void Main(String[] args)
        {
            Console.WriteLine("We're gonna calculate your life time hours/seconds/nanoseconds etc etc");
            Console.WriteLine("Choose a number\n[1.] hours\n[2.] seconds\n[3.] minutes");
            
            static void hours()
            {
                Console.WriteLine("How old >>> ");
                int howOld = Convert.ToInt32(Console.ReadLine());
                double hoursInYear = 8.760;
                double conclusion = howOld * hoursInYear;
                Console.WriteLine("you are " + conclusion + "0 hours old");
            }

            static void minutes()
            {
                long minutesInYear = 525600;
                Console.WriteLine("How old >>> ");
                int howOld = Convert.ToInt32(Console.ReadLine());
                double conclusion = howOld * minutesInYear;
                Console.WriteLine("you are " + conclusion + " minutes old");
            }

            static void seconds()
            {
                Console.WriteLine("How old >>> ");
                int howOld = Convert.ToInt32(Console.ReadLine());
                long seconds = 31536000;
                double conclusion = howOld * seconds;
                Console.WriteLine("Your life lasts " + conclusion + " seconds");
            }

            //ask the user for the case
            int EnterNumber = Convert.ToInt32(Console.ReadLine());

            switch (EnterNumber)
            {
                case 1:
                    hours();
                    break;

                case 2:
                    minutes();
                    break;

                case 3:
                    seconds();
                    break;                   
            }
        }
    }
}
