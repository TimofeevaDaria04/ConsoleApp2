using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двоичное число (до 8 знаков): ");
            string binaryStr = Console.ReadLine();

            // Переводим строку из двоичной системы в число
            int decimalNum = Convert.ToInt32(binaryStr, 2);

            Console.WriteLine($"Результат: {decimalNum}");
            Console.ReadLine(); // Чтобы окно не закрывалось сразу
        }
    }
}
