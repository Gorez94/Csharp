/*Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек
 pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
*/


System.Console.WriteLine("Введите координаты точки a(x,y): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
int userAz = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки b(x,y): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
int userBz = Convert.ToInt32(Console.ReadLine());

//int squereX = (userBx - userAx) * (userBx - userAx)
double squereX = Math.Pow(userBx - userAx, 2);
double squereY = Math.Pow(userBy - userAy, 2);
double squereZ = Math.Pow(userBz - userAz, 2);
double rootXYZ = Math.Sqrt(squereX + squereY + squereZ);

System.Console.WriteLine(Math.Round(rootXYZ, 2));