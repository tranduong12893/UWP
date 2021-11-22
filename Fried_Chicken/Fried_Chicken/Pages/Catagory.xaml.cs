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
using Fried_Chicken.Models.Entity;
using Fried_Chicken.Services;
using Fried_Chicken.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Fried_Chicken.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Catagory : Page
    {
        public Catagory()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Category category = e.Parameter as Category;
            // Da co category -> lay api du lieu ve
            RenderFoods(category);
        }

        private async void RenderFoods(Category category)
        {
            ApiService service = new ApiService();
            CategoryDetail categoryDetail = await service.CategoryDetail(category);
            if (categoryDetail != null)
            {
                foreach (var f in categoryDetail.data.foods)
                {
                    Products.Items.Add(f);
                }
            }
        }
        private void StackPanel_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Food selected = (Food)Products.SelectedItem;
            Frame.Navigate(typeof(Pages.Catagory), selected.id);
        }  

    }
}
