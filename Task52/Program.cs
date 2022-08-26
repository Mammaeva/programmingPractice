void Task52()
{
    Random rand = new Random();
    int rows = rand.Next(4,4);
    int columns = rand.Next(3,4);
    int [,] array = new int [rows,columns];
    FillArray(array,1,10);
    PrintArray(array);
    double sum = 0;
    double avg = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {   
            sum+=array[i,j];
            avg=sum/array.GetLength(0);
         
        }   sum*=0;
            Console.WriteLine($"Среднее арифметическое в столбцах равно " + Math.Round(avg,2));
    }
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
Task52();