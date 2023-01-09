
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное чило из диапазона 10 - 99 => {number}");
int fd = number / 10;
int sd = number % 10; 
//if (fd > sd)
//Console.WriteLine($"Больше из чисел пары {fd}");
//else
//Console.WriteLine($"Больше из чисел пары {sd}");
// альтернативный оператор тернарный позволяет возвращать те или иные значения 
int result = fd > sd ? fd : sd;
Console.Write("Больше из чисел пары = ");
Console.WriteLine(fd > sd ? fd : sd);


