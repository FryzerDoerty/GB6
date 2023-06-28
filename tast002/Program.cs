// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double b1 = FuncEnt("Введите число");
double b2 = FuncEnt("Введите число");
double k1 = FuncEnt("Введите число");
double k2 = FuncEnt("Введите число");
double[] xy = Peres(b1, b2, k1, k2);
System.Console.WriteLine("(" + string.Join("; ", xy) + ")");

double[] Peres(double b1, double b2, double k1, double k2)
{
    double[] arr = new double[2];
    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = k2 * arr[0] + b2;
    return arr;
}

double FuncEnt(string text)
{
    Console.WriteLine(text);
    double zn = Convert.ToInt32(System.Console.ReadLine());
    return zn;
}
