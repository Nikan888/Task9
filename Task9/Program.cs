using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Vladislav", 32);
            Boy boy = new Boy("Stas", 16);
            Girl girl = new Girl("Lena", 14);
            human.Do();
            Console.WriteLine("------------------------------");
            boy.Do();
            Console.WriteLine("------------------------------");
            girl.Do();
            Console.ReadLine();
        }
    }
}
