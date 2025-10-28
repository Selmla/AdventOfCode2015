class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadAllText("input.txt");

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

        Console.WriteLine($"Final floor: {floor}");
    }
}