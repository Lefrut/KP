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
    /// Логика взаимодействия для ListBooksInterface.xaml
    /// </summary>
    public partial class ListBooksInterface : Page
    {
        Книги ccontext = new Книги();
        int key = 1;
        public ListBooksInterface(Книги sel)
        {
            InitializeComponent();
            if(sel!=null)
            {
                key = 0;
                ccontext = sel;
            }
            DataContext = ccontext;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SaveBook_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    if(key == 1) KPEntities.GetContext().Книги.Add(context);
            //    KPEntities.GetContext().SaveChanges();
            //    MessageBox.Show("Информация сохранена!");
            //    NavigationService.GoBack();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            if (key == 1) KPEntities.GetContext().Книги.Add(ccontext);
            KPEntities.GetContext().SaveChanges();
            MessageBox.Show("Информация сохранена!");
            NavigationService.GoBack();
        }
    }
}
