using system;

namespace Week_one_class2_Exercise1
{
    class Product
    {
        static void Main(string[] args)
        {
            int num_a, num_b, num_c, num_d;

            console.writeline("Enter the first number: ");
            num_a = convert.Toint32(console.ReadLine());

            console.writeline("Enter the second number: ");
            num_b = convert.Toint32(console.ReadLine());

           console.writeline("Enter the second number: ");
            num_c = convert.Toint32(console.ReadLine());

            console.writeline("Enter the second number: ");
            num_d = convert.Toint32(console.ReadLine());

            int product = num_a * num_b * num_c * num_d;

            console.writeline("The product is: " + product);

        }   
    }
}