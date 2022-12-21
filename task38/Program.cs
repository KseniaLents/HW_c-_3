/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] > max)
    {
    max = numbers[x];
    }
if (numbers[x] < min)
    {
    min = numbers[x];
    }
}

Console.WriteLine($"Max = {max}, Min = {min}");
Console.WriteLine($"Max - Min = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
    {
    numbers[i] = Convert.ToDouble(new Random().Next(1, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write(" ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write(" ");
    Console.WriteLine();
}