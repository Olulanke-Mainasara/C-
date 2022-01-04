using system;

namespace Week3_Lecture1_Exercise1
{
    class Integer_sum
    {
        static void main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int value;
            

            console.writeline("Enter the amount of integers to be summed up: ");
            int integer = convert.Toint32(console.ReadLine());

             while (count < integer)
             {
                console.writeline("Enter the next number to be added: ");
                value = convert.Toint32(console.ReadLine());
                sum = sum + value;
                count++;
             }

             console.writeline("The sum of all the integers is: ", sum);

        }   
    }   
}