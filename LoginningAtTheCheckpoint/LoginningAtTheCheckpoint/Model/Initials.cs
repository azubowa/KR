using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LoggingAtTheCheckpoint.Model
{
    public class Initials       // данный класс необходим для поиска элементов таблицы через параметры ФИО
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int NumberOfParameters { get; set; }

        public Initials(string ini)
        {
            string[] init = ini.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);   //Получение параметров поиска
            switch (init.Length)    //Обработка числа параментров
            {
                case 0:
                    {
                        MessageBox.Show("Отсутствуют параметры поиска, повторите попытку", "Ошибка ввода");
                        throw new ArgumentNullException();
                    }
                case 1:
                    {
                        Name = init[0];
                        NumberOfParameters = 1;
                        break;
                    }
                case 2:
                    {
                        Name = init[0];
                        Surname = init[1];
                        NumberOfParameters = 2;
                        break;
                    }
                case 3:
                    {
                        Name = init[0];
                        Surname = init[1];
                        Patronymic = init[2];
                        NumberOfParameters = 3;
                        break;
                    }
            }
        }
       public bool SearchInitials(Visitor visitor)
        {
            switch (NumberOfParameters)     //Поиск по количеству введенных параметров в строку поиска
            {
                case 1:     //Перебор различных позиций фамилии, имени и отчества с условием ввода одного параметра (Например: Иванов)
                    {
                        if (Name == visitor.Name ||
                            Name == visitor.Surname ||
                            Name == visitor.Patronymic
                            )
                            return true;
                        else return false;
                    }
                case 2:     //Перебор различных позиций фамилии, имени и отчества с условием ввода двух параметров (Например: Иванов Иван)
                    {
                        if (Name == visitor.Name && Surname == visitor.Surname ||
                            Name == visitor.Surname && Surname == visitor.Name ||
                            Name == visitor.Name && Surname == visitor.Patronymic ||
                            Name == visitor.Patronymic && Surname == visitor.Name ||
                            Name == visitor.Surname && Surname == visitor.Patronymic ||
                            Name == visitor.Patronymic && Surname == visitor.Surname
                            )
                            return true;
                        else return false;
                    }
                case 3:     //Перебор различных позиций фамилии, имени и отчества с условием ввода трех параметров (Например: Иванович Иван Иванов)
                    {
                        if (Name == visitor.Name && Surname == visitor.Surname && Patronymic == visitor.Patronymic ||
                            Name == visitor.Surname && Surname == visitor.Name && Patronymic == visitor.Patronymic ||
                            Name == visitor.Surname && Surname == visitor.Patronymic && Patronymic == visitor.Name ||
                            Name == visitor.Name && Surname == visitor.Patronymic && Patronymic == visitor.Surname ||
                            Name == visitor.Patronymic && Surname == visitor.Name && Patronymic == visitor.Surname ||
                            Name == visitor.Patronymic && Surname == visitor.Surname && Patronymic == visitor.Name
                            )
                            return true;
                        else return false;
                    }
            }
            return false;   //При числе параметров, больших 3-х поиск не даст результатов
        }
    }
}
