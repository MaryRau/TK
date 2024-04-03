using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TK
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int firstEx = -1;
            int secondEx = -1;
            int thirstEx = -1;

            while (firstEx < 0)
            {
                Console.WriteLine("Сколько баллов получено за первое задание?");
                try
                {
                    firstEx = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                }

                if (FirstIsCorrect(firstEx) == false)
                {
                    Console.WriteLine("Некорректное значение!");
                    firstEx = -1;
                }
            }

            while (secondEx < 0)
            {
                Console.WriteLine("Сколько баллов получено за второе задание?");
                try
                {
                    secondEx = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                }
                
                if (SecondIsCorrect(secondEx) == false)
                {
                    Console.WriteLine("Некорректное значение!");
                    secondEx = -1;
                }
            }

            while (thirstEx < 0)
            {
                Console.WriteLine("Сколько баллов получено за третье задание?");
                try
                {
                    thirstEx = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                }
                
                if (ThirdIsCorrect(thirstEx) == false)
                {
                    Console.WriteLine("Некорректное значение!");
                    thirstEx = -1;
                }
            }

            int sum = firstEx + secondEx + thirstEx;

            if (Grade(sum) != -1) Console.WriteLine($"Получено {sum} баллов. Оценка за работу: {Grade(sum)}");

            Console.ReadKey();

        }

        public static bool FirstIsCorrect(int first)
        {
            if (first >= 0 && first <= 22) return true;
            else return false;
        }

        public static bool SecondIsCorrect(int second)
        {
            if (second >= 0 && second <= 38) return true;
            else return false;
        }

        public static bool ThirdIsCorrect(int third)
        {
            if (third >= 0 && third <= 20) return true;
            else return false;
        }

        public static int Grade(int sum)
        {
            if (sum >= 0 && sum <= 15) return 2;
            else if (sum >= 16 && sum <= 31) return 3;
            else if (sum >= 32 && sum <= 55) return 4;
            else if (sum >= 56 && sum <= 80) return 5;
            else return -1;
        }
    }
}
