/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();

// Random rnd = new Random();
// int x1 = rnd.Next(-10, 11);
// int y1 = rnd.Next(-10, 11);
// int x2 = rnd.Next(-10, 11);
// int y2 = rnd.Next(-10, 11);

// Console.WriteLine($"x1{x1},y1{y1} x2{x2},y2{y2}");

// double result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));

// Console.WriteLine(result);

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
double getDistanseFromCoordinate(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return result;
}
int x1 = getUserValue("Введите x1");
int y1 = getUserValue("Введите y1");
int x2 = getUserValue("Введите x2");
int y2 = getUserValue("Введите y2");

double distanse = getDistanseFromCoordinate(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками = {distanse}");