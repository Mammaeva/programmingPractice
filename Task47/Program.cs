void Task47()
{   
    Random rand = new Random();
    int rows = rand.Next(4,4);
    int columns = rand.Next(4,4);
    double [,] array = new double [rows,columns];
    FillDoubArray(array);
    PrintDoubArray(array);

    void FillDoubArray(double [,] array, int StartNums = 0, int FinishNums = 9)
    {
        Random rand = new Random();
        FinishNums++; 
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i,j] = rand.NextDouble() *5;
                }
            }
    }

    void PrintDoubArray(double [,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(Math.Round(array[i,j],1) + "\t");
                }
                Console.WriteLine();
            }

    }
}

Task47();