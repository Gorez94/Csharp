/*Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число
 number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.
*/


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int reverse = number.Length;
if (reverse == 5)
{
    if (number(0) == number(4) && number(1) == number(3))
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"{number} - не является пятизначным");
}