using Fried_Chicken.Models;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Fried_Chicken.Models.Entity;
using Fried_Chicken.Services;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Fried_Chicken
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Pages.Home));
            var item1 = new MenuItem() { Name = "Home", MenuPage = "homepage", Icon = new BitmapImage(new Uri("ms-appx:///Assets/icons8-windows-client-96.png")) };
            var item2 = new MenuItem() { Name = "Eat-In", MenuPage = "eat-in", Icon = new BitmapImage(new Uri("ms-appx:///Assets/noun_spoon and fork_4000217.png")) };
            var item3 = new MenuItem() { Name = "Collection", MenuPage = "customer", Icon = new BitmapImage(new Uri("ms-appx:///Assets/icons8-list-128.png")) };
            var item4 = new MenuItem() { Name = "Delivery", MenuPage = "delivery", Icon = new BitmapImage(new Uri("ms-appx:///Assets/delivery.png")) };
            var item5 = new MenuItem() { Name = "Take-Away", MenuPage = "take-away", Icon = new BitmapImage(new Uri("ms-appx:///Assets/pizza-slice.png")) };
            var item6 = new MenuItem() { Name = "Payment", MenuPage = "payment", Icon = new BitmapImage(new Uri("ms-appx:///Assets/money.png")) };
            var item7 = new MenuItem() { Name = "Customers", MenuPage = "customers", Icon = new BitmapImage(new Uri("ms-appx:///Assets/information.png")) };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
            Menu.Items.Add(item5);
            Menu.Items.Add(item6);
            Menu.Items.Add(item7);

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
                case "eat-in": MainFrame.Navigate(typeof(Pages.Eat_In)); break;
                case "collection": MainFrame.Navigate(typeof(Pages.Collection)); break;
                case "delivery": MainFrame.Navigate(typeof(Pages.Delivery)); break;
                case "take-away": MainFrame.Navigate(typeof(Pages.Take_Away)); break;
                case "payment": MainFrame.Navigate(typeof(Pages.Payment)); break;
                case "customers": MainFrame.Navigate(typeof(Pages.Customers)); break;
               
            }
        }
    }
}
