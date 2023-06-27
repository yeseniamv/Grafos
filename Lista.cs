using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;
       

        public Lista()
        {
            nodoInicial = new Nodo();
        }

        public string Llave()
        {
            string dato;
            dato = nodoInicial.Siguiente.Valor;

            return dato;
        }
        
        public string Recorrer()
        {
            string datos = string.Empty;
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datos += nodoActual.Valor + "\n";
            }
            return datos;
        }
        public void Agregar(string valor)
        {
            nodoActual = nodoInicial;
           
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                
            }
            Nodo nodoNuevo = new Nodo(valor);
            nodoActual.Siguiente = nodoNuevo;
        }
        
    }
}
