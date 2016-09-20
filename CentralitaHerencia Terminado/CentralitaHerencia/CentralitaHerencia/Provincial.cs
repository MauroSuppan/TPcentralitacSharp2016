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

            float aux = 0;
            float aux_Franja=0;
            switch (this._FranjaHoraria)
            {
                case Franja.Franja_1:
                    aux_Franja = 0.99f;
                    break;
                case Franja.Franja_2:
                    aux_Franja = 1.25f;
                    break;
                case Franja.Franja_3:
                    aux_Franja = 0.66f;
                    break;
                
            }

            aux= this.Duracion * aux_Franja;
            return aux;

        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero Origen: " + this._nroOrigen);
            sb.AppendLine("Numero Destino: " + this._nroDestino);
            sb.AppendLine("Duracion: " + this._duracion);
            sb.AppendLine("Franja Horaria: " + this._FranjaHoraria);
            sb.AppendLine("Precio de costo: " + this.CostoLLamada);
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
