//ЗАДАЧА 65 Задайте значения M и N.
//Напишите программу, которая выведет
//все натуральные числа в промежутке от M до N.

Console.Clear();
string OutPutNumber(int Number1, int Number2)

{
    if (Number1 == Number2)
        return Number1.ToString();
    return OutPutNumber(Number1, Number2 - 1) + ", " + Number2.ToString();

}
Console.Write("vvedite chislo: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(OutPutNumber(numbers[0], numbers[1]));