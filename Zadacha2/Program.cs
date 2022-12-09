/* Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

//-------------------------------------вариант 1----------------------------------------------------------//

void koordinatyRaschet(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.Write("A (" + x1 + "," + y1 + "," + z1 + "); B (" + x2 + "," + y2 + "," + z2 + ") -> " + d);
    return;
}

Console.Write("Введите координату x1 точки A: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1 точки A: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1 точки A: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2 точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2 точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2 точки B: ");
double z2 = Convert.ToDouble(Console.ReadLine());

koordinatyRaschet(x1, y1, z1, x2, y2, z2);


//----------------------------------------вариант 2-----------------------------------------------------------//

/*
double KoordinatyName(string korName, string pointName)
{
    Console.Write($"Введите координату {korName} точки {pointName}: ");
    return Convert.ToDouble(Console.ReadLine());
}

double x1 = KoordinatyName("x", "A");
double y1 = KoordinatyName("y", "A");
double z1 = KoordinatyName("z", "A");
double x2 = KoordinatyName("x", "B");
double y2 = KoordinatyName("y", "B");
double z2 = KoordinatyName("z", "B");

koordinatyRaschet(x1, y1, z1, x2, y2, z2);

*/