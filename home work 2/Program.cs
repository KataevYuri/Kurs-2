using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace home_work_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string FIO = "Kataev Yuri B.";  // Ф.И.О.
            int Age = 99;// Возраст
            string Email = "u_kataev@mail.ru";
            float balProgramming = 1.5f; // Баллы по программированию
            float balMatematika = 2.8f;// Баллы по математике
            float balFizika = 3.2f; // Баллы по физике

            
            WriteLine("--- Задание 1 ----");
            WriteLine("Ф.И.О = {0}, Возраст = {1}, Эл.почта = {2}: прогр: = {3}, матем: =, физика = {4}", FIO, Age, Email, balProgramming, balMatematika, balFizika);
            ReadKey();


            float sumBal = balFizika + balMatematika + balProgramming;
            float averBal = sumBal / 3;           
            WriteLine("\n--- Задание 2 ----");
            WriteLine("Сумма баллов: = {0}, средний балл = {1}", sumBal, averBal);
            ReadKey();
             

        }
    }
}
