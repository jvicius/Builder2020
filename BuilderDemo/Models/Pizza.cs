using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BuilderDemo.Models
{
    public class Pizza
    {
        //private Tamanio _tamanio;

        //public Tamanio Tamanio
        //{
        //    set
        //    {
        //        this._tamanio = value;
        //    }
        //    get
        //    {
        //        return this._tamanio;
        //    }
        //}
        public Tamanio Tamanio { set; get; }
        public Masa Masa { set; get; }
        public Salsa Salsa { set; get; }
        public List<Ingredientes> Ingredientes { set; get; }
        public string Nombre { set; get; }

        public Pizza()
        {
            this.Ingredientes = new List<Ingredientes>();
        }

        public Pizza(string nombre, Tamanio tamanio, Masa masa, Salsa salsa, List<Ingredientes> ingredientes)
        {
            this.Nombre = nombre;
            this.Tamanio = tamanio;
            this.Masa = masa;
            this.Salsa = salsa;
            this.Ingredientes = ingredientes;
        }

        public override string ToString()
        {
            return $"Nombre {this.Nombre}/ Tamaño: {this.Tamanio}, Masa: {this.Masa}, Salsa: {this.Salsa}, Ingredientes: {string.Join(',',this.Ingredientes)}";
        }
    }
}
