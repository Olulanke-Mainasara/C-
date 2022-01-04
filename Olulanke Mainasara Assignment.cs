using system;

namespace Olulanke Mainasara 
{
    class Assignment
    {
        static void main(string[] args)
        {
            Console.Write("How many numbers are you inputting? ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] num_array = new int[size];
            for (int i = 0; i < num_array.Length; i++)
            {
                Console.Write("Enter value {0}: ", i + 1);
                num_array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The mean is {0} and the standard deviation is {1}", Mean(num_array), StandardDeviation(num_array));

        }

        static double StandardDeviation(int[] array)
        {
            double sum = 0.0;
            double mean = Mean(array);
            for (int i = 0; i < array.Length;i++)
            {
                sum += Math.Pow((array[i] - mean), 2);
            }
            double var = sum / (array.Length - 1);
            return Math.Sqrt(var);
        }

        static double Mean(int[] array)
        {
            double sum = 0.0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avg = Convert.ToDouble(sum) / Convert.ToDouble(array.Length);
            return avg;
        }  
    }
}