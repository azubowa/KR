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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoggingAtTheCheckpoint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogEntryButton_Click(object sender, RoutedEventArgs e)     // Обработка кнопки "Записать в журнал"
        {
            LogEntryWindow lew = new LogEntryWindow();
            lew.Show();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)       // Обработка кнопки "Поиск прошедших"
        {
            SearchWindow sw = new SearchWindow();
            sw.Show();
        }
    }
}
