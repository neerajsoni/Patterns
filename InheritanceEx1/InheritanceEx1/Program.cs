using System;

namespace InheritanceEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            A c = new C();
            c.Load();
            c.Dump();

            Console.ReadLine();
        }
    }

    internal class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A.Print");
        }

        public virtual void Load()
        {
            Console.WriteLine("A.Load");
        }

        public virtual void Dump()
        {
            Console.WriteLine("A.Dump");
        }
    }

    internal class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B.Print");
        }

        public void Print(string format)
        {
            Console.WriteLine("B.Print(" + format + ")");
        }
    }

    internal class C : B
    {
        public override void Load()
        {
            Console.WriteLine("C.Load");
        }
    }
}
