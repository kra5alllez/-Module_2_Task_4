using Module_2_Task_4_Vasylchenko.Models.Enums;

namespace Module_2_Task_4_Vasylchenko.Models
{
    public abstract class Animal
    {
        protected Animal(double weight, TypeFood typeOfFood)
        {
            Weight = weight;
            TypeOfFood = typeOfFood;
        }

        public abstract string Name { get; }

        public double Weight { get; }

        public TypeFood TypeOfFood { get; }
    }
}
