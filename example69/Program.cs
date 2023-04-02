// Задача 69 Напишите программу,
// которая на вход принимает
//  два числа A и B, и возводит число А в
//   целую степень B с помощью рекурсии.
int Pow(int a, int b)
{
    if (b==0) return 1;
    return a*Pow(a,b - 1);
}

Console.Clear();
Console.WriteLine("Введите число А: ");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b=int.Parse(Console.ReadLine());
Console.WriteLine(Pow(a,b));