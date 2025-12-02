using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Validator
    {
        public static bool validation(string text, bool isDigit)
        {
            string temp = text;

            //Проверка на пустоту
            if (String.IsNullOrEmpty(text))
            {
                return false;
            }

            if (isDigit)
            {

                //Проверка на цифры
                if (int.TryParse(temp, out int value))
                {
                    Console.WriteLine("Заполните поле буквами");
                    return true;
                }
            }
            else
            {

                //Проверка на буквы
                if (!temp.All(char.IsLetter))
                {
                    Console.WriteLine("Заполните поле цифрами");
                    return false;

                }
            }
            return true;
        }
    }
}
