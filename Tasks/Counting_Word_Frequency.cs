// Counting Word Frequency

namespace CS_in_a_Month.Tasks;

public class Counting_Word_Frequency
{
    public static void Word_count()
    {

        Dictionary<string, int> Word_Frequence_count = new Dictionary<string, int>();
        
        Console.Write("Give me data: ");
        string[] input = Console.ReadLine().Split(" ");


        foreach (string word in input)
        {
            if (Word_Frequence_count.ContainsKey(word))
            {
                Word_Frequence_count[word]++;
            }
            else
            {
                Word_Frequence_count.Add(word, 1);
            }
        }
        
        Console.WriteLine("Word frequencies:");
        foreach (var kvp in Word_Frequence_count)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}