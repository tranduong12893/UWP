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
    public sealed partial class EmailForm : Page
    {
        public EmailForm()
        {
            this.InitializeComponent();
        }
        private void Send(object sender, RoutedEventArgs e)
        {
            var email = inputEmail.Text;
            var title = inputTitle.Text;
            var content = inputContent.Text;
             
            txtEmail.Text = "Mail nhận:" + email;
            txtTitle.Text = "Tiêu đề:" + title;
            txtContent.Text = "Nội dung:" + content;
        }

    }
}
