void Cube()
{
Console.WriteLine("Vvedite N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (int i = 1; i <= N; i++)
{
     Console.WriteLine(i*i*i);
}
}
Cube();