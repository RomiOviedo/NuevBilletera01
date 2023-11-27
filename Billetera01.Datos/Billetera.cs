using Billetera01.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera01.Datos
{
    public class Billetera
    {
        private List<Moneda> monedas;


        public Billetera()
        {
            monedas = new List<Moneda>();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public string ExtraerDinero(Moneda moneda)
        {
           return this - moneda;

        }
        public string IngresarDinero(Moneda moneda)
        {
            if (this+moneda)
            {
                return $"Se ingresaron {moneda.Cantidad} {moneda.GetType().Name} ";
            }
            return $"No se pudo realizar la operacion ";

        }

        public static bool operator ==(Billetera b, Moneda m)
        {
            foreach (var item in b.monedas)
            {
                if (item.GetType().Name== m.GetType().Name)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Billetera b, Moneda m)
        {
            return !(b==m);
        }
        public static bool operator + (Billetera b, Moneda m)
        {
            if (b!=m)
            {
                b.monedas.Add(m);
                return true;
            }


            foreach (var item in b.monedas)
            {
                if (item == m)
                {
                    item.Cantidad += m.Cantidad;
                    return true;
                }

            }
            return false;
        }
        public static string operator - (Billetera b, Moneda m)
        {

            foreach (var item in b.monedas)
            {
                if (item == m)
                {

                    if (item.Cantidad <  m.Cantidad)
                    {
                        return "Fondos insuficientes!!!";
                    }

                    item.Cantidad -= m.Cantidad;


                    if (item.Cantidad ==0)
                    {
                        b.monedas.Remove(m);
                    }


                 return $"Se retiraron {m.Cantidad} {m.GetType().Name}";

                }

            }

            return $"No tiene {m.GetType().Name} para retirar";

        }

        public static implicit operator string(Billetera b)
        {
            if (b.monedas.Count==0)
            {
                return "No tengo dinero!!!";
            }

            string info = "";

            foreach (var item in b.monedas)
            {
                info += $"{item.Cantidad} {item.GetType().Name}\n";
            }
            return info;
        }


        public Moneda this[int index]
        {
            get
            {
                if (index >= 0 && index < monedas.Count())
                {
                    return monedas[index];
                }
                throw new IndexOutOfRangeException("indice fuera de rango");
            }

            set
            {
            }
        }

        public List<Moneda> ObtenerDatosMonedas()
        {
            List<Moneda> lista = new List<Moneda>();

            foreach (Moneda item in this.monedas)
            {
                lista.Add(item);
            }

            return lista;
        }

    }
}
