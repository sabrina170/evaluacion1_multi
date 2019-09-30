using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace evaluacion1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new StackLayoutDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GridDemo());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page1());

            };
            Item7.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedPage1());

            };
            Item5.Clicked += async (sender, e) =>
            {
                //Call Popup
                await Navigation.PushAsync(new DatepickerDemo());

            };

          

        }
    }
}
