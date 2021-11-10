using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Fried_Chicken.Models;
using Fried_Chicken.Services;
using Fried_Chicken.Models.Entity;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Fried_Chicken.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Food food = e.Parameter as Food;
            // Da co category -> lay api du lieu ve
            RenderFoods();
        }

        public async void RenderFoods()
        {
            // chi viec goi object cuar ApiService vao dung
            ApiService apiService = new ApiService();
            FoodsOfCategory food = await apiService.GetTodaySpecial();
            if (food != null)
            {
                foreach (var c in food.foods)
                {
                    Products.Items.Add(c);
                }
            }
        }
    }
}
