using system;

namespace Week4_Lecture1_Exercise2
{
    class Addition_Function
    {
        static void main(string[] args)
        {
            totaleven = sumeven();
            console.writeline("The sum of the even numbers is: ", totaleven);

            totalodd = sumodd();
            console.writeline("The sum of the odd numbers is: ", totalodd);
    
            totaleverything = sumeven() + sumodd();
            console.writeline("The total of everything is: ", totaleverything);
        }
        
        static int sumeven()
        {
            int evensum = 0;
            for (int e = 0; e <= 100; e += 2)
            {
                evensum = even + e;
            }
            return evensum;
        }

        static int sumodd()
        {
            int oddsum = 0;
            for (int o = 1; o <= 100; o += 2)
            {
                oddsum = oddsum + o;
            }
            return oddsum;
        }
    }   
}