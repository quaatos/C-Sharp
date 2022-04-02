using System;

namespace quaatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operator\n [1. addition]\n [2. substraction]\n [3. multiplication]\n [4. divide]");
            string action = Console.ReadLine();
            
            Console.WriteLine("Enter first number >>> ");
            int firtNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number >>> ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (action == "1")
            {
               int addAnwer = firtNumber + secondNumber;
               Console.WriteLine (firtNumber + " + " + secondNumber + " = " + addAnwer); 

            } else if (action == "2")
            {
                int subAnswer = firtNumber - secondNumber;
                Console.WriteLine (firtNumber + " - " + secondNumber + " = " + subAnswer);

            } else if (action == "3")
            {
                int multiAnswer = firtNumber * secondNumber;
                Console.WriteLine(firtNumber + " x " + secondNumber + " = " + multiAnswer);

            } else if (action == "4")
            {
                int divAnswer = firtNumber / secondNumber;
                Console.WriteLine(firtNumber + " : " + secondNumber + " = " + divAnswer);
            } else {
                Console.WriteLine("No vallid input registerd");
                return;
            }
            //developed by Quaatos with <3
        }
    }   
}
