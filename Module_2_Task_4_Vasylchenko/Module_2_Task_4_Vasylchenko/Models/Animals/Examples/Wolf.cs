using Module_2_Task_4_Vasylchenko.Models.Enums;

namespace Module_2_Task_4_Vasylchenko.Models.Animals.Examples
{
    public class Wolf : GenusOfAnimal
    {
        public Wolf(double weight, TypeFood typeOfFood)
            : base(weight, typeOfFood)
        {
        }

        public override string Name => "Wolf";
        public override TypeAnimals TypeAnimals => TypeAnimals.Chordate;
        public override ClassAnimal ClassAnimal => ClassAnimal.Mammals;
        public override DetachmentAnomal DetachmentAnomal => DetachmentAnomal.Predatory;
        public override FamiliesAnimal FamiliesAnimal => FamiliesAnimal.Canines;
        public override GenusAnimal GenusAnimal => GenusAnimal.Dog;
    }
}
