using System;
using Module_2_Task_4_Vasylchenko.Helpers.Comparers;
using Module_2_Task_4_Vasylchenko.Helpers.Extentions;
using Module_2_Task_4_Vasylchenko.Models.Animals;
using Module_2_Task_4_Vasylchenko.Models.Enums;
using Module_2_Task_4_Vasylchenko.Services;
using Module_2_Task_4_Vasylchenko.Services.Interface;

namespace Module_2_Task_4_Vasylchenko
{
    public class Starter
    {
        private readonly IServiceAviary _animals;
        public Starter()
        {
            _animals = new ServiceAviary();
        }

        public void Run()
        {
            Aviary();
        }

        private void Aviary()
        {
            var animals = _animals.CreateAnAviaryWithAnimals();
            Array.Sort(animals.Animal, new AnimalsComparer());

            for (var i = 0; i < animals.Animal.Length; i++)
            {
                var animal = animals.Animal[i] as FamilingOfAnimal;

                Console.WriteLine($"Name: {animal.Name} Weight: {animal.Weight} Type Of Food: {animal.TypeOfFood} Familing Of Animal: {animal.FamiliesAnimal}");
            }

            Console.WriteLine($"Quantity Arctic Fox : {animals.ArcticFox}");
            Console.WriteLine($"Quantity Polar Bear : {animals.PolarBear}");
            Console.WriteLine($"Quantity RabbitHome : {animals.RabbitHome}");
            Console.WriteLine($"Quantity Wolf : {animals.Wolf}");

            var sortAnimals = animals.Animal.FindAnimal(TypeFood.AnimalOrigin, FamiliesAnimal.Canines);
            Console.WriteLine("Canines and which are meat eaters:");
            for (var i = 0; i < sortAnimals.Length; i++)
            {
                var animalSort = sortAnimals[i] as FamilingOfAnimal;
                if (animalSort != null)
                {
                    Console.WriteLine($"Name: {animalSort.Name} Weight: {animalSort.Weight} Type Of Food: {animalSort.TypeOfFood} Familing Of Animal: {animalSort.FamiliesAnimal}");
                }
            }
        }
    }
}
