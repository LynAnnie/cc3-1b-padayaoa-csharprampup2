namespace Cc3csharprampup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Convert pounds to kilograms
            Console.Write("Enter weight in pounds: ");
            string poundsInput = Console.ReadLine();

            if (double.TryParse(poundsInput, out double pounds))
            {
                double kilograms = PoundsToKilograms(pounds);
                Console.WriteLine($"Weight in Pounds (lbs): {pounds} ");
                Console.WriteLine($"Weight converted to Kilograms (kg): {kilograms}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.WriteLine("=======================================================================");

            // Convert miles to kilometers
            Console.Write("Enter distance in miles: ");
            string milesInput = Console.ReadLine();

            if (double.TryParse(milesInput, out double miles))
            {
                double kilometers = MilesToKilometers(miles);
                Console.WriteLine($"Length in Miles (mi): {miles}");
                Console.WriteLine($"Length in Kilometers (km): {kilometers}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.WriteLine("=======================================================================");
            // Convert Fahrenheit to Celsius
            Console.Write("Enter temperature in Fahrenheit: ");
            string fahrenheitInput = Console.ReadLine();

            if (double.TryParse(fahrenheitInput, out double fahrenheit))
            {
                double celsius = FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"Temperature in Fahrenheit (°F): {fahrenheit} ");
                Console.WriteLine($"Temperature in Celsius (°C): {celsius} ");
            }
            else
            {
                Console.WriteLine("Invalid input. ");
            }
            Console.WriteLine("=======================================================================");
            // Calculate average age of students
            int numberOfStudents = 10;
            int[] ages = new int[numberOfStudents];
            int sumOfAges = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Age of student {i + 1}: ");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out int age))
                {
                    ages[i] = age;
                    sumOfAges += age;
                }
                else
                {
                    Console.WriteLine("Invalid input. ");
                    i--; // Decrement i to repeat the current input for the same student
                }
            }

            double averageAge = (double)sumOfAges / numberOfStudents;

            // Average age of students
            
            Console.WriteLine($"\nThe average age of students is: {averageAge}");
            Console.WriteLine("=======================================================================");
            // Fantasy Story
            string Demon = "~Ibrahim the Destroyer~";
            string name1 = "Annie";
            string name2 = "Lyn";
            string name3 = "Nie";
            string name4 = "Anne";

            string equipment = "<Sword of Damage go brrrrr>";
            string ability = "<Armor pf Pls Dont Hurt Me>";
            string secretskills = "<12 Secret Herbs and Spices>";
            string ultimateskill = "<Unlimited Burger Works>";
            string props = "apakagaling na story";

            string story = $@"
The evil demon king {Demon} has attacked the capital of the Magical Kingdom. 
In order to stop the demon king, the heroes banded together and fight back against the demon king, 
but the demon king is simply to strong. He swings his mighty blade, {equipment} 
to attack the hero's party.When they try to counterattack, 
their attacks are deflected thanks to the {ability} of the demon king.
Using his secret skill the {secretskills}, the demon king is then able to quickly gather the mana 
and items needed to cast his ultimate skills the {ultimateskill}, to defeat the heroes. THE END.";

            Console.WriteLine(story);
            Console.WriteLine("=======================================================================");
            // Print 
            PrintAnnie1();


            PrintAnnie2();


            PrintAnnie3();


            static double PoundsToKilograms(double pounds)
            {
                const double PoundsToKilogramsConversionFactor = 0.453592;
                return pounds * PoundsToKilogramsConversionFactor;
            }

            static double MilesToKilometers(double miles)
            {
                const double MilesToKilometersConversionFactor = 1.60934;
                return miles * MilesToKilometersConversionFactor;
            }

            static double FahrenheitToCelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }



            static void PrintAnnie1()
            {
                Console.Write("Input: ");
                if (int.TryParse(Console.ReadLine(), out int a) && a > 0)
                {

                    for (int i = 1; i <= a; i++)
                    {
                        for (int b = 1; b <= i; b++)
                        {
                            Console.Write($"{b} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                Console.WriteLine();
            }

            static void PrintAnnie2()
            {
                Console.Write("Input: ");
                if (int.TryParse(Console.ReadLine(), out int a) && a > 0)
                {

                    int output = 0;
                    Console.Write("Formula: ");
                    for (int i = 1; i <= a; i++)
                    {
                        Console.Write($"{i}");
                        output += i;

                        if (i < a)
                        {
                            Console.Write(" + ");
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine($"Output: {output}");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                Console.WriteLine();
            }

            static void PrintAnnie3()
            {
                Console.Write("Input: ");
                if (int.TryParse(Console.ReadLine(), out int a) && a > 0)
                {
                    for (int i = a; i >= 1; i--)
                    {
                        for (int b = 1; b <= i; b++)
                        {
                            Console.Write($"{b} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                Console.WriteLine();
            }
        }
    }
}
