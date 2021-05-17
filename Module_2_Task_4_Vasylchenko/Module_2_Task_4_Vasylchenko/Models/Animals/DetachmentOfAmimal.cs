using Module_2_Task_4_Vasylchenko.Models.Enums;

namespace Module_2_Task_4_Vasylchenko.Models.Animals
{
    public abstract class DetachmentOfAmimal : ClassOfAnimal
    {
        protected DetachmentOfAmimal(double weight, TypeFood typeOfFood)
            : base(weight, typeOfFood)
        {
        }

        public abstract DetachmentAnomal DetachmentAnomal { get; }
    }
}
