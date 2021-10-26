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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ButtonClick_ListBooks(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListBooks());
        }

        private void Exit_Down(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
            
        }

        private void Tir_Down(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void ButtonClick_StaticPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StaticPage());
        }

        private void ButtonClick_RedersPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ReadersPage());
        }

        private void ButtonClick_DeptorPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DeptorPage());
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainLoginMenu login = new MainLoginMenu();
            login.Show();
            this.Close();
            
        }
    }

}
