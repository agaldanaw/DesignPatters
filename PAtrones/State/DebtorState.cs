using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class DebtorState : IState
    {
        public void Handle(ConsumerContext customerContext, decimal amount)
        {
            Console.WriteLine("No puedes comprar");
        }
    }
}
