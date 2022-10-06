
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Write("Введите размер массива: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());

double[] array = new double[sizeOfArray];

Random random = new Random();
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-1000, 1000);

}
double MaxElementArray(double[] array)
{   
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinElementArray(double[] array)
{   
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.WriteLine("[{0}]", string.Join(", ", array));

double MaxNumber = MaxElementArray(array);
Console.WriteLine($"Максимальное число массива: {MaxNumber}");
double MinNumber = MinElementArray(array);
Console.WriteLine($"Минимальное число массива: {MinNumber}");

Console.WriteLine($"Разница составляет: {MaxNumber - (MinNumber)}");
}