using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private double ans = 0;
        private int num = 0;
        private int eq = 0;
        private void Button_Clicked_C(object sender, EventArgs e)
        {
            ans = 0;
            num = 0;
            Number.Text = "" + num;
        }

        private void Button_Clicked_Del(object sender, EventArgs e)
        {
            num /= 10;
            Number.Text = "" + num;
        }

        private void Button_Clicked_0(object sender, EventArgs e)
        {
            num = num * 10 + 0;
            Number.Text = "" + num;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            num = num * 10 + 1;
            Number.Text = "" + num;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            num = num * 10 + 2;
            Number.Text = "" + num;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            num = num * 10 + 3;
            Number.Text = "" + num;
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            num = num * 10 + 4;
            Number.Text = "" + num;
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            num = num * 10 + 5;
            Number.Text = "" + num;
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            num = num * 10 + 6;
            Number.Text = "" + num;
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            num = num * 10 + 7;
            Number.Text = "" + num;
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            num = num * 10 + 8;
            Number.Text = "" + num;
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            num = num * 10 + 9;
            Number.Text = "" + num;
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            eq = 1;
            ans = num;
            Number.Text = "" + num;
            num = 0;
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            eq = 2;
            ans = num;
            Number.Text = "" + num;
            num = 0;
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            eq = 3;
            ans = num;
            Number.Text = "" + num;
            num = 0;
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            eq = 4;
            ans = num;
            Number.Text = "" + num;
            num = 0;
        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {
            if ( eq == 1)
            {
                ans += num;
            }

            if ( eq == 2 )
            {
                ans -= num;
            }

            if ( eq == 3 )
            {
                ans *= num;
            }

            if ( eq == 4 )
            {
                ans /= num;
            }
            Number.Text = "" + ans;
        }
    }
}
