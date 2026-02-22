using System; // Allows us to use Console and other basic system features

class Program
{
    static void Main()
    {
        // Print program title
        Console.WriteLine("Anonymous Income Comparison Program");

        // ---------- PERSON 1 ----------
        Console.WriteLine("Person 1");

        // Ask for Person 1 hourly rate
        Console.WriteLine("Hourly Rate?");
        decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine());

        // Ask for Person 1 hours worked per week
        Console.WriteLine("Hours worked per week?");
        decimal person1HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

        // Calculate annual salary (Hourly Rate × Hours per week × 52 weeks)
        decimal person1AnnualSalary = person1HourlyRate * person1HoursPerWeek * 52;

        // ---------- PERSON 2 ----------
        Console.WriteLine("Person 2");

        // Ask for Person 2 hourly rate
        Console.WriteLine("Hourly Rate?");
        decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine());

        // Ask for Person 2 hours worked per week
        Console.WriteLine("Hours worked per week?");
        decimal person2HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

        // Calculate annual salary
        decimal person2AnnualSalary = person2HourlyRate * person2HoursPerWeek * 52;

        // ---------- OUTPUT RESULTS ----------

        // Print Person 1 annual salary
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(person1AnnualSalary);

        // Print Person 2 annual salary
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(person2AnnualSalary);

        // Compare salaries using greater than operator
        bool person1MakesMore = person1AnnualSalary > person2AnnualSalary;

        // Print comparison result
        Console.WriteLine("Person 1 makes more money than Person 2");
        Console.WriteLine(person1MakesMore);
    }
}