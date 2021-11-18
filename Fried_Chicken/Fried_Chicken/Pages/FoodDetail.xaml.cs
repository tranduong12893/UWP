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
    public sealed partial class FoodDetail : Page
    {
        public FoodDetail()
        {
            this.InitializeComponent();
        }
        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    base.OnNavigatedTo(e);
        //    Food food = e.Parameter as Food;
        //    // Da co category -> lay api du lieu ve
        //    RenderFoodDetail(food);
        //}

        //private async void RenderFoodDetail(Food food)
        //{
        //    ApiService service = new ApiService();
        //    FoodList fooddetail = await service.FoodDetail(food);
        //    if (fooddetail != null)
        //    {
        //        var f = fooddetail.data;
        //            Products.Items.Add(f);
        //        
        //    }
        //}
    }
}
