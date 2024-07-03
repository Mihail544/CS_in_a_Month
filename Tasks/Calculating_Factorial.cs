// Calculating Factorial

namespace CS_in_a_Month.Tasks;

public class Calculating_Factorial
{
    public static void Factorial()
    {
        Console.Write("Give me number: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Invalid input, please enter a non-negative number.");
                return;
            }
            int result = 1;
            for (int n = number; n > 0; n--)
            {
                result *= n;
            }
            Console.WriteLine($"Factorial of {number} is: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input, please enter a valid number.");
        }
    }
}
