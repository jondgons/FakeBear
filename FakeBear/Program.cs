using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBear
{
    class Program
    {
        static void Main(string[] args)
        {

            Grizzly grizz = new Grizzly();
            TeddyBear tedd = new TeddyBear();
            BearAdapter gredz = new BearAdapter(grizz);

            grizz.maul();
            grizz.hibernate();
            Console.Write('\n');

            tedd.hug();
            Console.Write('\n');

            gredz.hug();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    interface Bear
    {
        void maul();

        void hibernate();
    }

    interface ToyBear
    {
        void hug();
    }

    class Grizzly : Bear
    {
        public void maul()
        {
            Console.WriteLine("Mama Grizz ferociously attacks in an effort to defend her young!");
        }

        public void hibernate()
        {
            Console.WriteLine("Mama Grizz snuggles up with her little ones for the long winter...");
        }
    }

    class TeddyBear : ToyBear
    {
        public void hug()
        {
            Console.WriteLine("Ted D. hugs you, but something feels off.");
        }
    }

    class BearAdapter : ToyBear
    {
        public Bear bear;
        
        public BearAdapter(Bear b)
        {
            bear = b;
        }

        public void hug()
        {
            bear.maul();
        }
    }
}
