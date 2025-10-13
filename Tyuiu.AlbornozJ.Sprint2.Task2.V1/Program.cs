using Tyuiu.AlbornozJ.Sprint2.Task2.V1.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("**************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:      *");
Console.WriteLine("**************************");

Console.WriteLine("Введите значение переменной X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
int y = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();

bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("**************************");
Console.WriteLine("* РЕЗУЛЬТАТ:            *");
Console.WriteLine("**************************");
if (res)
{
    Console.WriteLine("Точка находиться в заштрихованной области!");
}
else
{
    Console.WriteLine("Точка не находиться в заштрихованной области");
}

Console.ReadKey();
