// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



// void Palindrom(int perem, int result, int temp, int n)
// {
//    while (n > 0)
//    {
//       temp = n % 10;
//       result = result * 10 + temp;
//       n = n / 10;
//    }
//    if (perem == result)
//    {
//       Console.WriteLine("да");
//    }
//    else
//    {
//       Console.WriteLine("нет");
//    }
// }




// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int perem = n;
// int result = 0;
// int temp = 0;

// Palindrom(perem, result, temp, n);




// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// double Rast(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//    return Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)) + (Math.Pow(z1 - z2, 2)));
// }


// Console.WriteLine("Введите Координату x1 для точки А");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y1 для точки А");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату z1 для точки Z");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату x2 для точки B");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y2 для точки B");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату z2 для точки Z");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Расстояние между двяму точками равно: {Math.Round(Rast(x1, y1, x2, y2, z1, z2), 3)}");



// Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void cub(int num_max, int num_min, double resault)
{
   while (num_min <= num_max)
   {
      resault = (Math.Pow(num_min, 3));
      Console.Write($" {resault}");
      num_min++;
   }
}




Console.WriteLine("Введите любое число:");
int num_max = Convert.ToInt32(Console.ReadLine());
int num_min = 1;
double resault = 0;

cub(num_max, num_min, resault);