// ЗАДАЧА 63 Задайе N. Напишите программу, 
// которая выведет все натуральные числа 
// в промежутке от 1 до N.

Console.Clear();
string OutPutNumber(int Number)

{
    if (Number == 1)
        return 1.ToString();
    // string Empty = string.Empty;
    return  OutPutNumber(Number - 1) + ", "+ Number.ToString();

}
Console.Write("vvedite chislo: ");
int number = int.Parse(Console.ReadLine());
Console.Write(OutPutNumber(number));