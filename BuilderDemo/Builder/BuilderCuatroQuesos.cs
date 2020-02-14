using System;
using System.Collections.Generic;
using System.Text;
using BuilderDemo.Models;

namespace BuilderDemo.Builder
{
    public class BuilderCuatroQuesos : PizzaBuilder
    {
        public BuilderCuatroQuesos(Tamanio tamanio)
        {
            _pizza = new Pizza();
            _pizza.Nombre = "CuatroQuesos";
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
            _pizza.Ingredientes.Add(Ingredientes.QuesoCotilla);
            _pizza.Ingredientes.Add(Ingredientes.QuesoMozzarella);
            _pizza.Ingredientes.Add(Ingredientes.Queso);
            _pizza.Ingredientes.Add(Ingredientes.QuesoRoquenforn);
        }
    }
}
