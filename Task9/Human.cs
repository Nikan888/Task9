using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Human
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                    age = value;
            }
        }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Think()
        {
            Console.WriteLine("Thinking");
        }

        public void Speak()
        {
            Console.WriteLine("Speaking");
        }

        public virtual void Do()
        {
            Console.WriteLine(Name + ';' + Age);
            Think();
            Speak();
        }

        //public override string ToString()
        //{
        //    return (Name + ';' + Age);
        //}
    }
}
