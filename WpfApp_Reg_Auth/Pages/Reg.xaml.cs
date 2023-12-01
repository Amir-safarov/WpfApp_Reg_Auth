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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        private string _passwodText;
        public Reg()
        {
            InitializeComponent();
            GenderCB.ItemsSource = App.DB.Gender.ToList();
            GenderCB.DisplayMemberPath = "Gender_Name";
        }

        private void EnterBTN_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();
            if (SurnameTB.Text == "")
                errorMessage.AppendLine("Фамилия не введена.");
            if (NameTB.Text == "")
                errorMessage.AppendLine("Имя не введено.");
            if (PatTB.Text == "")
                errorMessage.AppendLine("Отчество не введено.");
            if (GenderCB.SelectedItem == null)
                errorMessage.AppendLine("Пол не выбран.");
            if (EmailTB.Text == "")
                errorMessage.AppendLine("Почта не введена.");
            if (PhoneTB.Text == "")
                errorMessage.AppendLine("Телефон не введен.");
            if (DateBirthTB.SelectedDate == null)
                errorMessage.AppendLine("Дата рождения не введена.");
            if (LogTB.Text == "")
                errorMessage.AppendLine("Логин не введен.");
            if (PasswordTB.Text == null || PasswordTB.Text == "" || PasswordTB.Text.Length <6 || !PasswordTB.Text.Any(char.IsUpper) || !PasswordTB.Text.Any(char.IsDigit) || PasswordTB.Text.IndexOfAny("!@#$%^".ToCharArray()) == -1)
                errorMessage.AppendLine("Пароль имеет неверный формат.");

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage.ToString());
                errorMessage.Clear();
                return;
            }
            else
            {
                App.DB.User.Add(new User()
                {
                    Login = LogTB.Text,
                    Password = PasswordTB.Text,
                    ID_Job_Title = 40
                });
                App.DB.SaveChanges();
                App.DB.Client.Add(new Client()
                {
                    User_Surname = SurnameTB.Text,
                    User_Name = NameTB.Text,
                    User_Patronymic = PatTB.Text,
                    Email = EmailTB.Text,
                    BirtdayDate = DateBirthTB.SelectedDate,
                    Phone_Number = PhoneTB.Text,
                    ID_Gender = (GenderCB.SelectedItem as Gender).ID,
                    ID_user = App.DB.User.OrderByDescending(x => x.ID).First().ID
                });
                App.DB.SaveChanges();
                MessageBox.Show("Uzbek");
                ModernNavigationSystem.NextPage(new PageComponent("Вход", new Enter()));
            }
        }
    }
}
