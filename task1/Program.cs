﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет,
 //является ли оно палиндромом.

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int pal = number.Length;

if (pal == 5)
{
    if (number[0]== number[4] && number[1]== number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
         Console.WriteLine($"{number} - НЕ палиндром");
    }
}
