﻿//Ввод трехзначного числа и вывод второй цифры этого числа
Console.Clear();
int n = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine($"Случайное число: {n}"); 
int n1 = ((n / 10) % 10);
//int n3 = n % 10;
Console.WriteLine(n1);
