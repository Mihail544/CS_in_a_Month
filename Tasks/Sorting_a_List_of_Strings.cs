// Sorting List/Masive  Array of strings


namespace CS_in_a_Month.Tasks;

public class Sorting_a_List_of_Strings
{
    public static void Sorted_alphabetical()
    {
        
        Console.Write("Enter strings separated by commas: ");
        string input = Console.ReadLine();
        string[] words = input.Split(",");
        Array.Sort(words);
        
        Console.Write($"Your sorted sentence is: ");

        string result = string.Join(", ", words);
        Console.WriteLine($"Your sorted sentence is: {result}");


    }
}