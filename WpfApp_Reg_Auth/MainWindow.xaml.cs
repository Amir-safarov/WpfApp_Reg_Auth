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
using WpfApp_Reg_Auth.Pages;

namespace WpfApp_Reg_Auth
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ModernNavigationSystem.mainWindow = this;
            ModernNavigationSystem.NextPage(new PageComponent("Регистрация и авторизация пользователей", new Enter()));

        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            ModernNavigationSystem.BackPage();
        }

        private void CrashBTN_Click(object sender, RoutedEventArgs e)
        {
            ModernNavigationSystem.BackAuth();
        }
    }
}
