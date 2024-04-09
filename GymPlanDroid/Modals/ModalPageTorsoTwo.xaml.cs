using GymPlanDroid.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymPlanDroid.Modals
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPageTorsoTwo : ContentPage
    {
        public ModalPageTorsoTwo()
        {
            InitializeComponent();
        }
        
        private async void ToMainPage()
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}