using System;

namespace FarmSystem.Test1
{
    public abstract class EmydexFarmSystem
    {
        //TEST 1
        public virtual void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            Console.WriteLine("Animal has entered the Emydex farm");
        }
     
        //TEST 2
        public virtual void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            Console.WriteLine("There are no animals in the farm");
        }

        //TEST 3
        public virtual void MilkAnimals()
        {
            //Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public virtual void ReleaseAllAnimals()
        {
           Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}