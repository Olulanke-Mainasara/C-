using system;

namespace Week2_Lecture1_Exercise2
{
    class Grade_Alocator
    {
        static void main(string[] args)
        {
            double grade;

            console.writeline("Enter the grade: ")
            grade = convert.Todouble(console.Readline())

            if (grade = 40 && grade <= 50)
            {
                console.writeline("your grade is A")   
            }
            else if (grade = 30 && grade <= 39)
            {
                console.writeline("Your grade is B")   
            }
            else if (grade = 20 && grade <= 29)
            {
                console.writeline("Your grade is C")   
            }
        }   
    }
}