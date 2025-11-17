using System;

namespace Homework
{
    class taskСycles
    {
        public static void Main()
        {
            int[] array = new int[10];
            array[0] = 0;
            array[1] = 1;

            for (int i = 2; i <array.Length; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j);
                }
                Console.WriteLine();
            }
            
            string password = "qwerty";
            string input;
            do
            {
                Console.Write("Введите пароль: ");
                input = Console.ReadLine();
            }
            while (input != password);
            Console.WriteLine("Пароль верный!");
        }
        
        
        
        
        
            



        }


    }
