using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            txt_bt.Text = txt_bt.Text + "1";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            txt_bt.Text = txt_bt.Text + "2";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            txt_bt.Text = txt_bt.Text + "3";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            txt_bt.Text = txt_bt.Text + "4";
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            txt_bt.Text = txt_bt.Text + "5";
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            txt_bt.Text = txt_bt.Text + "6";
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            txt_bt.Text = txt_bt.Text + "7";
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            txt_bt.Text = txt_bt.Text + "8";
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            txt_bt.Text = txt_bt.Text + "9";
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            txt_bt.Text = txt_bt.Text + "0";
        }
    }
}