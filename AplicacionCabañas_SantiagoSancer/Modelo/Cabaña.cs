using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionCabañas_SantiagoSancer.Modelo
{
    class Cabaña
    {
        //atributos
        private string numero;
        private int capacidad;
        private double precio;
        private bool estado; //indica si esta ocupada o desocupada

        //contructor
        public Cabaña(string numero, int capacidad, double precio, int v, bool estado)
        {
            this.numero = numero;
            this.capacidad = capacidad;
            this.precio = precio;
            this.estado = estado;

        }

        public void mostrarDatos()
        {

        }
    }
}
