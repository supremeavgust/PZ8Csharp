// 57 Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

int[, ] InputMatrix()
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[, ] matrix = new int[size[0], size[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 50);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return matrix;
}

int[] Conver2dTo1D(int[, ] matrix)
{
    int k = 0;
    int[] array = new int [matrix.GetLength(0) * matrix.GetLength(1) ];
    for( int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k++] = matrix[i,j];
            
        }
    }
    return array;
}

void PrintFr(int [] array)
{
    int count = 1;
    int oldValu = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (oldValu == array[i])
        count++;
        else
        {
             Console.WriteLine($"{oldValu} встречается в массмиве: {count}");
             count = 1;
             oldValu = array[i];
        }
    }
    Console.WriteLine($"{oldValu} встречается в массмиве: {count}");
}

Console.Clear();
int[, ] matrix = InputMatrix();
int[] array = Conver2dTo1D(matrix);
Array.Sort(array);
PrintFr(array);