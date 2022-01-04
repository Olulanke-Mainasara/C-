using system;

namespace Week5_Lecture1_Activity1
{
    class Two_Dimensional_Array
    {
        static void main(string[] args)
        {
            int rows, columns;

            console.writeline("Enter the number of rows fpr the array: ");
            rows = convert.Toint32(console.readline());
            console.writeline("Enter the number of columns: ");
            columns = convert.Toint32(console.readline());

            int [,] Array = {rows, columns};
            for (int i = 0; i < Array.Getlength(0); i++)
            {
                for (int j = 0; j < Array.Getlength(1); j++)
                {
                 console.writeline("Enter the number into row {0}, column {1}: ", i + 1, j + 1);
                 Array[i, j] = convert.Toint32(console.readline());
                }
                
            }
            console.writeline("The current Array is: ");
            
            for (int i = 0; i < length; i++)
            {
                
            }

        }   
    }   
}