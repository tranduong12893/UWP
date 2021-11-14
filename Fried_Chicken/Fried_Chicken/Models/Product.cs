using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Fried_Chicken.Models
{

    public class Product
    {
        public int ProID { set; get; }
        public string ProName { set; get; }
        public string ProImg { set; get; }
        public string ProDetail { set; get; }
        public int ProPrice { set; get; }
    }

}
