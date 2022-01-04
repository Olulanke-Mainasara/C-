using system:

namespace Week7_Lecture1_Activity1
{
    public class Date
    {
        private int month = 7;
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if((value > 0) && (value < 13))
                {
                    month = value;
                }
            }
        }
    }

    class Program
    {

    }   
}