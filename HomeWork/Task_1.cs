// 2й Семинар (Простые алгоритмы)
// Задача 1: Проверка кратности числа 7 и 23

using System;

// Ввод числа для проверки его кратности к 7 и 23 одновренменно.
Console.WriteLine("entr any number but 0");
int user_number = int.Parse(Console.ReadLine()!);
// int user_number = Convert.ToInt32(Console.ReadLine()); //Второй метод
int a = 7; // обьявление переменной а 
int b = 23; // обьявление переменной b

if (user_number != 0)  // проверка что число не равно 0 для выполнение модуля проверки на кратность

        // модуль проверки на кратность
        {
            if (user_number % a == 0 && user_number % b ==0)
            {
                Console.WriteLine($"{user_number} is a multiple of  {a} and {b}");
            }
            else
            {
                Console.WriteLine($"{user_number} is not multiple of  {a} and {b}");
            }
        }
        else // если введен 0 то идет соответсвующее сообщение. 
        {
            Console.WriteLine("Error: Division by zero is undefined");
        }

        // Вариант 2 при провекри хотя бы одного числа
        // {
        //     if (user_number % a == 0)  
        //     {
        //         Console.WriteLine($"{user_number} is a multiple of  {a} ");
        //     }
        //    else if(user_number % b ==0)
        //     {
        //         Console.WriteLine($"{user_number} is a multiple of  {b} ");
        //     }
            
        //     else
        //     {
        //         Console.WriteLine($"{user_number} is not multiple of  {a} and {b}");
        //     }
        // }
        // else // если введен 0 то идет соответсвующее сообщение. 
        // {
        //     Console.WriteLine("Error: Division by zero is undefined");
        // }