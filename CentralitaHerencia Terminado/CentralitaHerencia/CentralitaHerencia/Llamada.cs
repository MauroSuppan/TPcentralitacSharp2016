using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

       

        public float Duracion
        {
            get { return this._duracion; }
        }

        public string  NroDestino
        {
            get { return this._nroDestino; }
        
        }

        public string NroOrigen
        {
            get { return this._nroOrigen; }
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            
            int aux=0;
            aux = uno._duracion.CompareTo(dos._duracion);
            return aux;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero origen: " + this.NroOrigen);
            sb.AppendLine("Numero Destino: " + this.NroDestino);
            sb.AppendLine("Duracion: " + this.Duracion);
            Console.WriteLine(sb);

           
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
 
        }
    }
}
