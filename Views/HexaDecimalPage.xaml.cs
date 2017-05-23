using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorSelectorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HexaDecimalPage : ContentPage
    {
        public HexaDecimalPage()
        {
            InitializeComponent();
        }

        //private void EntryHexValue_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (EntryHexValue.Text.Length > 6)
        //    {
        //        EntryHexValue.Text = EntryHexValue.Text.Remove(EntryHexValue.Text.Length - 1);
        //    }

        //    if (EntryHexValue.Text == null || EntryHexValue.Text == "")
        //    {
        //        LabelTextPreviewer.BackgroundColor = Color.FromHex("#000000");
        //    }
        //    else
        //    {
        //        LabelTextPreviewer.BackgroundColor = Color.FromHex("#" + EntryHexValue.Text);
        //    }
        //}
    }
}
