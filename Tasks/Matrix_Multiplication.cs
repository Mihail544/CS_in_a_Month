// Matrix Multiplication

namespace CS_in_a_Month.Tasks;


public class Matrix_Multiplication
{
    public static void The_Matrix()
    {
        List<int> matrix_one = new List<int>();
        List<int> matrix_two = new List<int>();
        List<int> final_matix = new List<int>();
        
        
        
        Console.WriteLine("Give me the fiurst matrix , each number separet with ',' : ");
        string[] matrix_one_str = Console.ReadLine().Split(",");
        
        Console.WriteLine("Give me the second matrix , each number separet with ',' :  ");
        string[] matrix_two_str = Console.ReadLine().Split(",");

        foreach (string number in matrix_one_str)
        {
            int new_number = int.Parse(number);
            matrix_one.Add(new_number);}
        
        foreach (string number in matrix_two_str)
        {
            int new_number = int.Parse(number);
            matrix_two.Add(new_number);}

        int matrix_one_count = matrix_one.Count;
        int matrix_two_count = matrix_two.Count;
        double matrix_composition = Math.Sqrt(matrix_one_count);
        
        
        if (matrix_one_count == matrix_two_count && matrix_composition % 1 == 0)
        {
            int size = (int)matrix_composition;

            for (int i = 0; i < size ; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int result = 0;

                    for (int k = 0; k < size; k++)
                    {
                        result += matrix_one[i * size + k] * matrix_two[k * size + j];
                    }
                    
                    final_matix.Add(result);
                }
            }

            
            Console.WriteLine("Your resulth: ");
            foreach (int number in final_matix)
            {Console.Write($"{number}, ");}

        }
        
        else
        {Console.WriteLine("Invalid input, your matrix is wrong.");}
        

    }
}