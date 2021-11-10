using Fried_Chicken.Models.Entity;
using Windows.UI.Xaml.Media.Imaging;

namespace Fried_Chicken.Models
{
    class MenuItem
    {
        public string Name { set; get; }
        public string MenuPage { set; get; }
        public BitmapImage Icon { set; get; }
        public Category Category { get; set; }

    }
}
