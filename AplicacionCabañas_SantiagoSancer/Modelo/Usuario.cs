using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionCabañas_SantiagoSancer.Modelo
{
     abstract class Usuario
    {
        //atributos clase usuario
        protected string nombre;
        protected string apellido;
        protected string dni;
        protected string correo;
        protected DateTime fechaNacimiento;


        //getters
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Correo { get => correo; }
        public string Dni { get => dni; }
        public DateTime Fecha_nacimiento { get => fechaNacimiento; }

        //construtor lleno
        public Usuario(string nombre, string apellido, string dni, string correo, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.correo = correo;
            this.fechaNacimiento = fechaNacimiento;


        }
        //contructor vacio
        public Usuario()
        {

        }
        //metodos clase usuario
        public abstract void consultarDisponibilidad();
        public abstract void consultarReserva(Reserva r);
        public abstract void mostrarDatos();
    }
}
