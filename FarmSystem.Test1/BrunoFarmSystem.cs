using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class BrunoFarmSystem : EmydexFarmSystem
    {
        Queue<Animal> qAnimal = new Queue<Animal>();

        public override void Enter(object animal)
        {
            Console.WriteLine($"{animal.GetType().Name} has entered the Emydex farm");

            qAnimal.Enqueue(animal as Animal);
        }

        public override void MakeNoise()
        {
            foreach(var a in qAnimal)
            {
                a.Talk();
            }
        }

        public override void MilkAnimals()
        {
            foreach (var a in qAnimal)
            {
                a.ProduceMilk();
            }
        }

        public override void ReleaseAllAnimals()
        {
            foreach (var a in qAnimal)
            {
                Console.WriteLine($"{a.GetType().Name} has left the farm");
            }

            qAnimal.Clear();

            if (qAnimal.Count() == 0)
                FarmEmpty(this, new MyEvents("Emydex Farm is now empty"));
        }

        public event MyEventHandler FarmEmpty;

    }
}
