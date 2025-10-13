using Tyuiu.AlbornozJ.Sprint2.Task3.V10.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("*******************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:           *");
Console.WriteLine("*******************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());
double res = ds.Calculate(x);

Console.WriteLine("*******************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                 *");
Console.WriteLine("*******************************");

Console.WriteLine("Значение функции = " + res);

Console.ReadKey();