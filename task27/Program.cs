/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int GetSummNum(int number)
{
    int summ = 0;
    while (number > 0)
    {
        summ = summ + number % 10;
        number /= 10;
    }
    return summ;
}
Console.WriteLine($"Сумма цифр в числе = {GetSummNum(num)}");
