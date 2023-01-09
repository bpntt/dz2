Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
 int d1 = number / 100;
 int d2 = number /10 % 10;
 int d3 = number % 10;
 Console.WriteLine($" Второе чило {d2}");