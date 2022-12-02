Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x >= 100 && x <= 999)
    { 
    int x2 = x / 100;
    int x3 = x % 10;
    int x1 = x / 10 % 10; // решение
    Console.WriteLine(x1);
    } 
else  
    {
        Console.WriteLine ("Число не трехзначное");
    }