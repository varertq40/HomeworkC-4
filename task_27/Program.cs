// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Sum(string[] args)
{
    Console.WriteLine("Введите число");
    int b = int.Parse(Console.ReadLine()!);
    int summa = 0;
    int temp = 0;
    {
        while (b > 0)
        {
            temp = b % 10;
            summa = summa + temp;
            b = b / 10;
        }
        Console.WriteLine(summa);
    }
}

Sum(args);