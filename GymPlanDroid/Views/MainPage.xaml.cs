using System;
using System.IO;
using GymPlanDroid.Modals;
using GymPlanDroid.Modals.TorsoModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymPlanDroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void ToModalPageTorsoOne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoFirst());
        }

        private async void ToModalPageTorsoTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoSecond());
        }
        
        private async void ToModalPageTorsoThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageArmOne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageArmTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageArmThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageBackOne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageBackTwo(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageBackThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageLegOne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageLegTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageLegThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageAllRoundOne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageAllRoundTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
        
        private async void ToModalPageAllRoundThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TorsoThird());
        }
    }
}