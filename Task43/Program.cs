void Task43()
{
    Console.WriteLine("Введите значение b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());
    if(k1==k2) Console.WriteLine("Прямые параллельны");
    else 
    {
        double x= (b2 - b1) / (k1 - k2);
        double y  = k2 * x + b2;
        Console.WriteLine($"Точка пересечения двух прямых ({Math.Round(x,2)} ; {Math.Round(y,2)})");
    }

}
Task43();