class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadAllText("input.txt");

        int part1 = SolvePart1(input);
        int part2 = SolvePart2(input);

        Console.WriteLine($"Part 1, end floor: {part1}");
        Console.WriteLine($"Part 2, cellar position: {part2}");


        static int SolvePart1(string input)
        {

            int floor = 0;

            foreach (char c in input)
            {
                if (c == '(')
                {
                    floor++;
                }
                else if (c == ')')
                {
                    floor--;
                }
            }

            return floor;
        }

        static int SolvePart2(string input)
        {
            int floor = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == '(') floor++;
                else if (c == ')') floor--;

                if (floor < 0)
                {
                    return i + 1; // Return position (1-based index)
                }

            }

            return -1; // If basement is never reached
        }
    }
}