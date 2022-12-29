using App.Dominio.IUnidadDeTrabajo;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Negocio.OperacionesRegistroParqueadero
{
    public class SalidaRegistroParqueadero
    {
        private IUnidadDeTrabajo<RegistroParqueadero> RegistroParqueaderoRepositorio;
        public SalidaRegistroParqueadero(IUnidadDeTrabajo<RegistroParqueadero> _repositorio)
        {
            this.RegistroParqueaderoRepositorio = _repositorio;
        }
        public bool Ejecutar(RegistroParqueadero _registroParqueadero)
        {
            return RegistroParqueaderoRepositorio.repositorio<RegistroParqueadero>().actualizar(_registroParqueadero);
        }
    }
}
