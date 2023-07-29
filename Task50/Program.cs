// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] massive = new int [3, 7];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 7; j++)
    {
        massive[i, j] = new Random().Next(0, 101); 
    }
}

void PrintDoubleMassive(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

string NumberElement (int[,] array, int row, int column)
{
    int rowCount = array.GetLength(0);
    int columnCount = array.GetLength(1);
    if (row >= 0 && row < rowCount && column >= 0 && column < columnCount)
    {
        return array[row -1, column-1].ToString();
    }
    else{
        return "Такого элемента нет";
    }
}

PrintDoubleMassive(massive);
int row = GetInfo("Введите координату строки массива: ");
int column = GetInfo("Введите координату столбца массива: ");


string numberElement = NumberElement(massive , row, column); 
Console.WriteLine(numberElement);