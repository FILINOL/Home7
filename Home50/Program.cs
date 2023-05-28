
// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


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

bool IsNumberInArray(int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            while (arr[i, j] == number)
            {
                    Console.WriteLine($"Индексы числа {number} в массиве:[{i},{j}]");
                    return  true; 
            }
        }
    }
    Console.WriteLine($"Число {number} не найдено в массиве");
    return false;
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
Console.Write("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
IsNumberInArray(number);
// string text = Console.ReadLine();
// Console.WriteLine("Введите число: ");
// string text = Console.ReadLine();


