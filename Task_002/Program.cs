// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Random rand = new Random();

int[] array_crt()
{
    int[] a = new int[3];
    for (int i = 0; i < 3; i++)
    {
        a[i] = rand.Next(100, 1000);
    }
    return a;
}

int count2(int[] array)
{
    int c = 0;
    for (int i = 0; i < 3; i++)
    {
        if (array[i] % 2 == 0)
        {
            c += 1;
        }
    }
    return c;
}

int[] c= array_crt();
Console.WriteLine(string.Join(" ", c));
Console.WriteLine(count2(c));