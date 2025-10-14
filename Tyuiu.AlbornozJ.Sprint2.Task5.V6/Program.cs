using Tyuiu.AlbornozJ.Sprint2.Task5.V6.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("********************************************************");
Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                     *");
Console.WriteLine("********************************************************");

Console.WriteLine("Введите масть карты (1-4): ");
int suit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите достоинство карты (6-14): ");
int value = Convert.ToInt32(Console.ReadLine());

string res;


if (suit < 1 || suit > 4)
{
    res = $"Ошибка: Масть карты должна быть от 1 до 4. Введено: {suit}";
}
else if (value < 6 || value > 14)
{
    res = $"Ошибка: Достоинство карты должно быть от 6 до 14. Введено: {value}";
}
else
{
   
    res = "Это карта: " + ds.FindCardNameAndValue(suit, value);
}


Console.WriteLine("********************************************************");
Console.WriteLine("# РЕЗУЛЬТАТ:                                           *");
Console.WriteLine("********************************************************");

Console.WriteLine(res);
Console.ReadKey();
