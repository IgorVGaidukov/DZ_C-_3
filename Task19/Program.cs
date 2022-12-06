// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num = 0;
while (num<10000 ^ num>=100000)
{
Console.WriteLine("Введите пятизначное число:");
num = Convert.ToInt32(Console.ReadLine());
}

int i = 0;
bool pal_fl = true;

while (i<=5 && pal_fl)
    {
        Console.WriteLine($"{num/Convert.ToInt32(Math.Pow(10,4-i))} - {num%10}");
        if (num%10 != num/Convert.ToInt32(Math.Pow(10,4-i))) pal_fl = false;
        i++;
    }


if (pal_fl) 
    Console.WriteLine($"Число {num} - палиндром");
else 
    Console.WriteLine($"Число {num} - не палиндром");