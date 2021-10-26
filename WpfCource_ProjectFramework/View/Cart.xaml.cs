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
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Page
    {
        public Читатели context;
        public Cart(Читатели chit)
        {
            int key = 1;
            InitializeComponent();
            context = chit;
            DataContext = context;
            foreach(var book in KPEntities.GetContext().Выдача_книг.
                Where(x => (x.Номер_читателя == context.Номер_читателя)))
            {
                if(book.Дата_сдачи.Year >= DateTime.Now.Year)
                {
                    if(book.Дата_сдачи.Month >= DateTime.Now.Month)
                    {
                        if(book.Дата_сдачи.Day >= DateTime.Now.Day)
                        {
                            if(book.Дата_сдачи.Hour >= DateTime.Now.Hour)
                            {
                                if (book.Дата_сдачи.Minute >= DateTime.Now.Minute)
                                {
                                    if (book.Дата_сдачи.Second >= DateTime.Now.Second)
                                    {

                                    }
                                    else Dep.Visibility = Visibility.Visible;
                                }
                                else Dep.Visibility = Visibility.Visible;
                            }
                            else Dep.Visibility = Visibility.Visible;
                        }
                        else Dep.Visibility = Visibility.Visible;
                    }
                    else Dep.Visibility = Visibility.Visible;
                }
                else
                {
                    Dep.Visibility = Visibility.Visible;
                }
            }
            DGridGiveBooks.ItemsSource = KPEntities.GetContext().Выдача_книг.
                Where(x => (x.Номер_читателя == context.Номер_читателя)).ToList();
            var infobooksgive = from book in KPEntities.GetContext().Выдача_книг where book.Номер_читателя == context.Номер_читателя
                                select new { book.Номер_книги};
            if (infobooksgive != null)
            {
               //DGridBbooks.ItemsSource = KPEntities300.GetContext().Книги.Where(x => (x.Номер_книги == infobooksgive));
            }
        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            var selected = DGridGiveBooks.SelectedItems.Cast<Выдача_книг>().ToList();
            try
            {
                KPEntities.GetContext().Выдача_книг.RemoveRange(selected);
                KPEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные удалены");
                DGridGiveBooks.ItemsSource = KPEntities.GetContext().Выдача_книг.
                                Where(x => (x.Номер_читателя == context.Номер_читателя)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
//var infobooksgive = from book in KPEntities300.GetContext().Выдача_книг
//                    where book.Номер_читателя == context.Номер_читателя
//                    select new { book.Номер_книги };
//if (infobooksgive != null)
//{
//    DGridBbooks.ItemsSource = KPEntities300.GetContext().Книги.Where(x => (x.Номер_книги == infobooksgive));
//}
