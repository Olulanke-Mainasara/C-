using system;

namespace Week3_Lecture2_Exercise2
{
    class GPA
    {
        static void main(string[] args)
        {
            int n, grade_point, course_unit, quality_point, total_credit_unit;
            double total_grade_point = 0;
            double score;
            
            console.writeline("Enter your matric number: ");
            matric_no = console.Readline();

            console.writeline("Enter the number of courses you offer: ");
            no_of_courses = convert.Toint32(console.Readline());
            for (int n = 0; n <= no_of_courses; n++);
            {
                console.writeline("Enter the name of the course: ");
                name_of_course = console.Readline();

                console.writeline("Enter the credit unit for this course: ");
                credit_unit = convert.Toint32(console.Readline());

                console.writeline("Enter the score for this course: ");
                score = convert.Toint32(console.Readline());

                if (score == 70 and score <=100)
                {
                    grade_point = 5;
                }
                else if (score == 60 and score <= 69)
                {
                    grade_point = 4;
                }
                else if (score == 50 and score <= 59)
                {
                    grade_point = 3;
                }
                else if (score == 45 and score <= 49)
                {
                    grade_point = 2;
                }
                else if (score == 40 and score <= 44)
                {
                    grade_point = 1;
                }
                else if (score == 0 and score <= 39)
                {
                    grade_point = 0;
                }

                quality_point = grade_point * credit_unit;
                total_grade_point = total_grade_point + quality_point;
                total_credit_unit = total_credit_unit + credit_unit;
            }

            GPA = total_grade_point/total_credit_unit;
            console.writeline("Your matric number is: ",matric_no);
            console.writeline("Your G.P.A is: ", GPA);
        }   
    }   
}