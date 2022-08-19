void Task36()
{
   int [] array = new int [10];
   FillArray(array, 10, 98);
   PrintArray(array);
   Odd(array);
}



void FillArray(int [] array, int StartNum = -10, int FinishNum = 10)
{
    FinishNum++;
    Random random = new Random();
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(StartNum,FinishNum);

            }
}
void PrintArray(int [] array)
{   
         for (int i = 0;i < array.Length; i++)
            {
                    Console.Write(array[i] + "  ");
            }
        Console.WriteLine();
}
void Odd(int [] array)
{
    int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if(i%2 == 0) count += array[i];
            }
    Console.WriteLine("сумма элементов, стоящих на нечётных позициях = " + count);
}


Task36();