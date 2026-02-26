using GestionEmpleados;
using System;
using System.Collections.Generic;

namespace GestionEmpleados
{
    public interface IMostrable
    {
        void MostrarInformacion();
    }
    public abstract class Empleado : IMostrable
    {
        private int id;
        private string nombre;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Empleado(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public abstract double CalcularSalario();

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombre: " + Nombre);
        }
    }
}

class Program   
{
    static void Main(string[] args)
    {
       
    }
}



