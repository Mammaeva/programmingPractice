void Distance_3D()
{
Console.WriteLine("Введите координаты точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В: ");
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());

double Distance = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2));
Console.WriteLine(Math.Round(Distance,2));
}

Distance_3D();
