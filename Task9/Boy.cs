using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Boy : Human
    {
        //private int gender;

        //public int Gender { get => gender; set => gender = value; }

        private string gender;

        public string Gender { get => gender; set => gender = value; }

        public Boy(string name, int age) : base(name, age)
        {
            //Gender = 1;
            Gender = "Boy";
        }

        public void UniqueBoyAction()
        {
            Console.WriteLine("He always fighting");
        }

        public override void Do()
        {
            base.Do();
            UniqueBoyAction();
        }

        //public override string ToString()
        //{
        //    return (Name + ';' + Age + ';' + Gender);
        //}
    }
}
