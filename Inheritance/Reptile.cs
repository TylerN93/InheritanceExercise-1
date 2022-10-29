using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            hasEyes = true;
            hasMouth = true;
            needsSleep = true;
            legCount = 4;

        }

        public bool LivesInWater { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool IsCarnivore { get; set; }
        public int Age { get; set; }
        
    }
}

