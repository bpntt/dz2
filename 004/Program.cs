Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <100)
{
    Console.WriteLine("no");
    return;
}
if ( number < 1000)
{
int a = number  % 10 ;
Console.WriteLine($"{a}");
return;
}
if (number < 10000 )
{
    int b = number / 100 % 10 ;
Console.WriteLine($"{b}"); 
return;
}