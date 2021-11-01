using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using t2010a_UWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace t2010a_UWP.Lab_s2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Pages.Home));
            var item1 = new MenuItem() { Name = "Home", MenuPage = "homepage", Icon = "\uE80F" };
            var item2 = new MenuItem() { Name = "Contact", MenuPage = "contact", Icon = "\uE77B" };
            var item3 = new MenuItem() { Name = "Customer", MenuPage = "customer", Icon = "\uE716" };
            var item4 = new MenuItem() { Name = "Mail", MenuPage = "mail", Icon = "\uE715" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
        }

        private void IconClick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)Menu.SelectedItem;
            switch (selected.MenuPage)
            {
                case "homepage": MainFrame.Navigate(typeof(Pages.Home)); break;
                case "contact": MainFrame.Navigate(typeof(Pages.DemoForm)); break;
                case "customer": MainFrame.Navigate(typeof(Pages.CustomerForm)); break;
                case "mail": MainFrame.Navigate(typeof(Pages.EmailForm)); break;
            }
        }
    }
}
