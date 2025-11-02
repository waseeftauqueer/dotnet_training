using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Data Types Demonstration
            int integerValue = 10;
            float floatValue = 1.0f;
            double doubleValue = 1.00;
            decimal decimalValue = 341312m;
            char grade = 'A';
            string message = "This is Sparta";
            string employeeName = "Walter White";
            int employeeAge = 52;

            Console.WriteLine("=== Data Types Demo ===");
            Console.WriteLine($"Integer   : {integerValue}");
            Console.WriteLine($"Float     : {floatValue}");
            Console.WriteLine($"Double    : {doubleValue}");
            Console.WriteLine($"Decimal   : {decimalValue}");
            Console.WriteLine($"Character : {grade}");
            Console.WriteLine($"String    : {message}");
            Console.WriteLine($"The integer value is {integerValue}, and the float value is {floatValue}");
            Console.WriteLine($"Name : {employeeName}\nAge  : {employeeAge}");

            // 2. User Input
            Console.WriteLine("\n=== User Input ===");
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name  : ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email      : ");
            string email = Console.ReadLine();

            Console.Write("Enter Age        : ");
            int age = Convert.ToInt32(Console.ReadLine());

            // 3. Display User Details
            Console.WriteLine("\n--- User Details ---");
            Console.WriteLine($"First Name : {firstName}");
            Console.WriteLine($"Last Name  : {lastName}");
            Console.WriteLine($"Email      : {email}");
            Console.WriteLine($"Age        : {age}");

            // 4. Type Conversion
            Console.WriteLine("\n=== Type Conversion ===");
            int number = 100;
            double convertedDouble = number;        // Implicit conversion (int → double)
            int convertedInt = (int)convertedDouble; // Explicit conversion (double → int)
            Console.WriteLine($"Implicit Conversion  : int ({number}) → double ({convertedDouble})");
            Console.WriteLine($"Explicit Conversion  : double ({convertedDouble}) → int ({convertedInt})");

            // 5. Boxing and Unboxing
            Console.WriteLine("\n=== Boxing and Unboxing ===");
            object boxedValue = number;        // Boxing
            int unboxedValue = (int)boxedValue; // Unboxing
            Console.WriteLine($"Boxed Value   (object): {boxedValue}");
            Console.WriteLine($"Unboxed Value (int)   : {unboxedValue}");

            // 6. Value Types
            int a = 1;
            int b = a;
            b = 100;
            Console.WriteLine($"{a} {b}");

            // 7. Reference Types
            string[] cars = { "Pagani", "Maclaren", "Mercedes" };
            string[] carsCopy = cars;
            Console.WriteLine($"{cars[0]}, {cars[1]}, {cars[2]}");
            carsCopy[0] = "Ferrari";
            Console.WriteLine($"{cars[0]}, {cars[1]}, {cars[2]}");

            // 8. Control Statements
            int voterAge = 18;
            if (voterAge > 18)
            {
                Console.WriteLine("Eligible to Vote");
            }
            else
            {
                Console.WriteLine("Not Eligible to Vote");
            }

            int num1 = 10, num2 = 13, num3 = 9;
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is the greatest number");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("num2 is the greatest number");
            }
            else
            {
                Console.WriteLine("num3 is the greatest number");
            }

            Console.WriteLine("\nEnter your choice (1-3):");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Sum of num1 and num2: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Sum of num2 and num3: {num2 + num3}");
                    break;
                case 3:
                    Console.WriteLine($"Sum of num1 and num3: {num1 + num3}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            // 9. Loops
            int[] numberArray = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }

            foreach (int i in numberArray)
            {
                Console.WindowHeight = i;
            }

            // 10. Bonus Calculator
            double salary;
            int years;
            Console.WriteLine("Enter your salary : ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your years of Experience : ");
            years = Convert.ToInt32(Console.ReadLine());

            BonusCalculator bonusCalc = new BonusCalculator();
            bonusCalc.bonusCalculator(years, salary);

            // 11. Grade Analyzer
            int marks;
            Console.WriteLine("Enter your marks: ");
            marks = Convert.ToInt32(Console.ReadLine());

            ResultAnalyzer resultAn = new ResultAnalyzer();
            resultAn.resultAnalyzer(marks);

            // 12. Shopping Discount
            int amount;
            Console.WriteLine("Enter your amount : ");
            amount = Convert.ToInt32(Console.ReadLine());

            ShoppingDiscount shoppingDis = new ShoppingDiscount();
            shoppingDis.shoppingDiscount(amount);

            // 13. Password Strength Checker
            string password;
            Console.WriteLine("Enter your password : ");
            password = Console.ReadLine();

            PasswordStrength passwordStr = new PasswordStrength();
            passwordStr.passwordStrength(password);

            // 14. Restaurant Bill Splitter
            int billAmount, totalPeople;
            Console.WriteLine("Enter your Bill Amount : ");
            billAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter total people : ");
            totalPeople = Convert.ToInt32(Console.ReadLine());

            BillSplitter billspl = new BillSplitter();
            billspl.billSplitter(billAmount, totalPeople);

            // 15. Movie Ticket Price
            int pAge, time;
            Console.WriteLine("Enter your Age : ");
            pAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the time in 24hr format : ");
            time = Convert.ToInt32(Console.ReadLine());

            MovieTicket movTicket = new MovieTicket();
            movTicket.ticketPrice(pAge, time);
        }
    }
}
