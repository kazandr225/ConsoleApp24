using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вариант 9. В одномерном массиве, состоящем из п элементов, определить количество и индексы элементов массива.


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В одномерном массиве, состоящем из n элементов, определить количество и индексы элементов массива");
            Console.ReadKey();
            Console.Clear();

            Method();
            Console.ReadKey();

        }

        public static void Method()
        {
            try
            {
                Console.WriteLine("Введите n (положительное целое число от 1 до 99 )");
                int n = int.Parse(Console.ReadLine());

                if (n<1 || n>99)
                {
                    Console.WriteLine("Вы вышли за пределы заданного диапазона, повторите ввод размерности массива");
                    Clear();
                }
                int[] a = new int[n];
                for (int i = 0; i < n; i++) //ввод элементов массива
                {
                    Console.WriteLine("Введите {0}-й элемент \n", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                Console.WriteLine("\n");

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Индекс элемента: {0}, Значение: {1}", i, a[i]);
                }
            }

            catch
            {
                Console.WriteLine("Возникло исключение, повторите ввод");
                Clear();
            }

        }
        public static void Clear() //Очистка консоли и запуск основного метода
        {
            Console.ReadKey();
            Console.Clear();
            Method();
        }
    }
}