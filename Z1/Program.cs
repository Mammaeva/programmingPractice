void Polindrom()
{
    Console.WriteLine("Данная программа отпределяет, является ли введенное Вами число полиндромом.");
    Console.WriteLine("Введите пятизначное число: ");
    int N = Convert.ToInt32(Console.ReadLine()); 
    int firstnum = N/10000;
    int secondnum = N % 10000 / 1000;
    int fournum = N%100/10;
    int fivenum = N%10;
    if(N<9999) Console.WriteLine("Число слишком короткое, попробуйте снова.");
    else if (N>100000)Console.WriteLine("Число слишком велико.");
    else if(firstnum==fivenum && secondnum == fournum) 
        {
        Console.WriteLine("Ура, Вы ввели число - полиндром.");
        }
    else Console.WriteLine("Вы ввели не полиндром.");
}