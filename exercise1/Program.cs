/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите число а ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b ");
int numberB = int.Parse(Console.ReadLine());
int max = 0;
if (numberA > numberB) max = numberA;
if (numberA < numberB) max = numberB;
Console.Write("max = ");
Console.Write(max);
