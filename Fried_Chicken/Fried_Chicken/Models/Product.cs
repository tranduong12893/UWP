using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Fried_Chicken.Models
{

    class Product
    {
        public string ProGroup { set; get; }
        public string ProName { set; get; }
        public BitmapImage ProImg { set; get; }
        public string ProDetail { set; get; }
        public string ProContent { set; get; }
        public int ProPrice { set; get; }
    }
}
