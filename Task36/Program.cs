//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Write("Введите размер массива: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[sizeOfArray];

void FindEvenElementArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000, 1000);
}

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        count = count + array[i];
    }
}

Console.WriteLine($"Сумма элементов на четных позициях массива = {count}");
}
FindEvenElementArray(array);