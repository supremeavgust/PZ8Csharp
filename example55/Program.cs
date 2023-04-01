// 55 Задайте двумерный массив.
//  Напишите программу, которая заменяет строки на столбцы. 
//  В случае, если это невозможно, программа должна вывести
//   сообщение для пользователя.

int[] SingleLineInput(int reqSizeArray)
{
    int[] array;
    System.Console.WriteLine("Enter single line array with a \"space\"");
    do
    {
        array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        if (array.Length != reqSizeArray)
        {
            System.Console.WriteLine("Wrong enter, please try again");
        }
    } while (array.Length != reqSizeArray);
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            System.Console.Write($"{matrix[rows, columns]} \t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FillMatrix(int[,] matrix, int min, int max)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(min, max + 1);
        }
    }
}

int[,] CreateUserMatrix()
{
    System.Console.WriteLine("Enter size matrix");
    int[] size = SingleLineInput(2);
    return new int[size[0], size[1]];
}

bool CheckSizeMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] ReleaseMatrix(int[,] matrix)
{
    int[,] transpMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            transpMatrix[columns, rows] = matrix[rows, columns];
        }
    }
    return transpMatrix;
}

System.Console.Clear();
int[,] matrix = CreateUserMatrix();
FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
if (CheckSizeMatrix(matrix))
{
    PrintMatrix(ReleaseMatrix(matrix));
}
else
{
    System.Console.WriteLine("Кол-во строк и кол-во столбцов не совпадает");
}