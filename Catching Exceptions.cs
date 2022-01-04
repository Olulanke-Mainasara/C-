using system.i;

namespace Week3_Lecture2_Exercise1
{
    class Catching_Extensions
    {
        static void main(string[] args)
        {
            // Exceptions could be thrown in the code below
            try
            {
                TextReader reader = new StreamReader(filename);
                string line = reader.Readline();
                console.writeline(line);
                reader.close();
            }
            catch (FileNotFoundException fnfe)
            {
                // Exception handler for FileNotFoundException   
                throw;
            }
        }   
    }   
}