﻿Console.Clear ();
Console.Write ("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
int max = n;
if (m > max) max = m;
Console.Write ("max =  ");
Console.WriteLine  ( max );