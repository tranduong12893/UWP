﻿using System;
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
            RenderSpecial();
        }

        public async void RenderSpecial()
        {
            // chi viec goi object cuar ApiService vao dung
            ApiService apiService = new ApiService();
            todaySpecial food = await apiService.GetTodaySpecial();
            if (food != null)
            {
                foreach (var c in food.data)
                {
                    Products.Items.Add(new Product() { ProName = c.name, ProDetail = c.description, ProID = c.id, ProImg = c.image, ProPrice = c.price });
                }
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Food food = e.Parameter as Food;
            // Da co category -> lay api du lieu ve
            RenderFoodDetail(food);
        }

        private async void RenderFoodDetail(Food food)
        {
            ApiService service = new ApiService();
            FoodList fooddetail = await service.FoodDetail(food);
            if (fooddetail != null)
            {
                var f = fooddetail.data;
                Products.Items.Add(f);

            }
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
