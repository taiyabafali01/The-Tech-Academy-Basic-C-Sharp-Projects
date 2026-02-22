using System; // Allows us to use basic system functions like Console

class Program
{
    static void Main()
    {
        // Print the school name
        Console.WriteLine("Academy of Learning Career College");

        // Print the report title
        Console.WriteLine("Student Daily Report.");

        // Ask for student's name and store it as a string
        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine();

        // Ask what course they are on and store it as a string
        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();

        // Ask for page number and convert input to integer
        Console.WriteLine("What page number?");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        // Ask if student needs help (true/false) and convert to boolean
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        bool needHelp = Convert.ToBoolean(Console.ReadLine());

        // Ask about positive experiences and store response as string
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveExperience = Console.ReadLine();

        // Ask for additional feedback and store response as string
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string additionalFeedback = Console.ReadLine();

        // Ask how many hours studied and convert to decimal (could be 2.5 hours)
        Console.WriteLine("How many hours did you study today?");
        decimal hoursStudied = Convert.ToDecimal(Console.ReadLine());

        // Final thank-you message
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
    }
}