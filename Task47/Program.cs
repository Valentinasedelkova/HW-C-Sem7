// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double [,] DoDoubleMassive (int rows, int columns)
{
    double [,] result = new double [rows, columns];
    Random random = new Random();
    for (int i = 0; i< rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        double randomNumber = random.NextDouble() * 200-100;
        result[i, j] = Math.Round(randomNumber, 2);   
}
}
return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

void PrintDoubleMassive(double[,] massive)
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

int rows = GetInfo("Введите количество строк массива: ");
int columns = GetInfo("Введите количество столбцов массива: ");

double[,] massive = DoDoubleMassive (rows, columns);
PrintDoubleMassive(massive);