// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Random rand = new Random();

double[] array = new double [10];
int  L = array.Length;



for (int i = 0; i < L; i++)
{
    
    double mult1 = rand.NextDouble() * 100;
    // Console.WriteLine(mult1);

    array[i] = rand.NextDouble() * mult1;
    
    // Console.WriteLine(array[i]);

}

double Max = array[0];          // Так сделано, на случай если будет потребность работы с отрицательными числами.
double Min = array[0];

for (int i = 0; i < L; i++)
{
    if (array[i] > Max) Max = array[i];

    if (array[i] < Min) Min = array[i];
}

double diff = Math.Round(Max - Min, 3);

// Console.WriteLine("Max = " + Max);
// Console.WriteLine("Min = " + Min);

Console.WriteLine("Разница между максимальным и минимальным числом в массиве = " + diff);