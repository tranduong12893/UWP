using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Fried_Chicken.Models;
using Fried_Chicken.Services;
using Fried_Chicken.Models.Entity;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Fried_Chicken.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public static todaySpecial todayspecial;

        public Home()
        {
            this.InitializeComponent(); 
            RenderSpecial();
        }

        public async void RenderSpecial()
        {
            // chi viec goi object cuar ApiService vao dung
            ApiService apiService = new ApiService();
            todayspecial = await apiService.GetTodaySpecial();
            if (todayspecial != null)
            {
                foreach (var c in todayspecial.data)
                {
                    Products.Items.Add(new Product() { ProName = c.name, ProDetail = c.description, ProID = c.id, ProImg = c.image, ProPrice = c.price });
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var id = ((Button)sender).Tag;

            foreach (var c in todayspecial.data)
            {
                if ((int)id == (uint)c.id)
                {
                    Food a = c;
                    Frame.Navigate(typeof(Pages.FoodDetail), a);
                }
            }
        }


    }
    }
