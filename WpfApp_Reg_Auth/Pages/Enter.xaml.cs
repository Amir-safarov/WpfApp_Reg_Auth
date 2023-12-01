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
using WpfApp_Reg_Auth.Components;

namespace WpfApp_Reg_Auth.Pages
{
    /// <summary>
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Page
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void RegBTN_Click(object sender, RoutedEventArgs e)
        {
            ModernNavigationSystem.NextPage(new PageComponent("Регистрация клиентов", new Reg()));
        }

        private void AuthBTN_Click(object sender, RoutedEventArgs e)
        {
            ModernNavigationSystem.NextPage(new PageComponent("Авторизация", new Auth()));

        }
    }
}
