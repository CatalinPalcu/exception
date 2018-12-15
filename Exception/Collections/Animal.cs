using System;
using System.Collections.Generic;
using System.Text;

namespace Collections 
{

    public enum Gender
    {
        Male,
        Female
    }

    public class Animal : ILandBound
    {
        public string Name { get; set; }

        public Animal(string name, Gender gender)
        {
            this.Name = name;
            this.MyGender = gender;
        }

        public Gender MyGender { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.MyGender.ToString();
        }
    }
}
