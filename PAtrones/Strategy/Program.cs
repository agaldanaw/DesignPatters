using System;

namespace Strategy
{
    class Program
    {
        /// <summary>
        /// Strategy: patrón de comportamiento, realizar cierto comportamiento sobre los objetos.
        /// 
        /// nos ayuda cuando tenemos un elemento que puede ser exportado a diferentes formatos, pdf, xls,
        /// debemos tener una estrategia para imprimir según el formato dado, una estrategia por cada formato
        /// 
        /// Se hace una acción que es de distintos comportamientos.
        /// 
        /// Manejo de este tipo de acciones que pueden caracterizar, tienen escalabilidad y un manejo práctico.
        /// EScalabilidad y mannejo práctico
        /// 
        /// cambiar el comportamiento de una manera dinámica.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var context = new Context(new CarStrategy());
            context.Run();

            context.Strategy = new MotorbikeStrategy();
            context.Run();
        }
    }
}
