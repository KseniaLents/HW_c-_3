/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNum(num);
Console.Write("Массив: ");
PrintArray(num);
int sum = 0;

for (int x = 0; x < num.Length; x+=2)
    sum = sum + num[x];

    Console.WriteLine($"Cумма элементов cтоящих на нечётных позициях = {sum}");

void FillArrayRandomNum(int[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = new Random().Next(-100,100);
        }
}
void PrintArray(int[] num)
{
    Console.Write(" ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write(" ");
    Console.WriteLine();
}
   