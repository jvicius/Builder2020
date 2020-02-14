using System;
using System.Collections.Generic;
using System.Text;
using BuilderDemo.Models;

namespace BuilderDemo.Builder
{
    public class PizzaFluentBuilder
    {
        private Pizza _pizza;

        private PizzaFluentBuilder(Tamanio tamanio)
        {
            _pizza = new Pizza();
            _pizza.Tamanio = tamanio;
            _pizza.Ingredientes = new List<Ingredientes>();
            _pizza.Nombre = "Custom";
        }

        public static PizzaFluentBuilder Crear(Tamanio tamanio)
        {
            return new PizzaFluentBuilder(tamanio);
        }

        public PizzaFluentBuilder MasaSuave()
        {
            _pizza.Masa = Masa.Suave;
            return this;
        }

        public PizzaFluentBuilder MasaCrujiente()
        {
            _pizza.Masa = Masa.Crujiente;
            return this;
        }

        public PizzaFluentBuilder SalsaDulce()
        {
            _pizza.Salsa = Salsa.Dulce;
            return this;
        }

        public PizzaFluentBuilder AgregarIngrediente(Ingredientes ingrediente)
        {
            _pizza.Ingredientes.Add(ingrediente);
            return this;
        }

        public Pizza Cocinar()
        {
            return this._pizza;
        }

    }
}
