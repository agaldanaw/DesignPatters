using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MotorbikeStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Motorbike running...");
        }
    }
}
