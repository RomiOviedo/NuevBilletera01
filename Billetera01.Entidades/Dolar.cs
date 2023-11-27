using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera01.Entidades
{
    public class Dolar : Moneda
    {


        private static decimal cotizacionCompra;
        private static decimal cotizacionVenta;


        public decimal CotizacionCompra()
        {
            return cotizacionCompra;
        }

        public decimal CotizacionVenta()
        {
            return cotizacionVenta;
        }

        static Dolar()
        {
            cotizacionCompra = 348.50m;
            cotizacionVenta = 368.50m;
        }
        public Dolar(decimal cantidad) : base(cantidad)
        {
        }

        public override decimal CalcularValorEnDolares()
        {
            return Cantidad;
        }

        public override decimal CalcularValorEnPesos()
        {
            return Cantidad * cotizacionCompra;
        }

        public new string MostrarInfo()
        {
            return $" {base.MostrarInfo()} Pesos: {CalcularValorEnPesos()}";
        }

    }
}
