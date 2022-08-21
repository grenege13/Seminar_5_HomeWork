// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int [10];
int L = array.Length;
int even_count_sum = 0;

for (int i = 0; i < L; i++)
{
    array[i] = new Random().Next(0, 100);
    if (i % 2 != 0)
    {
        even_count_sum = even_count_sum + array[i];
        // Console.WriteLine(i + "  >>  " + array[i]);
    }
    // else Console.WriteLine(i);
}

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + even_count_sum);