Console.WriteLine("Введите координаты точки A: ");
double a1 = Convert.ToDouble(Console.ReadLine());
double a2 = Convert.ToDouble(Console.ReadLine());
double a3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double b3 = Convert.ToDouble(Console.ReadLine());
double s;


s = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2) + Math.Pow(b3 - a3, 2));
Console.WriteLine("Расстояние: " + s);
