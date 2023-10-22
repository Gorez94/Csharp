/*Задача 27: Напишите программу, которая принимает
 на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


Console.WriteLine("Введите число a: ");
int usera = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
    int summ = 0;

    for (int i = a; i > 0; i /= 10)
    {
        summ = summ % 10 + i;
    }
    return summ;
}
int userResult = Num(usera);
System.Console.WriteLine(userResult);