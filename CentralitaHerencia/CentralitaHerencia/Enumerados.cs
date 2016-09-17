using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    public enum Franja
    {
        Franja_1= (int)0.99,
        Franja_2= (int)1.25,
        Franja_3= (int)0.66,
 
    }

    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas,
    }
}
