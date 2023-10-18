/*24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/


/*Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
int summ = 0;

for (int i = 0; i < a; i++)
{
    summ = summ + i;
}
System.Console.WriteLine(summ);
*/

Console.WriteLine("Введите число a: ");
int usera = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
    int summ = 0;

    for (int i = 0; i <= a; i++)
    {
        summ = summ + i;
    }
    return summ;
}
int userResult = Num(usera);
System.Console.WriteLine(userResult);
