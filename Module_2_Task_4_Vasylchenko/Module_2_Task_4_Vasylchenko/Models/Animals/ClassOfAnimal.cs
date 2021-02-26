using Module_2_Task_4_Vasylchenko.Models.Enums;

namespace Module_2_Task_4_Vasylchenko.Models.Animals
{
    public abstract class ClassOfAnimal : TypeOfAnimal
    {
        protected ClassOfAnimal(double weight, TypeFood typeOfFood)
            : base(weight, typeOfFood)
        {
        }

        public abstract ClassAnimal ClassAnimal { get; }
    }
}
