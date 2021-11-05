using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Fried_Chicken.Models;

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
            var p1 = new Product() { ProGroup="Burger", ProName = "Cheeseburger",  ProImg = new BitmapImage(new Uri("ms-appx:///Assets/burger1.jpg")), ProDetail="", ProContent= "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Perferendis, est, corporis quis omnis consequuntur nobis nam porro illo optio consequatur repudiandae, in amet consectetur voluptatem recusandae quaerat expedita accusamus explicabo.", ProPrice = 13 };
            var p2 = new Product() { ProGroup = "Cake", ProName = "Rainbow cake", ProImg = new BitmapImage(new Uri("ms-appx:///Assets/cake.jpg")), ProDetail = "", ProContent = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Perferendis, est, corporis quis omnis consequuntur nobis nam porro illo optio consequatur repudiandae, in amet consectetur voluptatem recusandae quaerat expedita accusamus explicabo.", ProPrice = 23 };
            var p3 = new Product() { ProGroup = "Pizza", ProName = "Cheese sausage pizza", ProImg = new BitmapImage(new Uri("ms-appx:///Assets/pizza.jpg")), ProDetail = "", ProContent = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Perferendis, est, corporis quis omnis consequuntur nobis nam porro illo optio consequatur repudiandae, in amet consectetur voluptatem recusandae quaerat expedita accusamus explicabo.", ProPrice = 45 };
            Products.Items.Add(p1);
            Products.Items.Add(p2);
            Products.Items.Add(p3);
        }
        
    }
}
