using System;

namespace FarmSystem.Test1
{
    public class Hen : Animal
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
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}