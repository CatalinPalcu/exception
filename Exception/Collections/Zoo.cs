using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Zoo
    {
        public List<Animal> Animals { get; set; }
        public Zoo()
        {
            Animals = new List<Animal>();
            InitZoo();
        }

        private void InitZoo()
        {
            Animals.Add(new Animal("elephant", Gender.Female));
            Animals.Add(new Animal("tiger", Gender.Female));
            Animals.Add(new Animal("zebra", Gender.Male));
            Animals.Add(new Animal("fox", Gender.Male));
        }
    }
}
