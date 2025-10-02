using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Cuenta:IComparable<Cuenta>
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public double Importe {  get; set; }
        public Cuenta(string Nombre, int DNI, double Importe)
        {
            this.Nombre = Nombre; this.DNI = DNI; this.Importe = Importe;
        }

        public Cuenta (int DNI)
        {
            this.DNI = DNI;
        }

        public override string ToString()
        {
            return $"{this.Nombre} - {this.DNI} - ${this.Importe}";
        }

        public int CompareTo(Cuenta? nueva)
        {
            if (nueva != null)
            {
                return DNI.CompareTo(nueva.DNI);
            }
            return -1;
        }
    }
}
