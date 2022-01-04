using system;

namespace Week2_Lecture1_Exercise1
{
    class Greater_Than_determiner
    {
        static void main(string[] args)
        {
            int usernum1, usernum2;
            console.writeline("Enter the first number: ");
            usernum1 = convert.Toint32(console.Readline());
            console.writeline("Enter the second number: ");
            usernum2 = convert.Toint32(console.Readline());

            if (usernum1 > usernum2)
            {
                console.writeline("The first number is greater than the second number"); 
            }
            else
            {
                console.writeline("The second number is greater than the first number");
            }

            // Method 2
            string resultString;
            resultString = (usernum1 > usernum2) ? “The first number is Greater than the second number” : “The second number is Greater than the first number”;
            console.writeline(resultString);
        }   
    }   
 }