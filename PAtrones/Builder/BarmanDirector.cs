using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// La receta es el builder, pasos a seguir, pasos y que hace cada paso
    /// Director sabe como hacer esos pasos, en que orden order de esos pasos
    /// 
    /// 
    /// </summary>
    public class BarmanDirector
    {
        private IBuilder _builder;

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public BarmanDirector(IBuilder builder)
        {
            _builder = builder;
        }


        public void PrepareMargarita()
        {
            _builder.Reset();
            _builder.setAlchohol(9);
            _builder.SetWater(30);
            _builder.AddIngredients("2 limones");
            _builder.AddIngredients("pizca de sal");
            _builder.AddIngredients("1/2 taza de Tequila");
            _builder.AddIngredients("3/4 tazas licor de naranja");
            _builder.AddIngredients("4 cubos de hielo");
            _builder.Mix();
            _builder.Rest(1000);
        }

        public void PreparePineapleCream()
        {
            _builder.Reset();
            _builder.setAlchohol(20);
            _builder.SetWater(10);
            _builder.SetMilk(500);
            _builder.AddIngredients("1/2 taza de ron");
            _builder.AddIngredients("1/2 de crema de coco");
            _builder.AddIngredients("3/4 tazas de jugo de piña");
            _builder.Mix();
            _builder.Rest(2000);
        }

    }
}
