using System;

namespace Homework
{
    class TaskArrays
    {
        public static void Main()
        {
            int[] array1 = new int[8];

            array1[0] = 0;
            array1[1] = 1;

            for (int a = 2; a < 8; a++)
            {
                array1[a] = array1[a - 1] + array1[a - 2];
            }
        }
    }
}