using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// </summary>
    public partial class SearchWindow : Window
    {
        public SearchWindow()
        {
            InitializeComponent();
            SearchPersonText.Visibility = Visibility.Collapsed;
            SearchPerson.Visibility = Visibility.Collapsed;
            SearchButton.Visibility = Visibility.Collapsed;
            Cancel.Visibility = Visibility.Collapsed;
        }

        private void SearchPerson_Click(object sender, RoutedEventArgs e)       // Обработка кнопки "Вывод по ФИО"
        {
            SearchPersonText.Visibility = Visibility.Visible;
            SearchPerson.Visibility = Visibility.Visible;
            SearchButton.Visibility = Visibility.Visible;
            Cancel.Visibility = Visibility.Visible;
            SearchPersonButton.IsEnabled = false;
            SearchAllButton.IsEnabled = false;
        }

        private void SearchAllButton_Click(object sender, RoutedEventArgs e)        // Обработка кнопки "Вывод всех"
        {
            ObservableCollection<Visitor> collection = new ObservableCollection<Visitor>();
            Table.ItemsSource = collection;
            foreach (var visitor in Visitors.visitors)
            {
                collection.Add(visitor);
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)       // Обработка кнопки "Найти"
        {
            try
            {
                ObservableCollection<Visitor> collection = new ObservableCollection<Visitor>();
                Table.ItemsSource = collection;
                Initials initials = new Initials(SearchPerson.Text);
                foreach (var visitor in Visitors.visitors)
                {
                    if (initials.SearchInitials(visitor))
                    {
                        collection.Add(visitor);
                    }
                }
                SearchPersonText.Visibility = Visibility.Collapsed;
                SearchPerson.Visibility = Visibility.Collapsed;
                SearchButton.Visibility = Visibility.Collapsed;
                Cancel.Visibility = Visibility.Collapsed;
                SearchPersonButton.IsEnabled = true;
                SearchAllButton.IsEnabled = true;
            }
            catch (ArgumentNullException) { }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)       // Обработка кнопки "Отмена"
        {
            SearchPersonText.Visibility = Visibility.Collapsed;
            SearchPerson.Visibility = Visibility.Collapsed;
            SearchButton.Visibility = Visibility.Collapsed;
            Cancel.Visibility = Visibility.Collapsed;
            SearchPersonButton.IsEnabled = true;
            SearchAllButton.IsEnabled = true;
        }
    }
}
