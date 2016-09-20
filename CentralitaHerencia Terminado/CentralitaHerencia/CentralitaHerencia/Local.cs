using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    class Local : Llamada
    {
        protected float _costo;

        public float CostoLlamada
        {
            get {
                float aux;
                aux = this.CalcularCosto();
                return aux;
                }
        }

        private float CalcularCosto()
        {
            float aux;
            aux = this._duracion * this._costo;
            return aux;
        }

        public Local(Llamada unaLLamada, float costo) : this (unaLLamada.NroOrigen,unaLLamada.Duracion,unaLLamada.NroDestino,costo) 
        { 
           
            
        }

        public Local(string origen, float duracion, string destino, float costo) : base(origen,destino,duracion)

        {
            this._costo = costo;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero Origen: "+ this._nroOrigen);
            sb.AppendLine("Numero Destino: " + this._nroDestino);
            sb.AppendLine("Duracion: " + this._duracion.ToString());
            sb.AppendLine("Precio de costo: " + this.CostoLlamada);
            Console.WriteLine(sb);
        

        
        }



    }
}
