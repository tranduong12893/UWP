using Windows.UI.Xaml.Controls;
using Fried_Chicken.Services;
using Fried_Chicken.Models;
using System;
using Windows.UI.Xaml.Media.Imaging;
using Fried_Chicken.Models.Entity;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Fried_Chicken.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Eat_In : Page
    {
        public Eat_In()
        {
            InitializeComponent();
            RenderCategoriesToEat_In();
        }

        public async void RenderCategoriesToEat_In()
        {
            // chi viec goi object cuar ApiService vao dung
            ApiService apiService = new ApiService();
            Categories categoriess = await apiService.GetCategories();
            if (categoriess != null)
            {
                foreach (var c in categoriess.data)
                {
                    if(c.id == 1)
                    {
                        Menu.Items.Add(new MenuItem() { Name = c.name, Icon = new BitmapImage(new Uri("ms-appx:///Assets/burger1.jpg")), MenuPage = "category", Category = c });
                    }else if(c.id == 2)
                    {
                        Menu.Items.Add(new MenuItem() { Name = c.name, Icon = new BitmapImage(new Uri("ms-appx:///Assets/friedchicken.jpg")), MenuPage = "category", Category = c });
                    }
                    else if (c.id == 3)
                    {
                        Menu.Items.Add(new MenuItem() { Name = c.name, Icon = new BitmapImage(new Uri("ms-appx:///Assets/rice.jpg")), MenuPage = "category", Category = c });
                    }
                    else if (c.id == 4)
                    {
                        Menu.Items.Add(new MenuItem() { Name = c.name, Icon = new BitmapImage(new Uri("ms-appx:///Assets/drinks.jpg")), MenuPage = "category", Category = c });
                    }
                    else if (c.id == 5)
                    {
                        Menu.Items.Add(new MenuItem() { Name = c.name, Icon = new BitmapImage(new Uri("ms-appx:///Assets/dessert.jpg")), MenuPage = "category", Category = c });
                    }
                  
                }
            }
        }

        private void StackPanel_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)Menu.SelectedItem;
            switch (selected.MenuPage)
            {
                case "category": this.Frame.Navigate(typeof(Pages.Catagory), selected.Category); break;
            }
        }
    }
}
