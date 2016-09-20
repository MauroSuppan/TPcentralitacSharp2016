using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        


        public float GananciaPorLocal
        {
            get { return this.CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
          get { return this.CalcularGanancia(TipoLlamada.Provincial);}
        }

        public float GananciaTotal
        {
            get { return this.CalcularGanancia(TipoLlamada.Todas);}
        }

        public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
        }
        
        
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            Local auxLocal;
            Provincial auxProvincial;

            foreach (Llamada item in this.Llamadas)
            {
                if (item.GetType() == typeof(Local))
                {
                    auxLocal = (Local)item;
                    gananciaLocal += auxLocal.CostoLlamada;
                    
                }
                else if (item.GetType() == typeof(Provincial))
                {
                    auxProvincial = (Provincial)item;
                    gananciaProvincial += auxProvincial.CostoLLamada;
                }
            }

            if (tipo == TipoLlamada.Local)
            {
                return gananciaLocal;
            }
            else if (tipo == TipoLlamada.Provincial)
            {
                return gananciaProvincial;
            }
            else { return gananciaProvincial + gananciaLocal; }
            
       
        }
    

        public Centralita()
        { 
            _listaDeLlamadas = new List<Llamada>() ;
        }

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public void Mostrar()
        {
            Local auxLocal;
            Provincial auxProvincial;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine ("razon social: " + this._razonSocial);
            sb.AppendLine("Ganancia Total: " + this.GananciaTotal);
            sb.AppendLine("Ganancia Local: " + this.GananciaPorLocal);
            sb.AppendLine("Ganancia Provincial: " + this.GananciaPorProvincial);
         
            Console.WriteLine(sb);

            foreach (Llamada item in this.Llamadas)
            {
                if(item.GetType()== typeof (Local))
                {
                    auxLocal = (Local)item;
                    auxLocal.Mostrar();

                }
                if (item.GetType () == typeof (Provincial))
                {
                    auxProvincial = (Provincial)item;
                    auxProvincial.Mostrar();
                }
            }
            
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

    }

}
