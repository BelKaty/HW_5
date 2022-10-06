// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[sizeOfArray];

void FindevenArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
}

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество четных чисел в массиве = {count}");
}
FindevenArray(array);