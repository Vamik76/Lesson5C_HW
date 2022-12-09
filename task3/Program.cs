// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//Диапазон любой, ввод зависит от пользователя. (размер, значения)
Random random = new Random();
int[]arr=new int [7];
for (int i=0; i<arr.Length;i++)
    arr[i]=random.Next(0, 100);
Console.WriteLine(string.Join(", ",arr));
Console.WriteLine("Difference between Max and Min Elements: "+DiffMaxMin(arr));

int DiffMaxMin(int[] array)
{
    int i=1,diff=0,max=array[0],min=array[0];
    for (i=1;i<array.Length;i++)
    {
        if (array[i]>max)
            max=array[i];
        if (array[i]<min)
            min=array[i];
    }
    diff=max-min;
    return diff;
}