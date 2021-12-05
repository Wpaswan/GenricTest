using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricTestApplication
{
    internal class ComparisonOf3Numbers
    {
        public static int FindMaxIntNumber(int first, int second, int third)
        {
            if ((first.CompareTo(second) >0)&&(first.CompareTo(third)>0))
            {
                return first;
            }
            else if ((second.CompareTo(first)>0)&&(second.CompareTo(third)>0))
            {
                return second;
            }
            else if ((third.CompareTo(second)>0)&&(third.CompareTo(first)>0))
            {
                return third;
            }
            else
            {

                return default;
            }
        }
        public static float FindMaxFloatNumber(float first, float second, float third)
        {
            if ((first.CompareTo(second) >0)&&(first.CompareTo(third)>0))
            {
                return first;
            }
            else if ((second.CompareTo(first)>0)&&(second.CompareTo(third)>0))
            {
                return second;
            }
            else if ((third.CompareTo(second)>0)&&(third.CompareTo(first)>0))
            {
                return third;
            }
            else
            {

                return default;
            }
        }
        public static string FindMaxFloatNumber(string first, string second, string third)
        {
            if ((first.CompareTo(second) >0)&&(first.CompareTo(third)>0))
            {
                return first;
            }
            else if ((second.CompareTo(first)>0)&&(second.CompareTo(third)>0))
            {
                return second;
            }
            else if ((third.CompareTo(second)>0)&&(third.CompareTo(first)>0))
            {
                return third;
            }
            else
            {

                return default;
            }
        }
    }
}
