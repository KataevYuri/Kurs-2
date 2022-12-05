using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите исходную строку: ");
            string text = ReadLine();

            string[] words = SplitText(text);

            WriteWords(words);

            string reverstext = ReverseWordsInText(text);
            WriteLine("\nПеревернутая строка получилась такая:");
            WriteLine(reverstext);

            ReadKey();

        }

        static string[] SplitText(string _text)
        {
            string[] _words = new string[0];

            //_words = _text.Split(' ');//  попробуем сделать свой алгоритм разделения
            
            while (true)
            {

                int index = _text.IndexOf(' ');
                if (index == -1)
                {
                    //_words.Append(_text); Вообще не понял почему функция Append не работает пришлось свой аппенд писать
                    Append(ref _words, _text);
                    break;
                }
                else
                {
                    //_words.Append(_text.Substring(0, index));  //??????


                    Append(ref _words, _text.Substring(0, index));
                    _text = _text.Substring(index + 1);
                }
            }


            return _words;

        }
        static void WriteWords(string[] _words)
        {
            WriteLine("Полученные слова:");
            foreach (string word in _words)
            {
                WriteLine(word);
            }
        }

        static void Append(ref string[] _array, string _text)
        {
            Array.Resize(ref _array, _array.Length + 1);
            _array[_array.Length - 1] = _text;
        }


        static string ReverseWordsInText(string _text)
        {
            string[] _words = SplitText(_text);
            string newtext = "";
            for (int i = _words.Length - 1; i >= 0; i--)
            {
                newtext += _words[i] + " ";
            }

            return newtext;
        }
    }
}
