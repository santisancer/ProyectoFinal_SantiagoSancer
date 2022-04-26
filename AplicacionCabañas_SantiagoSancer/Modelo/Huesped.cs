using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionCabañas_SantiagoSancer.Modelo
{
    class Huesped : Usuario
    {
        private Reserva reserva;
        //contructor
        public Huesped(string nombre, string apellido, string correo, string dni, DateTime fechaNacimiento) :
            base(nombre, apellido, correo, dni, fechaNacimiento)
        {

        }
        //metodos
        public void agregarReserva(Reserva r)
        {
            this.reserva = r;

        }

        public override void consultarDisponibilidad()
        {
            throw new NotImplementedException();
        }

        public override void consultarReserva(Reserva r)
        {
            throw new NotImplementedException();
        }

        public override void mostrarDatos()
        {
            throw new NotImplementedException();
        }
    }
}
