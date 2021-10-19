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

namespace WpfCource_ProjectTest.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindowMenu.xaml
    /// </summary>
    public partial class MainWindowMenu : Window
    {
        public MainWindowMenu()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed) 
            {
                DragMove();
            }
        }
    }
}
