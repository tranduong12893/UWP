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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace t2010a_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomerForm : Page
    {
        public CustomerForm()
        {
            this.InitializeComponent();
        }
        private void Send(object sender, RoutedEventArgs e)
        {
            var name = inputName.Text;
            var birth = inputBirth.Date;
            var phone = inputPhone.Text;
            var address = inputAddress.Text;

            txtName.Text = "Họ và tên:" + name;
            txtBirth.Text = "Ngày sinh:" + birth;
            txtPhone.Text = "SĐT:" + phone;
            txtAddress.Text = "Địa chỉ:" + address;
        }
    }
}
