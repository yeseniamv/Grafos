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
            
            Lista nodoA = new Lista();            
            Lista nodoB = new Lista();            
            Lista nodoC = new Lista(); 

            nodoA.Agregar("X");
            nodoA.Agregar("Y");
            nodoB.Agregar("W");
            nodoC.Agregar("M");

            List<String> coleccion = new List<String>
            {
                nodoA.Llave(),
                nodoB.Llave(),
                nodoC.Llave()
            };
            Console.WriteLine("Valores en colección");
            foreach (String s in coleccion) {  Console.WriteLine(s); }
            
            Console.WriteLine("Valores en nodoA");
            Console.WriteLine(nodoA.Recorrer());
            Console.WriteLine("Valores en nodoB");
            Console.WriteLine(nodoB.Recorrer());
            Console.WriteLine("Valores en nodoC");
            Console.WriteLine(nodoC.Recorrer());

            Console.ReadKey();
        }
}
}
