// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if(num < 10000 && num > 99999)
{
    Console.WriteLine("Это не пятизначное число, пожалуйста, повторите ввод");
    return;
}

int a = num % 10;
int b = num / 10 % 10;
int c = num / 1000 % 10;
int d = num / 10000 % 10;

if (a == d && b == c)
{
    Console.WriteLine("число является палиндромом");
}
else
{
    Console.WriteLine("число не является палиндромом");
}