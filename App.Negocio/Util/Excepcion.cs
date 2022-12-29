using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Util
{
    class Excepcion
    {
        string error { get; set; }
       public string setError(Excepciones excepcion)
        {
            switch (Convert.ToInt32(excepcion))
            {
                case 1: return "Error obteniendo el listado de los tipos de vehiculos";
                case 2: return "Error obteniendo el listado de los tipos de vehiculos";
                default:return "Error desconocido";
            }
        }
    }
}
