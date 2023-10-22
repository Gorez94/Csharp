/*Задача 25: Напишите цикл, который принимает на вход два числа
 (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите число a: ");
int usera = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b: ");
int userb = Convert.ToInt32(Console.ReadLine());
void Natur(int a, int b)
{
    int result = 1;

    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    System.Console.WriteLine(result);;
}
Natur(usera, userb);