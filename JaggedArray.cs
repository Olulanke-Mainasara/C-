using system;

namespace Week6_Lecture1_Exercise2
{
    class Jaggedarray
    {
        static void main(string[] args)
        {
            int [][] jaggedArray = new int [3][];

            jaggedArray[0] = new int[4] {1,2,3,4};
            jaggedArray[1] = new int[3] {5,6,7};
            jaggedArray[2] = new int[5] {8,9,10,11,12};

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for(int col = 0; col < jaggedArray[row].Length; col++)
                {
                    console.write(jaggedArray[row][col]);
                }
                console.writeline();  
            }
        }   
    }   
}