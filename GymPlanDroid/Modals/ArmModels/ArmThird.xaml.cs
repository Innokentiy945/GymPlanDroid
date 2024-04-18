using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymPlanDroid.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymPlanDroid.Modals.ArmModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArmThird : ContentPage
    {
        private List<Exercise> sportList;
        
        public ArmThird()
        {
            try
            {
                InitializeComponent();
                GetDataFromJson();
                SetUpTable();
                
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

                        ImageButton = new ImageButton
                        {
                            Source = product.ImageUrl,
                            BackgroundColor = Color.CornflowerBlue,
                            HorizontalOptions = LayoutOptions.Center
                        };

                        ImageButton.Clicked += (sender, args) =>
                        {
                            ImageButton clickButton = (ImageButton)sender;
                            clickButton.BackgroundColor = Color.Red;
                        };
                        ImageButton.Pressed += (sender, args) =>
                        {
                            ImageButton clickButton = (ImageButton)sender;
                            clickButton.BackgroundColor = Color.CornflowerBlue;
                        };

                        Title = "Basic exercises for arms";
                        GridLayout.Children.Add(ImageButton, columnIndex, rowIndex);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private void SetUpTable()
        {
            GridLayout.RowDefinitions.Add(new RowDefinition());
            GridLayout.RowDefinitions.Add(new RowDefinition());
            GridLayout.RowDefinitions.Add(new RowDefinition());
            GridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            GridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            GridLayout.ColumnDefinitions.Add(new ColumnDefinition());
        }

        private List<Exercise> GetDataFromJson()
        { 
           sportList = new List<Exercise>();
           sportList.Add(new Exercise { Name = "Neck warm up", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png" });
           sportList.Add(new Exercise { Name = "Side and lateral arm raises", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png"});
           sportList.Add(new Exercise { Name = "Push up", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png"});
           sportList.Add(new Exercise { Name = "Plank Tap", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png" });
           sportList.Add(new Exercise { Name = "Forearm Side Plank", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png" });
           sportList.Add(new Exercise { Name = "Shoulder press", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png" });
           sportList.Add(new Exercise { Name = "Plank raise", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png" });
           sportList.Add(new Exercise { Name = "Squates", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png" });
           sportList.Add(new Exercise { Name = "Boat Pose", ImageUrl = "GymPlanDroid.Android/Resources/drawable/gym_exercise.png" });
           return sportList;
        }
    }
}