// Finding the Longest Word


namespace CS_in_a_Month.Tasks;

public class Find_the_longest_string
{
    public static void find_the_longest()
    {
        Console.Write("Give me your data: ");
        string[] input = Console.ReadLine().Split(" ");

        int count = 0;
        int index = 0;
        for (int n = 0 ; n < input.Length ;n++)
        {
            if (input[n].Length > count)
            {
                count = input[n].Length;
                index = n;}
        }

        Console.WriteLine($"Your longest word is {input[index]} with '{count}' sumbols. ");
    }
}
