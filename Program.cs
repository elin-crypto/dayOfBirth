using System;
using static System.Console;

namespace moment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken veckodag du är född?");
            Console.WriteLine("Skriv ditt födelsedatum i formatet YYYY-MM-DD och tryck på enter!");
            string inputDate = ReadLine();
            
            DateTime dateValue;

            // Check if inputValue is in a correct DateTime form
            if (DateTime.TryParse(inputDate, out dateValue))
            {
                int year = dateValue.Year; // YYYY
                int centuary = year / 100; // ex 19 from 1983
                int yearYY = year%100; // ex 83 from 1983
                int month = dateValue.Month; // MM
                int day = dateValue.Day; // DD
                
                if(month < 3)
                {
                    month = month + 12; 
                    yearYY = yearYY - 1; 
                }

                // gives the weekday as a number 0-6 starting saturday
                int weekday = (day + ((13*(month+1))/5) + yearYY + (yearYY/4) + (centuary/4) + 5*centuary ) % 7;

                // Translate weekday 0-6 to string saturday - friday
                switch(weekday)
                {
                    case 0:
                        System.Console.WriteLine("Du är född på en lördag");
                    break;
                    case 1:
                        System.Console.WriteLine("Du är född på en söndag");
                    break;
                    case 2:
                        System.Console.WriteLine("Du är född på en måndag");
                    break;
                    case 3:
                        System.Console.WriteLine("Du är född på en tisdag");
                    break;
                    case 4:
                        System.Console.WriteLine("Du är född på en onsdag");
                    break;
                    case 5:
                        System.Console.WriteLine("Du är född på en torsdag");
                    break;
                    case 6:
                        System.Console.WriteLine("Du är född på en fredag");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Du måste ange datumet i formatet: YYYY-MM-DD, försök igen!");    
            }
        }
    }
}
