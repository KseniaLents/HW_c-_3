/*Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.*/

void arrayZero (int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(col.Length);
    }
} 
void printArray (int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}
int[] array = new int[8];
arrayZero(array);
printArray(array);