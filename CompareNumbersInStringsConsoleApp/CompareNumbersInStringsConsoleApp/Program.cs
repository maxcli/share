using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNumbersInStringsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is true
            bool isSame=CompareStrings("a12","12");

            // this is not true
            isSame = CompareStrings("a12", "32");
        }

        static bool CompareStrings(string s1, string s2)
        {
            bool result = true;
            int c2Ptr = 0; // index to c2 array
            //convert strings to char arrays
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            //traverse 1st array. for each char, if numeric, compare to 1st char from 2nd array
            for (int i = 0; i < c1.Length; i++)
            {

                if (c1[i].IsNumeric())
                {
                    for (int j = c2Ptr; j < c2.Length; j++)
                    {
                        c2Ptr++;
                        if (c2[j].IsNumeric())
                        {
                            if (c1[i] != c2[j])
                            {
                                result = false; //compare fails.
                            }
                            break;
                        }
                      
                    }//for inner loop
                    
                }
                if (result==false) // finish testing.
                {
                    break;
                }
            } //for outer loop

            return result;

            //static bool IsNumeric(char c)
            //{
            //    if ((c >= '0') && (c <= '9'))
            //    {
            //        return true;
            //    }
            //}
        }
    }



    public static class ExtensionMethods
    {
        public static bool IsNumeric(this char c)
        {
            if ((c >= '0') && (c <= '9'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
