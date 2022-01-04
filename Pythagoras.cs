using system;

namespace Week_one_class2_Exercise2
{
    class Pythagoras_formula
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            double pythagoreandistance;

            console.writeline("Enter the value for x1: ");
            x1 = convert.Todouble(console.ReadLine());

            console.writeline("Enter the value for x2: ");
            x2 = convert.Todouble(console.ReadLine());

            console.writeline("Enter the value for y1: ");
            y1 = convert.Todouble(console.ReadLine());

            console.writeline("Enter the value for y2: ");
            y2 = convert.Todouble(console.ReadLine());

            pythagoreandistance = math.sqrt(math.pow((x2 - x1),2) + math.pow((y2 - y1),2));

            console.writeline("The Pythagorean distance is: " + pythagoreandistance);
        }   
    }   
}