using System;

namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
        private int _noOfLegs;

        public string Id { get; set; }

        public int NoOfLegs
        {
            get => _noOfLegs;
            set
            {
                _noOfLegs = value;
                _noOfLegs = 4;
            }
        }

        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}