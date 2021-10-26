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

namespace WpfCource_ProjectFramework.View
{
    /// <summary>
    /// Логика взаимодействия для MainLoginMenu.xaml
    /// </summary>
    public partial class MainLoginMenu : Window
    {
        public MainLoginMenu()
        {
            InitializeComponent();
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void Exit_login(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Min_login(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            int pass = 0;
            int.TryParse(tb2.Password, out pass);
            string user = KPEntities.GetContext().Читатели.
                Where(x=>(tb1.Text == x.Логин) && (pass == x.Пароль)).
                Select(x => x.Имя).FirstOrDefault();
            //MessageBox.Show("Пользователи");
            //MessageBox.Show(user);
            //MessageBox.Show($"{pass}");
            //MessageBox.Show(tb1.Text);
            if (user==null){
                MainWindow Main = new MainWindow();
                Main.Show();
                this.Close();
            }
            else
            {
                Admin.admin = KPEntities.GetContext().Сотрудники.Where(x => (tb1.Text == x.Логин) && (pass == x.Пароль)).
                    Select(x => x.Должность).FirstOrDefault();
                Admin.admin_number = KPEntities.GetContext().Сотрудники.Where(x => (tb1.Text == x.Логин) && (pass == x.Пароль)).
                    Select(x => x.Номер_сотрудника).FirstOrDefault();
                //MessageBox.Show("Сотрудники");
                //MessageBox.Show(admin);
                //MessageBox.Show($"{pass}");
                //MessageBox.Show(tb1.Text);
                if (Admin.admin == null)
                {
                    MainWindow Main = new MainWindow();
                    Main.Show();
                    this.Close();
                }
                else MessageBox.Show("Такого пользователя нет");
            }
        }
    }
}
