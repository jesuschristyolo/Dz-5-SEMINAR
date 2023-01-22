//  Напишите программу реализующую методы формирования массива, заполненного случайными положительными 
//трёхзначными числами, и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();


Console.WriteLine("Input count of numbers in array:  ");
int.TryParse(ReadLine(), out int numbers);
int[] size = new int[numbers];

Randomnumbers(size);
PrintArray(size);
CountArray(size);

Write($"-> {CountArray(size)} четные");



void Randomnumbers(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}] ");
}

int CountArray(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] % 2 == 0)
            count++;
    }
    return count;

}