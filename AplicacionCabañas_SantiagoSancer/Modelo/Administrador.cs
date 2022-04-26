using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionCabañas_SantiagoSancer.Modelo
{
    class Administrador : Usuario
    {
        private string contrasenaAdmin;
        //get
        public string ContrasenaAdmin { get => contrasenaAdmin; }

        //contructor lleno
        public Administrador(string nombre, string apellido, string correo, string dni, DateTime fechaNacimiento, string contraseñaAdmin) :
            base(nombre, apellido, correo, dni, fechaNacimiento)
        {
            this.contrasenaAdmin = contrasenaAdmin;
        }

        //constructor vacio
        public Administrador()
        {
        }
        //metodos abstractos heredados
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

        //metodos de clase
        public void crearReserva()
        {

        }
        public void eliminarReserva()
        {

        }

        
    }
}

    

