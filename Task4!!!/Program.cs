Console.Clear();

Console.WriteLine("Введите числа");
int a = Convert.ToInt32(Console. ReadLine ());
int max = a;
int max2 = a;
while (a != 0)
{
a = Convert. ToInt32(Console. ReadLine ());
if (a > max ) 
{
max2 = max;
max = a;
}
else if ( a > max2 && a <max)
{
    max2 = a;
}
}
Console.WriteLine ($"end");

Console.WriteLine($"Второе максимальное число {max2}");
