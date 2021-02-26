using Module_2_Task_4_Vasylchenko.Models;
using Module_2_Task_4_Vasylchenko.Models.Animals;
using Module_2_Task_4_Vasylchenko.Models.Enums;

namespace Module_2_Task_4_Vasylchenko.Helpers.Extentions
{
    public static class AnimalExtentions
    {
        public static Animal[] FindAnimal(this Animal[] aviary, TypeFood typeFood, FamiliesAnimal familiesAnimal)
        {
            var sort = new Animal[aviary.Length];
            for (var i = 0; i < aviary.Length; i++)
            {
                var temp = aviary[i] as FamilingOfAnimal;
                if (temp != null)
                {
                    if (temp.FamiliesAnimal == familiesAnimal && temp.TypeOfFood == typeFood)
                    {
                        sort[i] = temp;
                    }
                }
            }

            return sort;
        }
    }
}
