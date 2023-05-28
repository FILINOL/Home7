// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arr = new int[3, 4];
// int m = 3;
// int n = 4;

void RandomArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}


void IsNumberInArray()
{
    for (int i = 0; i < arr.GetLength(1); i++)
    { 
        double sum = 0;

        for (int j = 0; j < arr.GetLength(0); j++)
        { 
            sum += arr[j, i];
        }
        double average = sum / arr.GetLength(0);
        Console.WriteLine("Среднее арифметическое элементов столбца {0} равно {1:F1}", i + 1, average);
    }

}


void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


RandomArray();
PrintArray();
IsNumberInArray();

