using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    public class Person
    {
        private int age;
        public int Age
        {
            get
            { return this.age; }

            set
            {
                if (value == 2)
                    throw new DressCodeException();
                if (value > 80)
                    throw new DressCodeException();
                if (value < 0)
                    throw new ArgumentException("can't be negative!","Age");
                this.age = value;
            }
        }

        public Person(int age)
        {
            this.Age = age;
        }
    }
}
