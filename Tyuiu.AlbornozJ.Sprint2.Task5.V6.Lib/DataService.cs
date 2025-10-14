
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AlbornozJ.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value, int suit)
        {
            string cardValue;
            string cardSuit;

            
            switch (value)
            {
                case 6:
                    cardValue = "Шестерка";
                    break;
                case 7:
                    cardValue = "Семерка";
                    break;
                case 8:
                    cardValue = "Восьмерка";
                    break;
                case 9:
                    cardValue = "Девятка";
                    break;
                case 10:
                    cardValue = "Десятка";
                    break;
                case 11:
                    cardValue = "Валет";
                    break;
                case 12:
                    cardValue = "Дама";
                    break;
                case 13:
                    cardValue = "Король";
                    break;
                case 14:
                    cardValue = "Туз";
                    break;
                default:
                    throw new ArgumentException($"Достоинство карты должно быть от 6 до 14. Значение: {value}");
            }

            
            switch (suit)
            {
                case 1:
                    cardSuit = "пик";
                    break;
                case 2:
                    cardSuit = "треф";
                    break;
                case 3:
                    cardSuit = "бубен";
                    break;
                case 4:
                    cardSuit = "червей";
                    break;
                default:
                    throw new ArgumentException($"Масть карты должна быть от 1 до 4. Значение: {suit}");
            }

            return $"{cardValue} {cardSuit}";
        }
    }
}
