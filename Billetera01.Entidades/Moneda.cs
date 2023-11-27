using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Billetera01.Entidades
{
    public abstract class Moneda
    {
        protected decimal cantidad;

        protected Moneda(decimal cantidad)
        {
            this.cantidad = cantidad;
        }


        public virtual decimal Cantidad 
        { get =>cantidad;

            set
            {
                if (value > 0 && value <200)
                {
                    cantidad = value;
                }
                else
                {
                    cantidad = 0;
                }
                if (value >= 200)
                {
                    cantidad = 200;
                }


            }

        }




        public abstract decimal CalcularValorEnDolares();

        public abstract decimal CalcularValorEnPesos();



        public override bool Equals(object obj)
        {
            if (obj is Moneda)
            {
                return this.GetType().Name == obj.GetType().Name;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return GetType().GetHashCode();
        }

        public string MostrarInfo()
        {
            return $" {GetType().Name} {Cantidad}";
        }
        public static bool operator ==(Moneda m1, Moneda m2)
        {
            return m1.Equals(m2);
        }
        public static bool operator !=(Moneda m1, Moneda m2)
        {
            return !(m1==m2);
        }

        public override string ToString()
        {
            return $"{GetType().Name} {this.Cantidad}"; 

        }











    }
}
