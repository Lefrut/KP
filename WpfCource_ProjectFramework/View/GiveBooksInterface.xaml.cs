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
    /// Логика взаимодействия для GiveBooksInterface.xaml
    /// </summary>
    public partial class GiveBooksInterface : Page
    {
        public Книги context = new Книги();
        public Выдача_книг _context = new Выдача_книг();
        public GiveBooksInterface(Книги select)
        {
            InitializeComponent();
            context = select;
            _context.Номер_книги = select.Номер_книги;
            _context.Дача_выдачи = DateTime.Now;
            _context.Номер_сотрудника = Admin.admin_number;
            DataContext = _context;

        }

        private void SaveBook(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    int number_chit = 0;
            //    int.TryParse(chit.Text, out number_chit);
            //    _context.Номер_читателя = number_chit;
            //    KPEntities.GetContext().Выдача_книг.Add(_context);
            //    KPEntities.GetContext().SaveChanges();
            //    MessageBox.Show("Информация сохранена!");
            //    NavigationService.GoBack();

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            int number_chit = 0;
            int.TryParse(chit.Text, out number_chit);
            _context.Номер_читателя = number_chit;
            MessageBox.Show($"{_context.Номер_читателя}");
            MessageBox.Show($"{_context.Номер_книги}");
            MessageBox.Show($"{_context.Дача_выдачи}");
            MessageBox.Show($"{_context.Номер_сотрудника}");


            KPEntities.GetContext().Выдача_книг.Add(_context);
            KPEntities.GetContext().SaveChanges();
            MessageBox.Show("Информация сохранена!");
            NavigationService.GoBack();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
