using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NotDebtorState : IState
    {
        public void Handle(ConsumerContext customerContext, decimal amount)
        {
            if(amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);
                Console.WriteLine($"Solicitud permitida, gasta {amount} y le queda de saldo {customerContext.Residue}");
                if (customerContext.Residue <= 0)
                {
                    customerContext.SetState(new DebtorState());
                }
            }
            else
            {
                Console.WriteLine($"No tienes suficiente dinero, " +
                    $"tienes {customerContext.Residue} y " +
                    $"quieres gastar {amount}");
            }
        }
    }
}
