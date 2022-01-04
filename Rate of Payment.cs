using system;

namespace Week2_Lecture2_Activity3
{
    class Rate_of_payment
    {
        static void main(string[] args)
        {
            double  worktime;
            int payment;
            
            console.writeline("Enter the number of hours worked: ");
            worktime = convert.Toint32(console.ReadLine());

            if (worktime <= 12)
            {
                payment = 50 * worktime;
                console.writeline("Your earn per day is: N" + payment)
            }
            else if (worktime > 12)
            {
                payment = (50 * 12) + (90 * (worktime - 12));
                console.writeline("Your earn per day is: N" + payment)
            }
        }   
    }   
}