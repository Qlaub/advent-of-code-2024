
namespace AdventOfCode2024.Solutions 
{
    public class Day1Part2 
    {
        public static void Solve() 
        {
            var (list1, list2) = Day1Part1.SortedLists();

            int total = 0;

            for (int i = 0; i < list1.Length; i++) 
            {
                int val = list1[i];

                int[] matchingValues = Array.FindAll(list2, x => x == val);
                total += matchingValues.Length * val;
            }

            Console.WriteLine(total);
        }
    }
}