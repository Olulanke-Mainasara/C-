using system;

namespace Week8_Lecture2_Exercise3
{
    public class RatNumber
    {
        int num, den;

        public RatNumber()
        {
            num = 0;
            den = 1;
        }

        public RatNumber(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        public static RatNumber operator +(RatNumber A, RatNumber B)
        {
            int num = (A.num * B.den) + (B.num * A.den);
            int den = A.den * B.den;
            RatNumber temp = new RatNumber(num, den);
            return temp;
        }

        public void display()
        {
            console.writeline("{0}/{1}", num, den);
        }
    }
        
    class Program
    {
        static void main(string[] args)
        {
            RatNumber first = new RatNumber(1, 3);
            RatNumber second = new RatNumber(); 
            RatNumber result = new RatNumber();
            result = first + second;
            result.display;
            console.Readkey()
        }
    }   
}