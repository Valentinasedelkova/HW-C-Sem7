// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] massive = new int [3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
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

void AverageColumn(int[,] array)
{
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);
    int [] columnSum = new int[colCount];
    for(int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            columnSum[j] += array[i, j];
        }
    }
        double[] columnAverage = new double[colCount];
        for (int j = 0; j < colCount; j++) 
        {
            columnAverage[j] = Math.Round(((double)columnSum[j] / rowCount), 2);
        }
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
        for (int k = 0; k < colCount; k++)
        {
            Console.WriteLine($"Столбец {k + 1}: {columnAverage[k]}");
        }    
}

PrintDoubleMassive(massive);
AverageColumn(massive);