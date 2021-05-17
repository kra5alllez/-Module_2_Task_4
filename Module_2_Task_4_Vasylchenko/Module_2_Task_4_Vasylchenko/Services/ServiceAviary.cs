using Module_2_Task_4_Vasylchenko.Models;
using Module_2_Task_4_Vasylchenko.Models.Animals.Animals;
using Module_2_Task_4_Vasylchenko.Models.Animals.Examples;
using Module_2_Task_4_Vasylchenko.Models.Enums;
using Module_2_Task_4_Vasylchenko.Models.Result;
using Module_2_Task_4_Vasylchenko.Services.Interface;

namespace Module_2_Task_4_Vasylchenko.Services
{
    public class ServiceAviary : IServiceAviary
    {
        public Aviary CreateAnAviaryWithAnimals()
        {
            var animals = new Animal[]
            {
                new ArcticFox(25, TypeFood.AnimalOrigin),
                new ArcticFox(20, TypeFood.AnimalOrigin),
                new Wolf(50, TypeFood.AnimalOrigin),
                new PolarBear(100, TypeFood.Omnivores),
                new RabbitHome(8, TypeFood.VegetableOrigin),
                new RabbitHome(6, TypeFood.VegetableOrigin)
            };

            var animalCounter = new Animal[10];
            var counter = 0;
            for (var i = 0; i < animals.Length; i++)
            {
                for (var j = 0; j < animalCounter.Length; j++)
                {
                    if (animalCounter[j] == null)
                    {
                        animalCounter[j] = animals[i];
                        counter++;
                        break;
                    }
                    else if (animals[i].Name == animalCounter[j].Name)
                    {
                        break;
                    }
                }
            }

            return new Aviary { Animal = animals, UniqueAnimal = animalCounter, AnimalCounter = counter };
        }
    }
}
