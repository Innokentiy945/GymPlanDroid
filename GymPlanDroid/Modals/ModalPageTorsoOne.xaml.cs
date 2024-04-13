using System;
using System.Collections.Generic;
using GymPlanDroid.Model;
using GymPlanDroid.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymPlanDroid.Modals
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPageTorsoOne
    {
        private List<Exercise> sportList;
        
        public ModalPageTorsoOne()
        {
            InitializeComponent();
            GetDataFromJson();
            
            //to modal base
            gridLayout.RowDefinitions.Add(new RowDefinition());  
            gridLayout.RowDefinitions.Add(new RowDefinition());
            gridLayout.RowDefinitions.Add(new RowDefinition());  
            gridLayout.RowDefinitions.Add(new RowDefinition());
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());  
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());  
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());  
  
            var exerciseIndex = 0;
            for (int rowIndex = 0; rowIndex < sportList.Count; rowIndex++)  
            {  
                for (int columnIndex = 0; columnIndex < 3; columnIndex++)  
                {  
                    if (exerciseIndex >= sportList.Count)  
                    {  
                        break;  
                    }  
                    var product = sportList[exerciseIndex];  
                    exerciseIndex += 1; 
                    
                    Label label = new Label  
                    {  
                        Text = product.Name,  
                        VerticalOptions = LayoutOptions.Center,  
                        HorizontalOptions = LayoutOptions.Center,
                    };
                    
                    Button buttonLogo = new Button()
                    {
                        //ImageSource = "A:\\GymPlanApp\\GymPlanDroid\\GymPlanDroid\\Images\\XamarinLogo.png",
                        BackgroundColor = Color.Blue,
                    };

                    buttonLogo.Pressed += (sender, args) =>
                    {
                        System.Diagnostics.Debug.WriteLine("Pressed");
                        ImageButton clickButton = (ImageButton)sender;
                        clickButton.BorderColor = Color.Red;
                        //clickButton.Source = "A:\\GymPlanApp\\GymPlanDroid\\GymPlanDroid\\Images\\XamarinLogo.png";
                
                    };
                    buttonLogo.Clicked += (sender, args) =>
                    {
                        System.Diagnostics.Debug.WriteLine("Unpressed");
                        ImageButton clickButton = (ImageButton)sender;
                        clickButton.BackgroundColor = Color.Blue;
                        //clickButton.Source = "A:\\GymPlanApp\\GymPlanDroid\\GymPlanDroid\\Images\\XamarinLogoBackround.png";
                    };
                    IntilizingPage(label, buttonLogo, columnIndex, rowIndex);
                    IntilizingPage(label, buttonLogo, columnIndex, rowIndex);
                }  
            }
        }

        private void IntilizingPage(Label label, Button button, int columnIndex, int rowIndex)
        {
            gridLayout.Children.Add(button, columnIndex, rowIndex);
            gridLayout.Children.Add(label, columnIndex, rowIndex);
        }

        private List<Exercise> GetDataFromJson()
        {
            sportList = new List<Exercise>();  
            sportList.Add(new Exercise { Name = "Standing press", ImageUrl = "URL"});  
            sportList.Add(new Exercise { Name = "Bench press", ImageUrl = "URL"});  
            sportList.Add(new Exercise { Name = "Arm press" });  
            sportList.Add(new Exercise { Name = "Spine push machine" });
            return sportList;
        }
    }
}