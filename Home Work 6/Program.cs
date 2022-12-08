using System;
using System.IO;
using static System.Console;

namespace Home_Work_6
{
    internal class Program

    {

        const string FileName = "employes.txt";
        static string[] data;

        static void Main()
        {
            while (true)
            {
                Clear();



                string input = ReadLine();
                switch (input)
                {
                    case "1":
                        ReadData();
                        PrintData();
                        break;

                    case "2":
                        WriteData();
                        break;

                    default:
                        return;
               }
            }
        }

        static private void ReadData()
        {
            data = File.ReadAllLines(FileName); 
        }

        static private void WriteData()
        {
            File.WriteAllLines(FileName, data);
        }

        static private void PrintData()
        {
            //File.WriteAllLines(FileName, data);
        }

    }
}
