Console.WriteLine("Введите первое число");

int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

int n2 = int.Parse(Console.ReadLine());

int pow = Convert.ToInt32(Math.Pow(n2, 2));

if (n1 == pow) 
{
    Console.WriteLine($"число {n1} является квадратом числа {n2}");
}
    else


Console.WriteLine($"число {n1} не является квадратом числа {n2}");