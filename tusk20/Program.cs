/*Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

System.Console.WriteLine("Введите координаты точки a(x,y): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки b(x,y): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());

//int squereX = (userBx - userAx) * (userBx - userAx)
double squereX = Math.Pow(userBx - userAx, 2);
double squereY = Math.Pow(userBy - userAy, 2);
double rootXY = Math.Sqrt(squereX + squereY);

System.Console.WriteLine(Math.Round(rootXY, 2));