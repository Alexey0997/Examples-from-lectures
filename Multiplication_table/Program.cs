﻿// Написать программу формирования таблицы умножения, 
// используя оператор цикла в цикле. 
Console.Clear();
for(int i = 1; i <= 10; i++)
{
    for(int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}