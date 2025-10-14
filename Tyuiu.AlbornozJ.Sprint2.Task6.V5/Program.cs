using Tyuiu.AlbornozJ.Sprint2.Task6.V5.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("*******************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:           *");
Console.WriteLine("*******************************");

Console.WriteLine("Введите номер карты (6-14): ");
int numCard = Convert.ToInt32(Console.ReadLine());

string res;

if ((numCard < 6) || (numCard > 14))
{
    res = "Введено неверное значение!";
}
else
{
    res = "Это карта: " + ds.FindCardValue(numCard);
}

Console.WriteLine("*******************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                 *");
Console.WriteLine("*******************************");

Console.WriteLine(res);

Console.ReadKey();
