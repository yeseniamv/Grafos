using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*se hace la colección
            */
            
            
            Lista nodoA = new Lista();            
            Lista nodoB = new Lista();            
            Lista nodoC = new Lista(); 

            nodoA.AgregarFinal("X");
            nodoA.AgregarFinal("Y");
            nodoB.AgregarFinal("W");
            nodoC.AgregarFinal("M");

            List<String> coleccion = new List<String>
            {
                nodoA.Llave(),
                nodoB.Llave(),
                nodoC.Llave()
            };


            Console.WriteLine("Valores en la colección");
            
            foreach (String s in coleccion) {  Console.WriteLine(s); }
            
            Console.WriteLine("Valores en nodoA");
            Console.WriteLine(nodoA.Recorrer());
            Console.WriteLine("Valores en nodoB");
            Console.WriteLine(nodoB.Recorrer());
            Console.WriteLine("Valores en nodoC");
            Console.WriteLine(nodoC.Recorrer());

            /*
            Lista lista = new Lista();

            Console.WriteLine("Se agregan valores");
            lista.AgregarFinal("Uno");
            lista.AgregarFinal("Dos");
            lista.AgregarFinal("Tres");
            Console.WriteLine(lista.Recorrer());

            Console.WriteLine("Se borra Dos");
            lista.Borrar("Dos");
            Console.WriteLine(lista.Recorrer());

            Console.WriteLine("Se Agrega Cero al inicio");
            lista.AgregarInicio("Cero");
            Console.WriteLine(lista.Recorrer());

            Console.WriteLine("Vaciar lista");
            lista.VaciarLista();

            Console.WriteLine("Se agregan nuevos valores");
            lista.AgregarFinal("Cuatro");
            lista.AgregarFinal("Cinco");
            lista.AgregarFinal("Seis");
            Console.WriteLine(lista.Recorrer());


            Console.WriteLine("Valor anterior de Cinco");
            Console.WriteLine(lista.BuscarAnterior("Cinco").Valor);
            */
            Console.ReadKey();
        }
}
}
