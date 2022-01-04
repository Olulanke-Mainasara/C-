using system;

namespace Week_one_class2_Exercise4
{
    class Weight_Converter
    {
        static void Main(string[] args)
        {
            double pounds, kg;

            console.writeline("Enter the weight in pounds: ");
            weightinpounds = convert.Todouble(console.ReadLine());

            weightinkilogram = weightinpounds * 0.453592;

            console.writeline("The weight in kilograms is: " + weightinkilogram + "Kg")
        }
    }   
}