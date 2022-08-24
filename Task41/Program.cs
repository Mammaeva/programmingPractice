void Task41 ()
{
    Console.WriteLine("Сколько чисел хотите ввести:  ");
    int M = Convert.ToInt32(Console.ReadLine());
   int [] array = new int [M];
   int count = 0;

    Console.WriteLine("введите числа:  ");

   for (int i = 0; i < M; i++)
   {
       array[i]= Convert.ToInt32(Console.ReadLine()); 
       if(array[i]> 0) count ++;
    
   }
        Console.WriteLine();
        Console.WriteLine($"Пользователь ввел {count} положительных чисел");
}

Task41();


