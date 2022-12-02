Console.Clear();

Console.WriteLine ("Введите день недели от 1 до 7: ");

int n = Convert.ToInt32(Console.ReadLine());

if ( n >= 1 && n <= 5)
{
    Console.WriteLine ("Будний день");
}
else if (n == 6 | n == 7)
{
Console.WriteLine ("Выходной");
}
else if ( n > 7 || n < 1)
{
Console.WriteLine ("Такого дня не существует");
}