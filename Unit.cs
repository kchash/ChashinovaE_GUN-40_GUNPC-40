using System.Collections.Generic;

namespace HomeWork
{
    internal class Program
    {
        private class ListTask
        {
            private List<string> list = new List<string> { "1", "2", "3" };

            public void TaskLoop()
            {
                Console.WriteLine("Задание 1");

                while (true)
                {
                    Console.Write("Добавьте строку в конец списка: ");
                    string s = Console.ReadLine();
                    if (s == "--exit") break;
                    list.Add(s);

                    Console.WriteLine("Список:");
                    list.ForEach(Console.WriteLine);

                    Console.Write("Добавьте строку в середину списка: ");
                    s = Console.ReadLine();
                    if (s == "--exit") break;
                    list.Insert(list.Count / 2, s);

                    Console.WriteLine("Список:");
                    list.ForEach(Console.WriteLine);
                }
            }
        }

        private class DictionaryTask
        {
            private Dictionary<string, int> students = new Dictionary<string, int>();

            public void TaskLoop()
            {
                Console.WriteLine("Задание 2");

                while (true)
                {
                    Console.Write("Имя студента: ");
                    string name = Console.ReadLine();
                    if (name == "--exit") break;

                    Console.Write("Оценка: ");
                    string gradeStr = Console.ReadLine();
                    if (gradeStr == "--exit") break;

                    if (int.TryParse(gradeStr, out int grade) && grade >= 2 && grade <= 5)
                        students[name] = grade;
                    else
                    {
                        Console.WriteLine("Некорректный ввод");
                        continue;
                    }

                    Console.Write("Введите имя студента: ");
                    string search = Console.ReadLine();
                    if (search == "--exit") break;

                    Console.WriteLine(students.ContainsKey(search)
                        ? $"Оценка: {students[search]}"
                        : "Студента нет");
                }
            }
        }

        private class DoublyLinkedListTask
        {
            private class Node
            {
                public string Data;
                public Node Next;
                public Node Prev;
                public Node(string data) { Data = data; }
            }

            private Node head;
            private Node tail;

            public void TaskLoop()
            {
                Console.WriteLine("Задание 3");
                int count = 0;

                while (count < 6)
                {
                    string input = Console.ReadLine();
                    if (input == "--exit") break;
                    if (!string.IsNullOrEmpty(input))
                    {
                        AddNode(input);
                        count++;
                    }
                }
                
                Console.WriteLine("Прямой порядок: ");
                for (Node n = head; n != null; n = n.Next) Console.WriteLine(n.Data);

                Console.WriteLine("Обратный порядок: ");
                for (Node n = tail; n != null; n = n.Prev) Console.WriteLine(n.Data);
            }

            private void AddNode(string data)
            {
                Node n = new Node(data);
                if (head == null) head = tail = n;
                else { tail.Next = n; n.Prev = tail; tail = n; }
            }
        }

        static void Main()
        {
            Console.Write("Введите номер задания");
            string task = Console.ReadLine();

            switch (task)
            {
                case "1": new ListTask().TaskLoop(); break;
                case "2": new DictionaryTask().TaskLoop(); break;
                case "3": new DoublyLinkedListTask().TaskLoop(); break;
                default: Console.WriteLine("Такого заданя нет"); break;
            }
            
        }
    }
}