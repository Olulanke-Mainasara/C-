using system;

namespace Week2_Lecture2_Actvity2
{
    class Quadratic_Formula
    {
        static void main(string[] args)
        {
            int a, b, c;
            double x1, x2;

            console.writeline("Enter the number to represent a");
            a = convert.Toint32(console.ReadLine());

            console.writeline("Enter the number to represent b");
            b = convert.Toint32(console.ReadLine());

            console.writeline("Enter the number to represent c");
            c = convert.Toint32(console.ReadLine());

            x1 = (-b + (math.sqrt(math.pow(b,2) - 4 * a * c)))/2 * a;


            x2 = (-b - (math.sqrt(math.pow(b,2) - 4 * a * c)))/2 * a;

        }   
    }   
}