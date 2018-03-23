using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Girl : Human
    {
        //private int gender;

        //public int Gender { get => gender; set => gender = value; }

        private string gender;

        public string Gender { get => gender; set => gender = value; }

        public Girl(string name, int age) : base(name, age)
        {
            //Gender = 2;
            Gender = "Girl";
        }

        public void UniqueGirlAction()
        {
            Console.WriteLine("She likes play with dolls");
        }

        public override void Do()
        {
            base.Do();
            UniqueGirlAction();
        }

        //public override string ToString()
        //{
        //    return (Name + ';' + Age + ';' + Gender);
        //}
    }
}
