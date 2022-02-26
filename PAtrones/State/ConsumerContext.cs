using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ConsumerContext
    {
        private IState _state;
        private decimal _residue;
        public decimal Residue
        {
            get { return _residue; }
            set { _residue = value; }
        }

        public ConsumerContext()
        {
            _state = new NewState();
        }

        public void SetState(IState state) => _state = state;
        public IState GetState() => _state;
        public void Request(decimal amount) => _state.Handle(this, amount);
        public void Discount(decimal amount) => _residue -= amount;

    }
}
