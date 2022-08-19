 double [] array = new double[7];

    FillDoubArray(array);
    PrintDoubArray(array);    
    MaxMin(array);
        
        
void MaxMin(double[] array)
{
    double max = array[0];
    double min = max;
    double result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
        if(array[i]<min) min= array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Максимальный Элемент = |{Math.Round(max,1)}| ; минимальный элемент = |{Math.Round(min,1)}|");
    
    
    Console.WriteLine("найдем разницу между Max и Min");
        result = Math.Round(max,1) - Math.Round(min,1);
        Console.WriteLine($"Разница  |{Math.Round(max,1)}| и |{Math.Round(min,1)}| = " + Math.Round(result,1));

}
void FillDoubArray(double[] array)
{
     double min = Math.Round(array[0],1);
 double max = Math.Round(array[0],1);
 
 Random random = new Random();
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * 20;
                
            }
}
void PrintDoubArray(double[] array)
{
    Console.WriteLine("Выведем полученный массив: ");
        for (int i = 1; i < array.Length; i++)
        {
             Console.Write($"|{Math.Round(array[i],1)}|" + "  ");
        }
}
