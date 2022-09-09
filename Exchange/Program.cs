using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exchange
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            var dollar = Console.ReadLine();
            Console.WriteLine("Курс доллара: 60 рублей");
            int.TryParse(dollar, out var value);
            Console.WriteLine("Сумма в рублях: " + value * 60);
            if (value < 500)
            {
                
                Console.WriteLine("Итоговая сумма в рублях (с учётом комиссии): " + (value * 60 - 8));
            }
            else
            {
                Console.WriteLine("Комиссия за услуги: " + (value * 60) * (0.0037));
                Console.WriteLine("Итоговая сумма в рублях (с учётом комиссии): " + (value * 60 - ((value * 60) * (0.0037))));
            }
            Console.ReadKey();
        }
    }
}
