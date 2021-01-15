using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя");
            string nameOfUser = Console.ReadLine(); //выводим имя на консоль
            DateTime thisDay = DateTime.Today; //вводим переменную для даты и времени
            Console.WriteLine($" Привет, {nameOfUser}, сегодня {thisDay.ToString("d")}!"); // выводим текст и дату, убираем время. В условии задачи не было требования о его выводе.
            Console.ReadLine();

        }
    }
}
/* Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%».
Имя пользователя сохранить из консоли в промежуточную переменную. 
Поставить точку останова и посмотреть значение этой переменной в режиме отладки.
Запустить исполняемый файл через системный терминал.*/