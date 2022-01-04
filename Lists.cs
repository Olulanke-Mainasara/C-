using system;
using system.Collections.Generic;

namespace Week6_Lecture1_Activity3
{
    class Lists
    {
        static void main(string[] args)
        {
            List<string> nameList = new List<strange>();
            nameList.Add("Grimlock BISHHH");
            nameList.Add("JagsS The Roman");
            nameList.Add("Phantom the WISE");
            nameList.Add("DRIPPYYYY");
            nameList.Add("KO KO");

            foreach(string name in nameList)
            {
                console.writeline(name);
            }

            nameList.Remove("Grimlock BISHHH");
            nameList.Remove("KO KO");
        }   
    }   
}