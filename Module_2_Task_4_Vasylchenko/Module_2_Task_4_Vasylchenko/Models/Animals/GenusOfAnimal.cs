using Module_2_Task_4_Vasylchenko.Models.Enums;

namespace Module_2_Task_4_Vasylchenko.Models.Animals
{
    public abstract class GenusOfAnimal : FamilingOfAnimal
    {
        protected GenusOfAnimal(double weight, TypeFood typeOfFood)
            : base(weight, typeOfFood)
        {
        }

        public abstract GenusAnimal GenusAnimal { get; }
    }
}
