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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }


        private void EnterBTN_Click(object sender, RoutedEventArgs e)
        {
            var userWrker = App.DB.User.Where(x => x.Login.ToString() == LoginTB.Text & x.Password.ToString() == PassowrdTB.Text).FirstOrDefault();
            if(userWrker != null )
            {
                MessageBox.Show($"{userWrker.User_Title.Job_Title_Name} {userWrker.Login}");
            }
            else 
                MessageBox.Show("Логин или пароль не совпадают");
        }
    }
}
