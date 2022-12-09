/* Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


//--------------------------------вариант 1---------------------------------------------------//

bool isPalindrome(string number1)
{
    for (int i = 0; i < number1.Length / 2; i++)
    {
        if (number1[i] != number1[number1.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

Console.Write("Введите пятизначное число: ");
String? number1 = Console.ReadLine()!;   //читаем введённое число. Знаки ? и ! добавлены для устранения предупреждения CS8600: Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL, и CS8602: Разыменование вероятной пустой ссылки.

if (number1.Length == 5)
{
    Console.Write("{0} -> {1}", number1, isPalindrome(number1) ? "да" : "нет");
}
else
{
    Console.WriteLine("Введёное число не пятизначное!");
}


//-----------------------или вариант 2----------------------------//

/*
Console.Write("Введите пятизначное число: ");
String? number1 = Console.ReadLine()!;   //читаем введённое число. Знаки ? и ! добавлены для устранения предупреждения CS8600: Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL, и CS8602: Разыменование вероятной пустой ссылки.
int a = Convert.ToInt32(number1.Length - 1);
bool palindrome = true;

if (number1.Length == 5)
{
    for (int i = 0; i < a; i++)
    {
        if (number1[i] != number1[a - i])
        {
            palindrome = false;
        }
    }

    if (palindrome == true)
    {
        Console.Write(number1 + " -> да");
    }
    else
    {
        Console.Write(number1 + " -> нет");
    }

}
else
{
    Console.WriteLine("Введёное число не пятизначное!");
}

*/