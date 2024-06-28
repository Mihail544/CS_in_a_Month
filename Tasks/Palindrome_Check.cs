// Palindrome_Check 3

namespace CS_in_a_Month.Tasks;

public class Palindrome_Check
{
    public static void Palindromes()
    {
        Console.WriteLine("Give me data: ");
        string word = Console.ReadLine();
        
        if (word.Length <= 0 ) {Console.WriteLine("Invalid input");}

        string reversed_word = new string(word.Reverse().ToArray());
        
        if (word == reversed_word) {Console.WriteLine("Your input is Palindrome");}

        else {Console.WriteLine("Your input is a normal word");}
    }
}