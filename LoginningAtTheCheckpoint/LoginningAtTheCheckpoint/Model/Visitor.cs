using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LoggingAtTheCheckpoint.Model
{
    public class Visitor        //Класс хранит данные о проходящих через проходную завода
    {
        public int RecordNumber { get; set; }
        public string _date { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Document { get; set; }
        public string Workshop { get; set; }

        public Visitor(         // Конструктор объекта, вызвающий функции проверки параметров класса
            int recordnumber,
            string date,
            string name,
            string surname,
            string patronymic,
            string document,
            string workshop
            )
        {
            RecordNumber = recordnumber;
            DateVisit(date);
            SNP(name, surname, patronymic);
            DocumentWorkshop(document, workshop);
        }
        public void DocumentWorkshop (string document, string workshop)     //Проверка корректности введенных данных о документе и номере цеха
        {
            if (document.Length == 0)
            {
                MessageBox.Show("Введите документ проходящего", "Ошибка ввода");
                throw new ArgumentNullException();
            }
            if (workshop.Length == 0)
            {
                MessageBox.Show("Введите название цеха", "Ошибка ввода");
                throw new ArgumentNullException();
            }
            Document = document;
            Workshop = workshop;
        }

        public void SNP(string name, string surname, string patronymic)     // Проверка корректности введенных данных о фамилии, имени, отчестве проходящего
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Введите имя", "Ошибка ввода");
                throw new ArgumentNullException();
            }
            if (surname.Length == 0)
            {
                MessageBox.Show("Введите фамилию", "Ошибка ввода");
                throw new ArgumentNullException();
            }
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }
        public void DateVisit(string date)  //Проверка корректности введения даты
        {
            if (date.Length != 0)
            {
                Date check = new Date(date);
                check.CheckDate(Visitors.visitors);
                _date = date;
            }
            else
            {
                MessageBox.Show("Введите дату", "Ошибка ввода");
                throw new ArgumentNullException();
            }
        }
    }
}

