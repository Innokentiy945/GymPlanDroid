using System.Collections.Generic;
using GymPlanDroid.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymPlanDroid.Modals
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class ModalBase : ContentPage
    {
        private List<Exercise> sportList;
        
        public ModalBase(Grid gridLayout, ImageButton imageButton, List<Exercise> _sportList)
        {
            sportList = _sportList;
            
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
                    
                    imageButton = new ImageButton
                    {
                        Source = product.ImageUrl,
                        BackgroundColor = Color.CornflowerBlue,
                    };
                    
                    imageButton.Clicked += (sender, args) =>
                    {
                        System.Diagnostics.Debug.WriteLine("Unpressed");
                        ImageButton clickButton = (ImageButton)sender;
                        clickButton.BackgroundColor = Color.Red;
                    };
                    imageButton.Pressed += (sender, args) =>
                    {
                        System.Diagnostics.Debug.WriteLine("Pressed");
                        ImageButton clickButton = (ImageButton)sender;
                        clickButton.BackgroundColor = Color.CornflowerBlue;
                    };
                        
                    gridLayout.Children.Add(label, columnIndex, rowIndex);
                    gridLayout.Children.Add(imageButton, columnIndex, rowIndex);
                }  
            }
        }
    }
}