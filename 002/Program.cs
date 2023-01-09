int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное чило из диапазона 100 - 999 => {number}");
//int fd = number / 10;
//int sd = number % 10;  
//int result = fd > sd ? fd : sd;
//Console.Write("Больше из чисел пары = ");
//Console.WriteLine(fd > sd ? fd : sd);
int md = maxd(number);
Console.Write($"Больше из чисел пары = {md} ");
int maxd(int num)
{
    int fd = num / 10;
    int sd = num % 10;  
    int result = fd > sd ? fd : sd;
    //return result ;
    // return возвращает нужное значение 
     return  fd > sd ? fd : sd;
} 
// при наличии глобальных переменных "метод" теряет смысл"
int maxd1 = maxd(99);
Console.WriteLine($"{maxd1}");

int maxd2 = maxd(14);
Console.WriteLine($"{maxd2}");
// осознал метод позволяет пользоваться одним алгоритном по ходу всего кода