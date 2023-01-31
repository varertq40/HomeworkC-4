// Задача 25: Напишите функуцию, которая принимает на 
// вход два числоа (А и В) и возводит число А в 
// натуральную степень В.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int B = int.Parse(Console.ReadLine()!);

int Geek(int A, int B)
{
    int count = 1;
    for(int i = 1; i <= B; i++)
    {
        count = count * A; 
    }
    return count;
}

int ReadConsol(string h)
{
    Console.Write(h);
    return int.Parse(Console.ReadLine()!);
}
int sum = Geek(A, B);
Console.Write(sum);


// int GetSum(int A) 
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i;
        
//     }

//     return sum;
// }

// int n = int.Parse(Console.ReadLine()!);
// int sum = GetSum(n);
// Console.WriteLine($"{sum}");
