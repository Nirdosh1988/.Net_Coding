using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP.GoodExaple
{
    public interface IWork
    {
        void Work();
    }

    public interface IEat
    {
        void Eat();
    }

    public interface ISleep
    {
        void Sleep();
    }
    public class Human : IWork, IEat, ISleep
    {
        public void Work()
        {
            Console.WriteLine("Human is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Human is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Human is sleeping.");
        }
    }

    public class Robot : IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
}
