int[] array = new int[8];
int i = 0;
while (i < 8)
{
    Console.Write("Введите в общей сложности восемь чисел: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
