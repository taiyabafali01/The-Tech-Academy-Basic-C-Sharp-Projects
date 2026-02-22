using System; // Allows use of Console and basic system functions

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask for package weight
        Console.WriteLine("Please enter the package weight:");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // If weight is greater than 50, stop program
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Ends the program immediately
        }

        // Ask for package width
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Ask for package height
        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Ask for package length
        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Check if total dimensions exceed 50
        decimal totalDimensions = width + height + length;

        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Ends the program immediately
        }

        // Calculate shipping quote
        // Multiply dimensions together
        decimal volume = width * height * length;

        // Multiply by weight and divide by 100
        decimal quote = (volume * weight) / 100;

        // Display formatted dollar amount with 2 decimal places
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

        // Final message
        Console.WriteLine("Thank you!");
    }
}