using System;
using System.IO;
using GymPlanDroid.Modals;
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
            await Navigation.PushModalAsync(new ModalPageTorsoOne());
        }
        private async void ToModalPageTorsoTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ModalPageTorsoTwo());
        }
    }
}