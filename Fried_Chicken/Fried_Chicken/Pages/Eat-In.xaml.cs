using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Fried_Chicken.Models.Entity;
using Fried_Chicken.Services;
using Fried_Chicken.Models;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Fried_Chicken.Models.Entity;
using Fried_Chicken.Services;
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
            this.InitializeComponent();
            RenderCategoriesToMenu();
        }
        

        public async void RenderCategoriesToMenu()
        {
            // chi viec goi object cuar ApiService vao dung
            ApiService apiService = new ApiService();
            Categories categories = await apiService.GetCategories();
            if (categories != null)
            {
                foreach (var c in categories.data)
                {
                    Menu.Items.Add(new MenuItem() { Name = c.name, Icon = new BitmapImage(new Uri("ms-appx:///Assets/icons8-windows-client-96.png")), MenuPage = "category", Category = c });
                }
            }
        }
    }
}
