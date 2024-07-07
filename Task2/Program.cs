﻿// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] numbers = new int[10];
Random random = new Random();
int evenCount = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100, 1000);
    Console.Write(numbers[i] + " ");
    if (numbers[i] % 2 == 0)
    {
        evenCount++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");