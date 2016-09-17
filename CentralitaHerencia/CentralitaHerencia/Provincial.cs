using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    class Provincial : Llamada
    {
        protected Franja _FranjaHoraria;

        public float CostoLLamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float aux;
            aux = this._duracion * (float)_FranjaHoraria;
            return aux;

        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Numero Origen: " + this._nroOrigen);
            sb.Append("Numero Destino: " + this._nroDestino);
            sb.Append("Duracion: " + this._duracion);
            sb.Append("Franja Horaria: "+this._FranjaHoraria);
            sb.Append("Precio de costo: " + this.CostoLLamada);
            Console.WriteLine(sb);
        }

        public Provincial(Franja miFranja, Llamada unaLLamada): this(unaLLamada.NroOrigen,miFranja, unaLLamada.Duracion,unaLLamada.NroDestino)
        { 

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino): base (origen,destino,duracion)
        {
            this._FranjaHoraria = miFranja;
        }

    }
}
