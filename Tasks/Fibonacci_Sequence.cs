// Fibonacci Sequence_2

namespace CS_in_a_Month.Tasks;


public class Fibonacci_Sequence
{
    public static void Fibonacci_math()
    {
        int inputNumber = 0;
        List<int> result = new List<int>{0, 1};
        
        Console.Write("Give me number: ");
        try
        {
            inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber <= 0) {Console.WriteLine("Invalid, your input is <= 0"); return;}
            if (inputNumber == 1) {Console.WriteLine("The first Fibonacci number is: 0"); return;}
            if (inputNumber == 2) {Console.WriteLine("The first 2 terms of the Fibonacci sequence are: 0, 1"); return;}
        }
        
        catch (Exception e)
        {Console.WriteLine("Invalid input" + e.Message); return;}

        if (inputNumber >= 3)
        {
            for (int n = 2; n != inputNumber; n += 1)
            {
                result.Add(result[n - 2] + result[n - 1]);
            }
        
            Console.Write($"The first {inputNumber} terms of the Fibonacci sequence are: ");
        
            foreach (int number in result)
            {
                Console.Write($"{number} ");
            }
        }
        else
        {Console.WriteLine("Invalid input");}
    }
}