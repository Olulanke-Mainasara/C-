using system;

namespace Week_one_class2_Exercise3
{
    class Temperature_reader
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;

            console.writeline("Enter the value of the temperature in celsius: ");
            tempincelsius = convert.Todouble(console.ReadLine());

            tempinfahrenheit = (9/5 * tempincelsius) + 32;

            console.writeline("The temperature in Fahrenheit is: " + tempinfahrenheit + "F")
        }   
    }
}