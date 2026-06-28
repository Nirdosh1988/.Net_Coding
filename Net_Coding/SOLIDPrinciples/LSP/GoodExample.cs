using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP.GoodExample
{
    public interface IBird
    {
        void Eat();
    }
    public interface IFlyingBird : IBird
    {
        void Fly();
    }
    public class Sparrow : IFlyingBird
    {
        public void Eat()
        {
            Console.WriteLine("Sparrow is eating.");
        }

        public void Fly()
        {
            Console.WriteLine("Sparrow is flying.");
        }
    }
    public class Eagle : IFlyingBird
    {
        public void Eat()
        {
            Console.WriteLine("Eagle is eating.");
        }

        public void Fly()
        {
            Console.WriteLine("Eagle is flying.");
        }
    }
    public class Penguin : IBird
    {
        public void Eat()
        {
            Console.WriteLine("Penguin is eating.");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }
    public class ExexuteService
    {
        public static void Execute()
        {
            IFlyingBird sparrow = new Sparrow();
            sparrow.Eat();
            sparrow.Fly();

            Console.WriteLine();

            IFlyingBird eagle = new Eagle();
            eagle.Eat();
            eagle.Fly();

            Console.WriteLine();

            Console.WriteLine();

            IBird penguin = new Penguin();
            penguin.Eat();

            // IFlyingBird flyingBird = new Penguin(); // This line would cause a compile-time error

            Console.WriteLine();

            Penguin p = new Penguin();
            p.Swim();
        }
    }
}

