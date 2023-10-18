/*28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/


Console.WriteLine("Введите число a: ");
int usera = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
    int result = 1;
    for (int i = 1; i <= a; i++)
    {
        result = result * i;
    }
    return result;
}
int userResult = Num(usera);
System.Console.WriteLine(userResult);