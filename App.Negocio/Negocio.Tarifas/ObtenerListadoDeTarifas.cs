using App.Dominio.IUnidadDeTrabajo;
using App.Negocio.Util;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Negocio.Tarifas
{
    public class ObtenerListadoDeTarifas
    {
        private IUnidadDeTrabajo<Tarifa> TarifaRepositorio;
        public ObtenerListadoDeTarifas(IUnidadDeTrabajo<Tarifa> _repositorio)
        {
            this.TarifaRepositorio = _repositorio;
        }
        public IEnumerable<Tarifa> Ejecutar()
        {
            try
            {
                return TarifaRepositorio.repositorio<Tarifa>().obtenerTodo();
            }
            catch (Exception error)
            {
                throw new Exception(new Excepcion().setError(Excepciones.ObtenerListadoDeTarifas), error);
            }
           
        }
        
    }
}
