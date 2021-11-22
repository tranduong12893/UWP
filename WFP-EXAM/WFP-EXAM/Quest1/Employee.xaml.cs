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

namespace WFP_EXAM.Quest1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Employee : Page
    {
        public Employee()
        {
            this.InitializeComponent();
        }
        private List<Employeess> employees;

        public class Employeess
        {
            public Employeess(string Name, ushort Role, ushort Birthyear)
            {
                Name = name;
                Role = role;
                Birthyear = birthyear;
            }

            public string Name { get; set; }
            public string Role { get; set; }
            public int Birthyear { get; set; }
        }
    }
}
