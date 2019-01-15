using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal
    {
        private int _noOfLegs = 4;


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
            Console.WriteLine("Cow says Moo!");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public override void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

        public void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}