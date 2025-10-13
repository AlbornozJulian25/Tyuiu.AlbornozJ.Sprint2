using Tyuiu.AlbornozJ.Sprint2.Task4.V3.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("******************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:          *");
Console.WriteLine("******************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
double y = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x, y);

Console.WriteLine("******************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                *");
Console.WriteLine("******************************");

Console.WriteLine("Значение функции = " + res);

Console.ReadKey();