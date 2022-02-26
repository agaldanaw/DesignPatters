using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NewState : IState
    {
        public void Handle(ConsumerContext customerContext, decimal amount)
        {
            Console.WriteLine($"Se le pone dinero a su saldo {amount}");
            customerContext.Residue = amount;
            customerContext.SetState(new NotDebtorState());
        }
    }
}
