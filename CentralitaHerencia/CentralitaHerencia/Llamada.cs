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
            /*El método de clase OrdenarPorDuracion será utilizado 
           en el método Sort de la lista genérica de objetos del mismo tipo 
               (en la clase Centralita).
           */

         //retornar un int 
            int aux=0;
            return aux;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            //tiene que mostrar algo 

           
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
 
        }
    }
}
