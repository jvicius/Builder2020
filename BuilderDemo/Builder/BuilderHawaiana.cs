using System;
using System.Collections.Generic;
using System.Text;
using BuilderDemo.Models;

namespace BuilderDemo.Builder
{
    public class BuilderHawaiana : PizzaBuilder
    {
        public BuilderHawaiana(Tamanio tamanio)
        {
            _pizza = new Pizza();
            _pizza.Nombre = "Hawaiana";
            _pizza.Tamanio = tamanio;
            _pizza.Ingredientes = new List<Ingredientes>();
        }

        public override void AniadirSalsa()
        {
            _pizza.Salsa = Salsa.Dulce;
        }

        public override void PrepararMasa()
        {
            _pizza.Masa = Masa.Suave;
        }

        public override void AniadirIngredientes()
        {
            _pizza.Ingredientes.Add(Ingredientes.Piña);
            _pizza.Ingredientes.Add(Ingredientes.Jamon);
            _pizza.Ingredientes.Add(Ingredientes.Queso);
        }
    }
}
