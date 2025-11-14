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

            
            
            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";
            
            

            int[,] array = new int[3, 3]
            {
                { 2, 3, 4 },
                { 4, 9, 16 },
                { 8, 27, 64 }
            };

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
            }

            
            double[][] array = new double[3][];
            array[0] = new double[] { 1, 2, 3, 4, 5 };
            array[1] = new double[] { Math.E, Math.PI };
            array[2] = new double[]
            {
                Math.Log10(1),
                Math.Log10(10),
                Math.Log10(100),
                Math.Log10(1000)
            };
            
            
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            
            Array.Copy(array, 0, array2, 0, 3);
            Array.Resize(ref array, array.Length * 2);
        }
        
        
        
        
        
            



        }


    }
