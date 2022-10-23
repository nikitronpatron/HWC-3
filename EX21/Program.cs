// На вход: координаты двух точек (x, y, z)
// На выход: расстояние между ними

double FindInterval (int aX, int aY, int aZ, int bX, int bY, int bZ)
{
    double interval = Math.Sqrt((bX - aX) * (bX - aX) + (bY - aY) * (bY - aY) + (bZ - aZ) * (bZ - aZ));
    return interval;
}
Console.WriteLine("Enter coordinates of the point A: ");
int aX = Convert.ToInt32(Console.ReadLine());
int aY = Convert.ToInt32(Console.ReadLine());
int aZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinates of the point B: ");
int bX = Convert.ToInt32(Console.ReadLine());
int bY = Convert.ToInt32(Console.ReadLine());
int bZ = Convert.ToInt32(Console.ReadLine());
double interval = FindInterval(aX, aY, aZ, bX, bY, bZ);
Console.WriteLine($"interval between points equal {interval}");