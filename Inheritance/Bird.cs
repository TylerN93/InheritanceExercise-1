using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            hasEyes = true;
            hasMouth = true;
            needsSleep = true;
            legCount = 2;
        }


        public string WingColor { get; set; }
        public bool Canfly { get; set; }
        public bool LivesInCage { get; set; }
        public bool EatsBirdFood { get; set; }
    }
}

