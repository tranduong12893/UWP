﻿#pragma checksum "D:\ky-3\UWP\t2010a_UWP\t2010a_UWP\Pages\DemoForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "17AA698066C1EE7CFDC8994E34E4687B231E8A152150245D904A62571945D068"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace t2010a_UWP.Pages
{
    partial class DemoForm : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\DemoForm.xaml line 25
                {
                    this.txtFullname = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Pages\DemoForm.xaml line 26
                {
                    this.txtEmail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Pages\DemoForm.xaml line 27
                {
                    this.txtPhone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Pages\DemoForm.xaml line 18
                {
                    this.inputFullname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Pages\DemoForm.xaml line 19
                {
                    this.inputEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Pages\DemoForm.xaml line 20
                {
                    this.inputPhone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Pages\DemoForm.xaml line 21
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.Submit;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

