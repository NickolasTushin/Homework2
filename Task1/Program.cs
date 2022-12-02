Console.Clear();

Console.WriteLine("Введите трехзначное число: ");

int x = Convert.ToInt32(Console.ReadLine());
int x1 = x / 10 % 10; // решение


// Поиск остальных чисел 
int x2 = x / 100;
int x3 = x % 10;
Console.WriteLine(x1);