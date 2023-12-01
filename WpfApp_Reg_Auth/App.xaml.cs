using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp_Reg_Auth.Components;

namespace WpfApp_Reg_Auth
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Reg_Auth_SafEntities1 DB = new Reg_Auth_SafEntities1();
        public static string userTitle = "";
    }
}
