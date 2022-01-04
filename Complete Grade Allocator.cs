using system;

namespace Week2_Lecture_2_Exercise1
{
    class Real_Grade_Alocator
    {
        static void main(string[] args)
        {
            double grade;

            console.writeline("Enter your grade: ")
            grade = convert.Toint32(console.ReadLine())

            if (grade >= 70)
            {
                console.writeline("Your grade is an A")   
            }
            else if (grade = 60 and grade <= 69)
            {
                console.writeline("Your grade is a B")   
            }
            else if (grade = 50 and grade <= 59)
            {
                console.writeline("Your grade is a C")   
            }
            else if (grade = 45 and grade <=49)
            {
                console.writeline("Your grade is a D")   
            }
            else if (grade < 45)
            {
                console.writeline("Your grade is an F, You can never make it \ ^__ˆ /")
            }
        }
    }   
}