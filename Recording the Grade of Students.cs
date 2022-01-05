using system;

namespace Class Exercise
{
    class Program
    {
        static void main(string[] args)
        {
            int gradesum = 0;
            console.write("How many student data are you entering: ");
            numstud = convert.Toint32(console.readline());
            string[] name = new string[numstud];
            double[,] grade = new double[numstud,6];
            for (int i = 0; i < numstud; i++)
            {
                console.write("Enter student{0}'s name: ", i);
                name[a] = console.readline();
                
                for (int j = 0; j < 6; j++)
                {
                    console.write("Enter the {0} grade of the student: ", i + 1);
                    grade[i,j] = convert.Todouble(console.readline());
                    gradesum = gradesum + grade[i,j];
                }

                double avg = gradesum/6;
            }

            for (int i = 0; i < numstud; i++)
            {
               console.writeline("") 
            }
        } 
    }   
}