using System;
using System.Collections.Generic;
using System.Text;
using BuilderDemo.Models;

namespace BuilderDemo.Builder
{
    public abstract class PizzaBuilder
    {
        public Tamanio tamanio { set; get; }

        public Pizza _pizza;

        public Pizza ObtenerPizza
        {
            get { return this._pizza; }
        }

        public virtual void PrepararMasa()
        {

        }

        public virtual void AniadirSalsa()
        {

        }

        public virtual void AniadirIngredientes()
        {

        }


    }
}
