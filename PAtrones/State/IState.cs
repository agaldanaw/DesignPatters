using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //internal: mismo ensamblado todo lo que está adentro
    public interface IState
    {
        public void Handle(ConsumerContext customerContext, decimal amount);
    }
}
