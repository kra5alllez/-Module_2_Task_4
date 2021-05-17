using Module_2_Task_4_Vasylchenko.Models.Enums;

namespace Module_2_Task_4_Vasylchenko.Models.Animals.Animals
{
    public class RabbitHome : GenusOfAnimal
    {
        public RabbitHome(double weight, TypeFood typeOfFood)
            : base(weight, typeOfFood)
        {
        }

        public override string Name => "RabbitHome";
        public override TypeAnimals TypeAnimals => TypeAnimals.Chordate;
        public override ClassAnimal ClassAnimal => ClassAnimal.Mammals;
        public override DetachmentAnomal DetachmentAnomal => DetachmentAnomal.Rodents;
        public override FamiliesAnimal FamiliesAnimal => FamiliesAnimal.Hare;
        public override GenusAnimal GenusAnimal => GenusAnimal.Hare;
    }
}
