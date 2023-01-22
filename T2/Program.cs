// Напишите программу реализующую методы формирования массива, 
// заполненного случайными числами и подсчета суммы элементов, 
// стоящих на нечётных позициях.


using static System.Console;
Clear();

Console.WriteLine("Input count of numbers in array:  ");
int.TryParse(ReadLine(), out int numbers);
int[] size = new int[numbers];

Randomnumbers(size);
PrintArray(size);
SumCounts(size);

Write($"сумма четных элементов массива равна: {SumCounts(size)} ");


void Randomnumbers(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(0, 1000);
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

int SumCounts(int[] size)
{
    int sum = 0;
    for (int i = 0; i < size.Length; i += 2)
    {
        sum = sum + size[i];
    }
    return sum;
}
