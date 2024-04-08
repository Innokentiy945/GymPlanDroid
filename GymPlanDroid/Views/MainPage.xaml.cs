using System;
using System.IO;

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

        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Button pushed";
            button.BackgroundColor = Color.Red;
        }
    }
}