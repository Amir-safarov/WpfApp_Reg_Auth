using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using WpfApp_Reg_Auth.Pages;

namespace WpfApp_Reg_Auth.Components
{
    internal class ModernNavigationSystem
    {
        private static List<PageComponent> list = new List<PageComponent>();
        public static MainWindow mainWindow;

        public static void NextPage(PageComponent page)
        {
            list.Add(page);
            Update(page);
        }
        public static void BackPage()
        {
            if (list.Count > 1)
            {
                list.RemoveAt(list.Count - 1);
                Update(list[list.Count - 1]);
            }
        }

        private static void Update(PageComponent page)
        {
            mainWindow.Title = page.PageTitle;
            mainWindow.TitleTb.Text = page.PageTitle;
            mainWindow.BackBTN.Visibility = list.Count() > 1 ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
            mainWindow.MainFrame.Navigate(page.PagesLink);
        }
        public static void BackAuth()
        {
            MessageBox.Show("Ваша роль обнулена.");
            App.isAdmin = false;
            NextPage(new PageComponent("Авторизация", new Enter()));
        }
        public static void ClearStoryList()
        {
            list.Clear();
        }
    }
}
internal class PageComponent
{
    public string PageTitle { get; set; }
    public Page PagesLink { get; set; }
    public PageComponent(string pageTitle, Page pagesLink)
    {
        PageTitle = pageTitle;
        PagesLink = pagesLink;
    }
}