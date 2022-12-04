using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace home_work_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* проверенные задачи
            // Task 1
            Write("Введите целое чиcло: ");
            int num = int.Parse(ReadLine());

            string s = (num % 2 == 0) ? "Это четное число" : "Это нечетное число";
            WriteLine(s);
            ReadKey();
            
            // Task 2

            Write("Сколько у вас карт на руках: ");
            int countCards = Convert.ToInt32(ReadLine());
            int SumCards = 0;
            int i = 0;
            for (i = 0; i < countCards; i++)
            {
                Write($"Введите карту #{i}: ");
                string currentCard = ReadLine();

                switch (currentCard)
                {
                    case "6":
                        SumCards += 6;
                        break;

                    case "7":
                        SumCards += 7;
                        break;

                    case "8":
                        SumCards += 8;
                        break;

                    case "9":
                        SumCards += 9;
                        break;

                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        SumCards += 10;
                        break;

                    default:
                        WriteLine("Введена неверная карта!");
                        break;

                }



            }

            WriteLine($"Сумма всех карт  = {SumCards}");
            ReadKey();


            //  Task 3 определение простого числа
            Write("Введите целое число: ");
            num = int.Parse(ReadLine());
            bool isNotSimple = false;
            i = 2;

            while (i < num)
            {

                if (num % i == 0)
                {
                    isNotSimple = true;
                    break;
                }
                i++;
            }

            WriteLine(isNotSimple ? "Это не простое число" : "Это простое число");
            ReadKey();

            //  Task 4 поиск наименьшего числа
            Write("Введите длину последовательности: ");
            num = int.Parse(ReadLine());
            i = 0;
            int min = int.MaxValue;
            while (i < num)
            {
                Write("Введите число: ");
                int curentNum = Convert.ToInt32(ReadLine());
                min = Math.Min(min, curentNum);
                i++;

            }
            WriteLine($"Минимальное число из введенных = {min}");
            ReadKey();

            */


            //Task 5 угадай число
            Random RandGen = new Random();
            Write("Введите максимальное число диапазона: ");

            int RangeMax = int.Parse(ReadLine());
            int RandomNum = RandGen.Next(1,RangeMax);
            while (true)
            {
                Write("Введите число: ");
                string input = ReadLine();

                if (input == " " | input == "" )
                {
                    WriteLine($"Было загадно число = {RandomNum}");
                    break;
                }
                int curentNum = Convert.ToInt32(input);
                


                if (curentNum < RandomNum)
                    WriteLine("Это число меньше загаданного");
                
                // издержки копирования. нужно было поставить  знак больше
                else if (curentNum > RandomNum)
                    WriteLine("Это число больше загаданного");
                
                else
                {
                    WriteLine("Вы угадали!");
                    
                    break;
                }
            }

            ReadKey();


        }
    }
}
