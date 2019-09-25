using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPracApp
{
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 4).ToString();
        static int scores = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if(button.Text == bomb)
            {
                await DisplayAlert("Bomb Exploded", "GAMER OVER", "Retry");
                bomb = new Random().ToString();
                scores = 0;
            }else
            {
                scores += 1;
                await DisplayAlert("Guess that wasn't the bomb", "Scores: " + scores, "Continue");
                bomb = new Random().ToString();
            }
        }
    }
}
