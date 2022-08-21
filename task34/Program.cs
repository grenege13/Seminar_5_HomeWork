// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int [10];
int L = array.Length;

int honest_count = 0;

for (int i = 0; i < L; i++)
{
    array[i] = new Random().Next(100, 10000);

    if (array[i] % 2 == 0) 
    {
        honest_count ++;
        // Console.WriteLine(array[i] + " <<< чётное");
    }
    // else Console.WriteLine(array[i]);
}

Console.WriteLine("Количество четных чисел в массиве = " + honest_count);