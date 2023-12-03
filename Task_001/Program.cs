// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

bool ch_2(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
        //Console.WriteLine(number + " " + sum);
    }
    if (sum % 2 == 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

bool t = true;
while (t == true)
{
    Console.WriteLine("Ожидание ввода...");
    string a = System.Console.ReadLine() + "";
    if (a == "q")
    {
        t = false;
    }
    else
    {
        //Console.WriteLine("!");
        int numb = Convert.ToInt32(a);
        t = ch_2(numb);

    }
}