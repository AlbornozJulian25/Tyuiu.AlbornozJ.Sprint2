
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AlbornozJ.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int value)
        {
            switch (value)
            {
                case 6: return "шестерка";
                case 7: return "семерка";
                case 8: return "восьмерка";
                case 9: return "девятка";
                case 10: return "десятка";
                case 11: return "валет";
                case 12: return "дама";
                case 13: return "король";
                case 14: return "туз";
                default: throw new ArgumentException($"Номер карты должен быть от 6 до 14. Значение: {value}");
            }
        }
    }
}
