﻿// Напишите программу, которая на вход принимает число и выдает,
// является ли чтсло четным (делится ли на два без остатка) 
//  4 -> да
// -3 -> нет
//  7 -> нет

Console.Clear();
Console.WriteLine("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());
if ((a % 2) !=0)
{
        Console.WriteLine("Число четное? Нет.");
}

else Console.WriteLine("Число четное? Да.");