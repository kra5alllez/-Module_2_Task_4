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

            var arcticFoxCounter = 0;
            var wolfCounter = 0;
            var polarBearCounter = 0;
            var rabbitHomeCounter = 0;
            for (var i = 0; i < animals.Length; i++)
            {
                ArcticFox arcticFox = animals[i] as ArcticFox;
                if (arcticFox != null)
                {
                    arcticFoxCounter++;
                }

                Wolf wolf = animals[i] as Wolf;
                if (wolf != null)
                {
                    wolfCounter++;
                }

                PolarBear polarBear = animals[i] as PolarBear;
                if (polarBear != null)
                {
                    polarBearCounter++;
                }

                RabbitHome rabbitHome = animals[i] as RabbitHome;
                if (rabbitHome != null)
                {
                    rabbitHomeCounter++;
                }
            }

            return new Aviary { Animal = animals, Wolf = wolfCounter, ArcticFox = arcticFoxCounter, PolarBear = polarBearCounter, RabbitHome = rabbitHomeCounter };
        }
    }
}
