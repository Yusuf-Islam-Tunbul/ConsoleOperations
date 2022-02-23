using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220211_Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            int result = 999;
            int remainder = 998;
            string[] words = new string[] { "Benim", "adım" };

            Console.WriteLine(program.ReadFiveDigits());

            Console.ReadKey();
        }


        void PrintDateTime()
        {
            Console.WriteLine("Tarih: "+DateTime.Now.Date.ToShortDateString());
            Console.WriteLine("Saat: "+DateTime.Now.ToString("HH:mm:ss"));
            Console.ReadKey();
        }

        void PrintStar()
        {
            Console.WriteLine("*");
            Console.ReadKey();
        }

        void PrintStar(int number)
        {
            string text = "";

            for(int i = 0; i < number; i++)
            {
                text += "*";
            }

            Console.WriteLine(text);
            Console.ReadKey();
        }

        void NewLine()
        {
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        void NewLine(int number)
        {
            string text = "";

            for(int i = 0; i < number; i++)
            {
                text += "\n";
            }

            Console.WriteLine(text);
            Console.ReadKey();
        }

        void PrintArray(int[] numbers)
        {
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }

        void PrintArray(int[] numbers,char direction)
        {
            string text = "";

            switch (direction.ToString().ToLower())
            {
                case "s":

                    foreach (int number in numbers)
                    {
                        text+=number;
                        text += "\n";
                    }

                    break;

                case "w":

                    foreach (int number in numbers.Reverse())
                    {
                        text += number;
                        text += "\n";
                    }

                    break;

                case "d":

                    foreach (int number in numbers)
                    {
                        text += number;
                        text += " ";
                    }

                    break;

                case "a":

                    foreach (int number in numbers.Reverse())
                    {
                        text += number;
                        text += " ";
                    }

                    break;

                default:
                    goto case "d";
            }

            Console.WriteLine(text);

            
            Console.ReadKey();
        }

        int Sum(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        int Square(int number)
        {
            int squared = number * number;
            return squared;
        }

        int Power(int base_number,int power_number)
        {
            int result = (int)Math.Pow(Convert.ToDouble(base_number), power_number);
            return result;
        }

        string ReverseWord(string text)
        {
            string reversed_text = "";

            foreach(char letter in text.Reverse())
            {
                reversed_text += letter;
            }

            return reversed_text;
        }

        string ReverseSentence(string text)
        {
            string reversed_sentence = "";
            foreach (string word in (text.Split('.',',',':',';','!','?',' ')).Reverse())
            {
                reversed_sentence += word;
                reversed_sentence += " ";
            }
            return reversed_sentence;
        }

        bool TryDivide(int number, int divisor, out int result)
        {
            bool is_valid = true;

            if (divisor == 0)
            {
                is_valid = false;
                result = 0;
            }
            else
            {
                result = number/divisor;
            }

            return is_valid;
        }

        bool TryDivide(int number, int divisor, out int result, out int remainder)
        {
            bool is_valid = true;

            if (divisor == 0)
            {
                is_valid = false;
                result = 0;
                remainder = 0;
            }

            else
            {
                result = number/divisor;
                remainder = number % divisor;
            }

            return is_valid;
        }

        void AddItem(ref string[] array, string new_item)
        {
            array=array.Append(new_item).ToArray();
        }

        void RemoveItem(ref string[] array, int index)
        {
            if (index < array.Length)
            {
                List<string> temp_list = array.ToList();
                temp_list.RemoveAt(index);
                array = temp_list.ToArray();
            }            
        }

        int ReadNumber()
        {
            int number;

            try
            {
                number =Convert.ToInt32(Convert.ToDouble(Console.ReadLine()));
            }
            catch
            {
                number = 0;
            }

            return number;
        }

        float ReadNumber_()
        {
            float number;

            try
            {
                number =(float)(Convert.ToDouble(Console.ReadLine()));
            }
            catch
            {
                number = 0;
            }

            return number;
        }

        int ReadFiveDigits()
        {
            string number = "";
            char[] numbers = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            int inputs = 0;

            while (inputs<5)
            {
                char input = Console.ReadKey().KeyChar;

                if (numbers.Contains(input))
                {
                    number += input;
                    Console.WriteLine();
                    inputs++;                    
                }
                else
                {
                    Console.WriteLine("\n");
                }                
            }

            return Convert.ToInt32(number);
        }
    }
}
