using system;

namespace Week3_Lecture1_Exercise3
{
    class Sum_of_first_10_terms
    {
        static void main(string[] args)
        {
            int denominator = 1;
            int numerator = 8;


            int sum = 0;
            int count = 0;

            while (count < 10)
            {
                fraction = numerator/math.pow(denominator++,3);
                sum = sum + fraction;
                count++;
            }

            console.writeline("The sum of the first 10 numbers is: ", sum);
        }   
    }   
}