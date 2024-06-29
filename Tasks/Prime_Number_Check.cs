//Prime Number Check 2



namespace CS_in_a_Month.Tasks;

public class Prime_Number_Check
{
    public static void Prime_number()
    {
        bool Prime = true;
        int number_input = 0;
        Console.Write("Enter a number: ");
        try
        {
            number_input = int.Parse(Console.ReadLine()); 
        }
        catch (Exception e)
        {Console.WriteLine("Invalid input" + e.Message); return;}

        if (number_input <= 0 || number_input == 1) 
        {Console.WriteLine("Your number needs to be >= 2"); return;}
        
        else if (number_input == 2) {Console.WriteLine($"{number_input} is Prime");}

        else
        {
            for (int n = 2 ; n <= Math.Sqrt(number_input); n += 1)
                if (number_input % n == 0) {Console.WriteLine($"Your number {number_input} is not a Prime.");
                    Prime = false; break;}
        
            if (Prime) {Console.WriteLine($"Your number {number_input} is Prime");}   
        }
    }
}