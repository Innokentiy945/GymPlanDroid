using System.Collections.Generic;
using GymPlanDroid.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymPlanDroid.Modals
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPageTorsoOne : ContentPage
    {
        private List<Exercise> sportList;
        
        public ModalPageTorsoOne()
        {
            InitializeComponent();
            GetDataFromJson();
            
            //to modal base
            GridLayout.RowDefinitions.Add(new RowDefinition());  
            GridLayout.RowDefinitions.Add(new RowDefinition());
            GridLayout.RowDefinitions.Add(new RowDefinition());  
            GridLayout.RowDefinitions.Add(new RowDefinition());
            GridLayout.ColumnDefinitions.Add(new ColumnDefinition());  
            GridLayout.ColumnDefinitions.Add(new ColumnDefinition());  
            GridLayout.ColumnDefinitions.Add(new ColumnDefinition());  
  
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
                    
                    ImageButton = new ImageButton
                    {
                        Source = product.ImageUrl,
                        BackgroundColor = Color.CornflowerBlue,
                    };
                    
                    ImageButton.Clicked += (sender, args) =>
                    {
                        System.Diagnostics.Debug.WriteLine("Unpressed");
                        ImageButton clickButton = (ImageButton)sender;
                        clickButton.BackgroundColor = Color.Red;
                    };
                    ImageButton.Pressed += (sender, args) =>
                    {
                        System.Diagnostics.Debug.WriteLine("Pressed");
                        ImageButton clickButton = (ImageButton)sender;
                        clickButton.BackgroundColor = Color.CornflowerBlue;
                    };
                        
                    GridLayout.Children.Add(label, columnIndex, rowIndex);
                    GridLayout.Children.Add(ImageButton, columnIndex, rowIndex);
                }  
            }
        }

        private List<Exercise> GetDataFromJson()
        {
            sportList = new List<Exercise>();  
            sportList.Add(new Exercise { Name = "Standing press", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png"});  
            sportList.Add(new Exercise { Name = "Bench press", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png"});  
            sportList.Add(new Exercise { Name = "Arm press", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png" });  
            sportList.Add(new Exercise { Name = "Spine push machine", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png" });
            return sportList;
        }
    }
}