/* Задача 3: Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
3 -> [1, 8, 27]
5 -> [1, 8, 27, 64, 125]

*/


//----------------------------------вариант 1-----------------------------------------//


void PrintCubic(int Num)
{
    int[] array = new int[Num];
    Console.Write("[");
    for (int i = 1; i <= array.Length; i++)
    {
        Console.Write($"{(Math.Pow(i, 3) + ", ")}");
    }
    Console.Write("]");
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N + " -> ");
PrintCubic(N);



//----------------------------------вариант 2------------------------------------------//
/*
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N + " -> ");
for (int i = 1; i <= N; i++)
{
    Console.Write($"{(Math.Pow(i, 3) + ", ")}");
}
*/



//----------------------------------вариант 3------------------------------------------//
/*
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N + " -> ");
for (int i = 1; i <= N; i++)
{
    Console.Write($"{(i*i*i + ", ")}");
}
*/