using Tyuiu.AlbornozJ.Sprint2.Task1.V25.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

int a = 247;
int b = 155;
int c = 325;
int d = 857;

bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("*******************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:           *");
Console.WriteLine("*******************************");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);

Console.WriteLine("*******************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                 *");
Console.WriteLine("*******************************");

for (int i = 0; i < 6; i++)
    Console.WriteLine(res[i]);

Console.ReadKey();