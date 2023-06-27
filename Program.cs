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
            List<ListaLigada> Grafo = new List<ListaLigada>();

            ListaLigada verticeG = new ListaLigada("G");
            ListaLigada verticeH = new ListaLigada("H");
            ListaLigada verticeI = new ListaLigada("I");
            ListaLigada verticeJ = new ListaLigada("J");
            ListaLigada verticeK = new ListaLigada("K");
            ListaLigada verticeL = new ListaLigada("L");
            verticeG.Relacionar(verticeK);
            verticeG.Relacionar(verticeJ);
            verticeH.Relacionar(verticeG);
            verticeH.Relacionar(verticeK);
            verticeI.Relacionar(verticeG);
            verticeJ.Relacionar(verticeI);
            verticeK.Relacionar(verticeH);
            verticeL.Relacionar(verticeI);
            verticeL.Relacionar(verticeK);

            Grafo.Add(verticeG);
            Grafo.Add(verticeH);
            Grafo.Add(verticeI);
            Grafo.Add(verticeJ);
            Grafo.Add(verticeK);
            Grafo.Add(verticeL);

        }
}
}
