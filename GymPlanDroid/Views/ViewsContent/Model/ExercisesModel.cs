using System;
using System.Collections.Generic;
using System.Text;

namespace GymPlanDroid.Model
{
    internal class ExercisesModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string AnimationUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
