using System;
using System.Collections.Generic;
using BuilderDemo.Builder;
using BuilderDemo.Director;
using BuilderDemo.Models;

namespace BuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ingredientes = new List<Ingredientes>();
            //ingredientes.Add(Ingredientes.Piña);
            //ingredientes.Add(Ingredientes.Jamon);
            //ingredientes.Add(Ingredientes.Queso);

            //var pizza = new Pizza("Hawahiana", Tamanio.Mediana, Masa.Suave, Salsa.Dulce, ingredientes);

            //Console.WriteLine(pizza.ToString());

            //var builder = new BuilderCuatroQuesos(Tamanio.Mediana);
            //builder.AniadirSalsa();
            //builder.PrepararMasa();
            //builder.AniadirIngredientes();
            //Console.WriteLine(builder.ObtenerPizza.ToString());

            var cocina = new Cocina(new BuilderHawaiana(Tamanio.Mediana));
            Console.WriteLine(cocina.ObtenerPizza().ToString());

            cocina = new Cocina(new BuilderCuatroQuesos(Tamanio.Mediana));
            Console.WriteLine(cocina.ObtenerPizza().ToString());

            var pizza = PizzaFluentBuilder.Crear(Tamanio.Grande).SalsaDulce().MasaCrujiente()
                .AgregarIngrediente(Ingredientes.Queso).AgregarIngrediente(Ingredientes.Jamon)
                .AgregarIngrediente(Ingredientes.Chorizo).MasaSuave().Cocinar();

            Console.WriteLine(pizza.ToString());

            Console.ReadKey();

        }
    }
}
