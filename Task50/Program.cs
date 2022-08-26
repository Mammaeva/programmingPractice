void Task50()
{    
    Random rand = new Random();
    int rows = rand.Next(4,4);
    int columns = rand.Next(3,4);
    int [,] array = new int [rows,columns];
    FillArray(array,1,10);
    PrintArray(array);
    FindNum(array);
}
void FindNum(int[,] array)
{    
    Console.WriteLine("введите индекс строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите индекс столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int find = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                if (m ==i+1 && n == j+1)   find =   array[i,j];
                if (m >i +1 && n > j)Console.WriteLine("Такого элемента нет");
        }
    }
        Console.WriteLine($"Число {find} есть в массиве");
}
void FillArray(int [,] array, int StartNums = 0, int FinishNums = 9)
{
    Random rand = new Random();
    FinishNums++; 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i,j] = rand.Next(StartNums,FinishNums);
            }
        }
}
void PrintArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                 Console.Write(array[i,j] + "\t");
            }
             Console.WriteLine();
        }
}
Task50();