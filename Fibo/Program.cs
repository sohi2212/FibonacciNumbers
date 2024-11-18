using System;

namespace FiboNumbers
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Генерация последовательности Фибоначчи до n числа");
            Console.Write("Введите до какого числа хотите сделать последовательность:");
            int n = Convert.ToInt32(Console.ReadLine());
            FiboCalculation(n);
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Расчет выполнен, нажмите любую кнопку чтоб завершить программу");
            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }


        static long FiboCalculation(int n)
        {
            if (n == 0)
            {
                return 0; // Если указали 0
            }
            if (n == 1)
            {
                return 1;// Если указали 1
            }
            long fiboFirst = 0;
            long fiboSecond = 1;
            Console.WriteLine(fiboFirst);
            Console.WriteLine(fiboSecond);
            for (int i = 2; i < n; i++) // задано 2 т.к первые две итерации сделаны выше через условие
            {
                long fiboresult = fiboFirst + fiboSecond;
                fiboFirst = fiboSecond;
                fiboSecond = fiboresult;
                Console.WriteLine(fiboresult);
                
            }
            return fiboSecond;
        }
    }
}