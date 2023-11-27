using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera01.Entidades
{
    public class Euro:Moneda
    {

        private static decimal cotizacionCompra;
        private static decimal cotizacionVenta;
        private static decimal cotizacionRespectoDolar;


        public decimal CotizacionCompra()
        {
            return cotizacionCompra;
        }

        public decimal CotizacionVenta()
        {
            return cotizacionVenta;
        }
        public decimal CotizacionRespectoDolar()
        {
            return cotizacionRespectoDolar;
        }

        static Euro()
        {
            cotizacionRespectoDolar = 1.07m;
            cotizacionCompra = 371.17m;
            cotizacionVenta = 391.45m;
        }


        public Euro(decimal cantidad) : base(cantidad)
        {
        }

        public override decimal CalcularValorEnDolares()
        {
            return Cantidad * CotizacionRespectoDolar();
        }

        public override decimal CalcularValorEnPesos()
        {
            return Cantidad * cotizacionCompra;
        }



        public new string MostrarInfo()
        {
            return $" {base.MostrarInfo()} Pesos: {CalcularValorEnPesos()} Dolar: {CalcularValorEnDolares()}" ;
        }
















    }
}
