using System;
using System.Collections.Generic;

namespace DesignPatternsIntro
{
    /*
     La programación orientada a objetos es un paradigma de programación. Nos sirve para desarrollar.
    forma de trabajar la programación y representar objetos. los objetos tienen atributos y funciones.

    ejemplo: yo, tengo ojos, boca, piel, cabello y tengo cunciones, trabajar, aprender, tomarcerveza.

    Los objetos se relacionan y pueden trabajar en conjunto.

    Y gracias alos patrones de diseño pueod hacer que esos objetos trabajan de la mejor forma.

    Constructor: cuando se cera un objeto.
     */
    class Program
    {
        static void Main(string[] args)
        {
            //var andres = new SportyPerson("Andrés", 26, "Colombiana");
            //var pancho = new SportyPerson("Francisco", 36, "Mexicana");

            //Console.WriteLine(andres.Show());
            //Console.WriteLine(pancho.Show());

            //Console.WriteLine(andres.Run());


            List<IFlyer> ducks = new List<IFlyer>();
            var duck1 = new Duck();
            var duck2 = new Duck();
            var duck3 = new Duck();
            var fallina = new Gallina();

            ducks.Add(duck1);
            ducks.Add(duck2);
            ducks.Add(duck3);
            ducks.Add(fallina);

            AVolar(ducks);
        }

        static void AVolar(List<IFlyer> ducks)
        {
            foreach(var ave in ducks)
            {
                ave.Vuela();
            }
        }


        interface IFlyer
        {
            public void Vuela();
        }

        interface ICaminador
        {
            public void Camina();
        }

        class Duck : IFlyer, ICaminador
        {
            public void Camina()
            {
                Console.WriteLine("Pato camina..");
            }

            public void Vuela()
            {
                Console.WriteLine("Pato vuela...");

            }
        }

        class Gallina : IFlyer
        {
            public void Vuela()
            {
                Console.WriteLine("Gallina vuela...");

            }
        }
    }

    /*
     Clase abastracta: sirve para especificar funcionamiento, cualidades y/o propiedades. No sirve para crear objetos.
    Abstracto: generar setructura de funcionamiento, solo sirve como base pero no para crear funcionamiento. Estrutura. clases hijas hereden funcionamiento.
     
    Un triangulo es una figura, tiene tres lados. 

    Poder identificar funcionamiento lo más abstracto posible. (en POO)
     
     */

    abstract class Person
    {
        public string Name;
        public int Age;
        public string Nationality;
        public Person(string name, int age, string nationality)
        {
            Name = name;
            Age = age;
            Nationality = nationality;
        }
        public string Show()
        {
            return $"Name={Name} Age={Age} Nationality={Nationality}";
        }
    }



    class SportyPerson : Person
    {
        public SportyPerson(string name, int age, string nationality)
            :base(name, age, nationality)
        {

        }

        public string Run()
        {
            return $"Running Name={Name} Age={Age} Nationality={Nationality}";
        }

        /*
         Interfaz: srive para evitar problema que existe con la herencia. solo podemos heredar de un elemento. 
        Implementación de interzas: base de patrones de disñeo junto a clases abstractas.

        Darles un mecanismo de categorización a nuestras clases.

        Cuando se implementa una itnerzas vamos a darle funcionamiento a la interfaz.

        Una interfaz es un contrato, la diferencia con las clases abstractas es que estas no implementan el funcionamiento.

        Ayudan a dar uniformidad en nuestros proyectos.
         
         
         */




    }
}
