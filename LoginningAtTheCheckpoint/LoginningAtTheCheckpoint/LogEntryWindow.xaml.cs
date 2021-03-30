using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LoggingAtTheCheckpoint.Model;

namespace LoggingAtTheCheckpoint
{
    /// <summary>
    /// 
    /// 
    /// </summary>
    public partial class LogEntryWindow : Window
    {
        public LogEntryWindow()
        {
            InitializeComponent();
            Hide_fields();
            Save.Visibility = Visibility.Collapsed;
            RecordNumber.Text = Visitors.RecorderNumber.ToString();
        }

        private void LogginingButton_Click(object sender, RoutedEventArgs e) // Обработка нажатия кнопки "Создать запись"
        {
            Show_fields();
            Logging.IsEnabled = false;
            Save.Visibility = Visibility.Visible;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) // Обработка нажатия кнопки "Сохранить"
        {
            try
            {
                Visitor visitor = new Visitor(
                    Visitors.RecorderNumber,
                    EntryDate.Text,
                    Name.Text,
                    Surname.Text,
                    Patronymic.Text,
                    Document.Text,
                    Workshop.Text
                    );
                Visitors.visitors.Add(visitor);
                Hide_fields();
                Save.Visibility = Visibility.Collapsed;
                Logging.IsEnabled = true;
                Visitors.RecorderNumber++;
                RecordNumber.Text = Visitors.RecorderNumber.ToString();
            }
            catch (ArgumentNullException) { }
            catch (ArgumentOutOfRangeException) { }
        }
        void Hide_fields()      //Скрыть поля
        {
            RecordNumbertext.Visibility = Visibility.Collapsed;
            RecordNumber.Visibility = Visibility.Collapsed;
            TextDate.Visibility = Visibility.Collapsed;
            EntryDate.Visibility = Visibility.Collapsed;
            NameText.Visibility = Visibility.Collapsed;
            Name.Visibility = Visibility.Collapsed;
            SurnameText.Visibility = Visibility.Collapsed;
            Surname.Visibility = Visibility.Collapsed;
            PatronymicText.Visibility = Visibility.Collapsed;
            Patronymic.Visibility = Visibility.Collapsed;
            DocumentText.Visibility = Visibility.Collapsed;
            Document.Visibility = Visibility.Collapsed;
            WorkshopText.Visibility = Visibility.Collapsed;
            Workshop.Visibility = Visibility.Collapsed;
        }
        void Show_fields()      //Показать элементы и очистить поля ввода данных
        {
            RecordNumbertext.Visibility = Visibility.Visible;
            RecordNumber.Visibility = Visibility.Visible;
            TextDate.Visibility = Visibility.Visible;
            EntryDate.Visibility = Visibility.Visible;
            EntryDate.Text = "";
            NameText.Visibility = Visibility.Visible;
            Name.Visibility = Visibility.Visible;
            Name.Text = "";
            SurnameText.Visibility = Visibility.Visible;
            Surname.Visibility = Visibility.Visible;
            Surname.Text = "";
            PatronymicText.Visibility = Visibility.Visible;
            Patronymic.Visibility = Visibility.Visible;
            Patronymic.Text = "";
            DocumentText.Visibility = Visibility.Visible;
            Document.Visibility = Visibility.Visible;
            Document.Text = "";
            WorkshopText.Visibility = Visibility.Visible;
            Workshop.Visibility = Visibility.Visible;
            Workshop.Text = "";
        }
    }
}
