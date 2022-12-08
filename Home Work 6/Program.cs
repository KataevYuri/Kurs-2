using System;
using System.IO;
//using static System.Console;

namespace Home_Work_6
{
    internal class Program

    {

        const string FileName = "employes.txt";
        static string[] data = new string[0];

        static void Main()
        {
            while (true)
            {
                //Console.Clear();

                Console.WriteLine("-- Введите 1 для вывода файла");
                Console.WriteLine("-- Введите 2 для ввода новых данных");
                Console.WriteLine("-- Любой символ для выхода из программы");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        if (ReadData()) 
                            PrintData();
                        break;

                    case "2":
                        if (InputData())
                            WriteData();
                        else
                            Console.WriteLine("Введены некорректные данные!");
                        break;

                    default:
                        return;
               }
            }
        }

        static private bool ReadData()
        {
            bool isData = false;
            if (File.Exists(FileName))
            {
                data = File.ReadAllLines(FileName);
                isData = data.Length > 0;
            }

            if(!isData) Console.WriteLine("-- Данных еще нет! --");
            
            return isData;
        }

        static private void WriteData()
        {
            if (data.Length > 0)
                File.WriteAllLines(FileName, data);
        }

        static private void PrintData()
        {
            for (int i=0; i<data.Length; i++)
                Console.WriteLine(data[i]);

        }

        static private bool InputData()
        {
            Console.Write("Введите Ф.И.О: ");
            string fio = Console.ReadLine();
            Console.Write("Введите возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите рост: ");
            string height = Console.ReadLine();
            Console.Write("Введите дату рождения в формате ДД.ММ.ГГГГ: ");
            string birthday = Console.ReadLine();
            Console.Write("Введите место рождения: ");
            string birthplace = Console.ReadLine();

            
            if (fio.Length>0 && age.Length>0 && height.Length>0 && birthday.Length>0 && birthplace.Length>0)
            {
                string _text = $"#{data.Length+1}|{DateTime.Now.ToString("dd.MM.yyyy HH:mm")}" +
                               $"|{fio}|{age}|{height}|{birthday}|{birthplace}";
                Array.Resize(ref data, data.Length + 1);
                data[data.Length - 1] = _text;
                return true;
            }
            else return false;
        }

    }
}
