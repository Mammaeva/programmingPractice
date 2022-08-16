Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
for (int i = 1; i < b; i++)
    result = result * a;
Console.WriteLine(a + " в степени " + b + " = " + result);
