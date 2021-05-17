using Module_2_Task_4_Vasylchenko.Models.Enums;

namespace Module_2_Task_4_Vasylchenko.Models.Animals
{
    public abstract class TypeOfAnimal : Animal
    {
        protected TypeOfAnimal(double weight, TypeFood typeOfFood)
            : base(weight, typeOfFood)
        {
        }

        public abstract TypeAnimals TypeAnimals { get; }
    }
}
