using AdventOfCode2024.Solutions;

class Program 
{
    static void Main(string[] args) 
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: dotnet run <day-part> (e.g., dotnet run day1-1)");
            return;
        }

        string solution = args[0].ToLower();

        switch (solution)
        {
            case "day1-1":
                Day1Part1.Solve();
                break;
            case "day1-2":
                Day1Part2.Solve();
                break;
            default:
                Console.WriteLine($"Solution {solution} not found.");
                break;
        }
    }
}