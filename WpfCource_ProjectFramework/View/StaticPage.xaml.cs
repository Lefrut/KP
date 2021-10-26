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
    /// Логика взаимодействия для StaticPage.xaml
    /// </summary>
    public partial class StaticPage : Page
    {
        public StaticPage()
        {
            InitializeComponent();
            DGridBooksTwo.ItemsSource = KPEntities.GetContext().Книги.ToList();
        }

        private void Search(object sender, RoutedEventArgs e)
        {

            int count = (from knig in KPEntities.GetContext().Книги.Where(x => (x.Тематика_книги.Contains(Tema.Text)))
                         select knig).Count();
            Counter.Text = count.ToString();
        }
    }
}
