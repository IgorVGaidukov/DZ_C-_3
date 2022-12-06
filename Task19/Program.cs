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

int temp_num = num; // Временное число, получаемое отбрасыванием крайних цифр
int num_length = 5; // Количество знаков числа temp_num
int digital1, digital2; // Первая и последняя цифра числа temp_num
bool pal_fl = true; // Признак палиндрома

while (num_length > 1 && pal_fl)
    {
        digital1 = temp_num/Convert.ToInt32(Math.Pow(10,num_length-1));
        digital2 = temp_num%10;

        if (temp_num%10 != temp_num/Convert.ToInt32(Math.Pow(10,num_length-1))) pal_fl = false;
        
        temp_num = (temp_num - (digital1*Convert.ToInt32(Math.Pow(10,num_length-1))))/10;
        num_length = num_length - 2;
    }

if (pal_fl) 
    Console.WriteLine($"Число {num} - палиндром");
else 
    Console.WriteLine($"Число {num} - не палиндром");