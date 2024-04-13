using System;
using System.Collections.Generic;
using GymPlanDroid.Model;
using GymPlanDroid.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymPlanDroid.Modals
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPageTorsoTwo : ContentPage
    {
        private List<Exercise> sportList;
        
        public ModalPageTorsoTwo()
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
                    
                    var label = new Label  
                    {  
                        Text = product.Name,  
                        VerticalOptions = LayoutOptions.Center,  
                        HorizontalOptions = LayoutOptions.Center,
                    };
                    
                    var buttonLogo = new ImageButton()
                    {
                        Source = "GymPlanDroid/Images/XamarinLogo.png",
                        //VerticalOptions = LayoutOptions.Center,  
                        //HorizontalOptions = LayoutOptions.Center,
                    };
                    
                    gridLayout.Children.Add(new BoxView {BackgroundColor = Color.SkyBlue}, columnIndex, rowIndex);
                    gridLayout.Children.Add(buttonLogo, columnIndex, rowIndex);
                    gridLayout.Children.Add(label, columnIndex, rowIndex);
                }  
            }
        }

        private void ButtonClickked()
        {
            
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