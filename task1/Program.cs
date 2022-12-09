// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Диапазон трехзначных чисел, ввод случайный.
Random random = new Random();
int[]arr=new int [6];
for (int i=0; i<arr.Length;i++)
    arr[i]=random.Next(100, 999);
Console.WriteLine(string.Join(", ",arr));
Console.WriteLine("Even Numbers "+EvenElement(arr));

int EvenElement(int[]array)
{
    int count=0;
    int b=0;
    for (int i=0; i<array.Length;i++)
        if (b==array[i]%2)
            count++;
    return count;
}