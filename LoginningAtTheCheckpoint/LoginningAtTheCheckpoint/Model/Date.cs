using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LoggingAtTheCheckpoint.Model
{
    public class Date   //Класс предназначен для обрабоки Ввода даты
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public Date(string date) 
        {
            string[] _date = date.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);     //Получение данных даты
            Day = int.Parse(_date[0]);      //Сохранение в переменных класса
            Month = int.Parse(_date[1]);
            Year = int.Parse(_date[2]);
        }
        public void CheckDate(List<Visitor> visitors)       //Функция проверяет корректность полученной даты (дата не может быть меньше предыдущих проходящих)
        {
            foreach (var visitor in visitors)
            {
                Date date = new Date(visitor._date);
                if (Year >= date.Year)
                {
                    if (Month > date.Month)
                    {
                        continue;
                    }
                    else if (Month == date.Month)
                    {
                        if (Day >= date.Day)
                            continue;
                        else ErrorMessage();
                    }
                    else ErrorMessage();
                }
                else ErrorMessage();
            }
        }
        public void ErrorMessage()
        {
            MessageBox.Show("Текущая дата не может быть установлена, т.к. ранее были установлены более поздние даты", "Ошибка выбора даты");
            throw new ArgumentOutOfRangeException();
        }
    }
}
