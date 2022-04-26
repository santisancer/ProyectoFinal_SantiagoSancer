using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionCabañas_SantiagoSancer.Modelo
{
    class Complejo
    {
        //array list de cabañas
        private List<Cabaña> cabaña = new List<Cabaña>();
        //atributos
        private string correo;
        private string direccion;
        private string telefono;

        //contructor
        public Complejo(string correo, string direccion, string telefono)
        {
            this.correo = correo;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        //metodos
        public void agregarCabaña()
        {
            cabaña.Add(new Cabaña("1", 0, 0, 00, false));
        }

        public void mostrarDatos()
        {

        }
    }
}
