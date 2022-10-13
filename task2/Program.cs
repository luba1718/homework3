//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


var xa = int.Parse(Console.ReadLine()); 
int ya = int.Parse(Console.ReadLine()); 
int za = int.Parse(Console.ReadLine());
int xb = int.Parse(Console.ReadLine()); 
int yb = int.Parse(Console.ReadLine()); 
int zb = int.Parse(Console.ReadLine()); 

int A = xb - xa; 
int B = yb - ya; 
int C = zb - za;

double distance = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {distance}");
