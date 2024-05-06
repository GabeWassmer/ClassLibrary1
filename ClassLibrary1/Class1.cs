class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your birthday (yyyy/mm/dd):");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
        {
            Console.WriteLine("Invalid date format.");
            return;
        }

        int ageInDays = (DateTime.Today - birthday).Days;
        Console.WriteLine($"Your age in days is: {ageInDays}");
    }
}
