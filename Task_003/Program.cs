// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

Random rand = new Random();

int[] array_crt(int len)
{

    int[] a = new int[len];
    for (int i = 0; i < len; i++)
    {
        a[i] = rand.Next(100, 1000);
    }
    return a;
}

int[] ch_array(int[] array, int len)
{
    for (int i = 0; i < len / 2; i++)
    {
        int pom = array[i];
        array[i] = array[(len - 1) - i];
        array[(len - 1) - i] = pom;
    }
    return array;
}

int l = rand.Next(0, 20);
int[] c = array_crt(l);
Console.WriteLine(string.Join(" ", c));
Console.WriteLine(string.Join(" ", ch_array(c, l)));