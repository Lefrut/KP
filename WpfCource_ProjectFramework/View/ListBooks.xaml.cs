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

namespace WpfCource_ProjectFramework.View
{
    /// <summary>
    /// Логика взаимодействия для ListBooks.xaml
    /// </summary>
    public partial class ListBooks : Page
    {
        public ListBooks()
        {
            InitializeComponent();
            DGridBooks.ItemsSource = KPEntities.GetContext().Книги.ToList();
            DGridAvtor.ItemsSource = KPEntities.GetContext().Авторы.ToList();
            DGridAvtor.Visibility = Visibility.Hidden;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListBooksInterface(null));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selected = DGridBooks.SelectedItems.Cast<Книги>().ToList();
            try
            {
                KPEntities.GetContext().Книги.RemoveRange(selected);
                KPEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные удалены");
                DGridBooks.ItemsSource = KPEntities.GetContext().Книги.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            DGridBooks.ItemsSource = KPEntities.GetContext().Книги.ToList();
            DGridAvtor.Visibility = Visibility.Hidden;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListBooksInterface((sender as Button).DataContext as Книги));
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string tema = tem.Text;
            string ezd = ez.Text;
            string avtor = avt.Text;
            string bookname = name.Text;
            int oot = 0;
            int doo = 0;
            int.TryParse(datot.Text, out oot);
            int.TryParse(datdo.Text, out doo);


            DGridAvtor.ItemsSource = KPEntities.GetContext().Авторы.
                                    Where(x => (x.Имя.Contains(avtor) || avtor == "")).ToList();
            DGridAvtor.Visibility = Visibility.Visible;
            DGridBooks.ItemsSource = KPEntities.GetContext().Книги.Where(x=>(x.Тематика_книги.Contains(tema) || 
                                    tema=="") && (x.Издательство.Contains(ezd) ||
                                    ezd == "") && (x.Название_книги.Contains(bookname) ||
                                    bookname == "") &&((x.Дата_выхода.Year >= oot || oot == 0) &&
                                    x.Дата_выхода.Year <= doo || doo==0))
                                    .ToList();

        }

        private void GiveBook_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GiveBooksInterface((sender as Button).DataContext as Книги));
        }
    }
}
// && (x.Дата_выхода?.Year >= to || to == 0) 
                                    //&& ( >= dot || dot == 0)