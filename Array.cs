using system;

namespace Week4_Lecture1_Exercise2
{
    class Array
    {
        static int findminvalue(int[] fivearray, int size)
        {
            int minvalue = fivearray[0];
            for (int i = 1; i < size; i++)
            {
                if (fivearray[i] < minvalue)
                {
                    minvalue = fivearray[i];
                }
            }
            return minvalue;
        }

        static void main(string[] args)
        {
            int minimum;
            int[] fivearray = new int[5]
            console.writeline("Enter a number to be inputed in the array: ");
            for (int i = 0; i < 5; i++)
            {
                fivearray[i] = convert.Toint32(console.readline());
                minimum = findminvalue(fivearray, fivearray.length)
            }
        }
    }   
}