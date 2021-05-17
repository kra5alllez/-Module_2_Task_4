using Module_2_Task_4_Vasylchenko.Models.Enums;

namespace Module_2_Task_4_Vasylchenko.Models.Animals
{
    public abstract class FamilingOfAnimal : DetachmentOfAmimal
    {
        protected FamilingOfAnimal(double weight, TypeFood typeOfFood)
            : base(weight, typeOfFood)
        {
        }

        public abstract FamiliesAnimal FamiliesAnimal { get; }
    }
}
