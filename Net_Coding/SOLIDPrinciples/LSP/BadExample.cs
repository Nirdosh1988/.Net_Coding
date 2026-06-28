using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP.BadExample
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    public class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException("Penguins can't fly");
        }
    }

    public class ExexuteService
    {
        public static void Execute()
        {
            Bird bird = new Sparrow();
            bird.Fly();

            bird = new Penguin();
            bird.Fly();   // Runtime Exception ❌
        }
    }
}
