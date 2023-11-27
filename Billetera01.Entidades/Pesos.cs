using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera01.Entidades
{
    public class Pesos:Moneda
    {
        private static decimal cotizacionRespectoDolar;


        public override decimal Cantidad
        {
            get => cantidad;

            set
            {
                if (value > 0 )
                {
                    cantidad = value;
                }
                else
                {
                    cantidad = 0;
                }


            }

        }




        //public decimal CotizacionCompra()
        //{
        //    return cotizacionCompra;
        //}

        //public decimal CotizacionVenta()
        //{
        //    return cotizacionVenta;
        //}

        static Pesos()
        {
            cotizacionRespectoDolar = 1.07m;
        }


    public Pesos (decimal cantidad) : base(cantidad)
    {
    }

    public override decimal CalcularValorEnDolares()
        {
            return Cantidad * cotizacionRespectoDolar;
        }

        public override decimal CalcularValorEnPesos()
        {
            return Cantidad;
        }

        public decimal CotizacionRespectoDolar()
        {
            return cotizacionRespectoDolar;
        }


        public new string MostrarInfo()
        {
            return $" {base.MostrarInfo()} Dolares: {CalcularValorEnDolares()}";
        }



    }
}
