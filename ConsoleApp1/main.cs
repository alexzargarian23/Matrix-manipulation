using ConsoleApp1;

public class Program
{
    public static void Main()
    {
        // Sample grid matching the problem statement
        Reading[][] grid = new Reading[][]
        {
            new Reading[] { new Reading { Temperature = 3, Fault = true}, new Reading { Temperature = 9, Fault = false }, new Reading { Temperature = 1, Fault = true } },
            new Reading[] { new Reading { Temperature = 4, Fault = false }, new Reading { Temperature = 8, Fault = true }, new Reading { Temperature = 2, Fault = false } }
        };

        int limit = 5;

        // Call your method
        Hit[] results = colderThan.ColderThan(grid, limit);

        // Print results to console
        Console.WriteLine($"Hits colder than {limit}:");
        foreach (var hit in results)
        {
            Console.WriteLine($"({hit.Temperature}, row {hit.Row}, col {hit.Col})");
        }

        //var arr = new int[][];
    }
}
