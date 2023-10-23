/*40. Напишите программу, которая принимает на вход три числа и проверяет,
 может ли существовать треугольник с сторонами такой длины.a + b > c && a + c > b && b + c > a
*/

bool Check(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) return true;
   return false;
}

Console.WriteLine("Введите число a: ");
int usera = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число a: ");
int userb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число a: ");
int userc = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Check(usera, userb, userc));
