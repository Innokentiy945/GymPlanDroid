using System;
using GymPlanDroid.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymPlanDroid.Modals
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPageTorsoOne : ContentPage
    {
        public ModalPageTorsoOne()
        {
            InitializeComponent();
        }
        
        /*private async void ToMainPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }*/
    }
}