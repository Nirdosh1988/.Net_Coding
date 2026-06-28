using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP.BadExample
{
    public interface IWorker
    {
        void Work();
        void Eat();
        void Sleep();
    }
    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }

        public void Eat()
        {
            throw new NotImplementedException("Robot doesn't eat.");
        }

        public void Sleep()
        {
            throw new NotImplementedException("Robot doesn't sleep.");
        }
    }
}
