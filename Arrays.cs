using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammerenIntroExamen
{
    public class Arrays
    {
        public static void Arrayoefening()
        {
            bool[] trueFalseArray = new bool[30];

            for (int i = 0; i < trueFalseArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    trueFalseArray[i] = true;
                }
                else
                {
                    trueFalseArray[i] = false;
                }
                Console.WriteLine(trueFalseArray[i] + " ");
            }
        }
    }
}