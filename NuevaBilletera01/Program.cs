using Billetera01.Datos;
using Billetera01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevaBilletera01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(1000);
            Pesos peso = new Pesos(20000);
            Pesos peso2 = new Pesos(1000);
            Euro euro = new Euro(1000);

            Billetera billetera = new Billetera();

            Console.WriteLine(billetera.ExtraerDinero(new Pesos(100)));

            string info = billetera;

            Console.WriteLine(info);


            Console.WriteLine(billetera.IngresarDinero(dolar));

            Console.WriteLine(billetera.IngresarDinero(euro));
            Console.WriteLine(billetera.IngresarDinero(peso));
            Console.WriteLine(billetera.IngresarDinero(peso2));

            Dolar dolarRetirar = new Dolar(2000);
            Console.WriteLine(billetera.ExtraerDinero(dolarRetirar));



            Pesos pesoRetirar = new Pesos(1500);
            Console.WriteLine(billetera.ExtraerDinero(pesoRetirar));

            Console.WriteLine();

            info = billetera;
            Console.WriteLine(info);

            Console.WriteLine(billetera[0].MostrarInfo());

            Console.WriteLine(billetera.ObtenerDatosMonedas());
            Console.WriteLine();

            //List<Moneda> datosMonedas = billetera.ObtenerDatosMonedas();

            //Console.WriteLine(datosMonedas);

            Console.WriteLine("Datos de las monedas en la billetera:");

            List<Moneda> datosMonedas = billetera.ObtenerDatosMonedas();

            // Mostrar cada moneda individualmente
            foreach (Moneda moneda in datosMonedas)
            {
                Console.WriteLine(moneda.ToString());
            }

            //ManejadorArchivoXml manejadorArchivo = new ManejadorArchivoXml();

            //manejadorArchivo.GuardarMonedas(billetera.GetMonedas());
            Console.ReadLine();


        }
    }
}
