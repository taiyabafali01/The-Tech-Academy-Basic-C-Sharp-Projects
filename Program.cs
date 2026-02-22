using System; // Allows use of Console and basic system functions

class Program
{
    static void Main()
    {
        // 1️⃣ Multiply input by 50

        Console.WriteLine("Please enter a number to multiply by 50:");
        
        // Using long to allow very large numbers (greater than 10,000,000)
        long number1 = Convert.ToInt64(Console.ReadLine());

        long multiplyResult = number1 * 50;

        Console.WriteLine("Result after multiplying by 50: " + multiplyResult);



        // 2️⃣ Add 25 to input

        Console.WriteLine("Please enter a number to add 25 to:");

        long number2 = Convert.ToInt64(Console.ReadLine());

        long addResult = number2 + 25;

        Console.WriteLine("Result after adding 25: " + addResult);



        // 3️⃣ Divide input by 12.5

        Console.WriteLine("Please enter a number to divide by 12.5:");

        // Using decimal because 12.5 is a decimal value
        decimal number3 = Convert.ToDecimal(Console.ReadLine());

        decimal divideResult = number3 / 12.5m;

        Console.WriteLine("Result after dividing by 12.5: " + divideResult);



        // 4️⃣ Check if input is greater than 50

        Console.WriteLine("Please enter a number to check if it is greater than 50:");

        long number4 = Convert.ToInt64(Console.ReadLine());

        bool isGreater = number4 > 50;

        Console.WriteLine("Is the number greater than 50? " + isGreater);



        // 5️⃣ Divide input by 7 and print remainder

        Console.WriteLine("Please enter a number to divide by 7 and get the remainder:");

        long number5 = Convert.ToInt64(Console.ReadLine());

        long remainder = number5 % 7; // % gives remainder

        Console.WriteLine("The remainder after dividing by 7 is: " + remainder);
    }
}