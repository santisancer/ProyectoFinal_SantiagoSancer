using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionCabañas_SantiagoSancer.Modelo
{
    class Reserva
    {
        //atributos
        private bool pagado;
        private int cantidadPersonas;
        private DateTime fechaIngreso;
        private DateTime fechaSalida;

        private Huesped titularReserva;
        private Cabaña cabaña;


        //contructor
        public Reserva(bool pagado, int cantidadPersonas, DateTime fechaIngreso, DateTime fechaEgreso)
        {
            this.pagado = pagado;
            this.cantidadPersonas = cantidadPersonas;
            this.fechaIngreso = fechaIngreso;
            this.fechaSalida = fechaSalida;
        }
        //getters
        public DateTime Fecha_ingreso { get => fechaIngreso; }
        public DateTime Fecha_salida { get => fechaSalida; }
        public int CantidadPersonas { get => cantidadPersonas; }
        public bool Pagado { get => pagado; }
        internal Cabaña Cabaña { get => cabaña; }
        internal Huesped TitularReserva { get => titularReserva; }

        //metodos
        public void agregarCabaña(Cabaña cab)
        {
            this.cabaña = cab;
        }
        public void asociarHuesped(Huesped hu)
        {
            this.titularReserva = hu;
        }
        public void mostrarDatos()
        {

        }
    }
}
