using System;
using System.Collections.Generic;
using System.Text;
using BuilderDemo.Builder;
using BuilderDemo.Models;

namespace BuilderDemo.Director
{
    public class Cocina
    {
        private PizzaBuilder _pizzaBuilder;

        public Cocina(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public Pizza ObtenerPizza()
        {
            _pizzaBuilder.PrepararMasa();
            _pizzaBuilder.AniadirSalsa();
            _pizzaBuilder.AniadirIngredientes();
            return _pizzaBuilder.ObtenerPizza;
        }
    }
}
