// Array_Reversal

namespace CS_in_a_Month.Tasks;

public class Array_Reversal
{
    public static void Array_Revers()
    {
        List<int> list_of_numbers = new List<int>();
        
        for (int n = 0; n != 5; n += 1)
            try
            {
                Console.Write($"Give me your number {n + 1}: ");
                int number = int.Parse(Console.ReadLine()); 
                list_of_numbers.Add(number);
            }
            
            catch (Exception e)
            {Console.WriteLine("Invalid input" + e.Message);}

        list_of_numbers.Reverse();
        string final_result = string.Join(", ",list_of_numbers);
        Console.WriteLine("Revers list: " + final_result);

    }
}

