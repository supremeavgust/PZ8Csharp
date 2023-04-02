// 67 Напишите программу, которая будет
// принимать на вход число и возвращать сумму его цифр.

int SummDigital(int number)
{
    if (number == 0)
    {
        return number;

    }
    return number % 10 + SummDigital(number / 10);

}
Console.Clear();
Console.Write("Vvedite chislo: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(SummDigital(number));
