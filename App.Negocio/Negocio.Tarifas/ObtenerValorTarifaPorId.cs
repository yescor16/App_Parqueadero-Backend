using App.Dominio.IUnidadDeTrabajo;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Negocio.Negocio.Tarifas
{
    public class ObtenerValorTarifaPorId
    {
        private IUnidadDeTrabajo<RegistroParqueadero> RegistroRepositorio;
        public ObtenerValorTarifaPorId(IUnidadDeTrabajo<RegistroParqueadero> _repositorio)
        {
            this.RegistroRepositorio = _repositorio;
        }
        public RegistroParqueadero Ejecutar(RegistroParqueadero _registroParqueadero)
        {
            RegistroParqueadero result =  RegistroRepositorio.repositorio<RegistroParqueadero>().obtenerPorCondicion(r => r.ID == _registroParqueadero.ID);
            result.aplicaDescuento = _registroParqueadero.aplicaDescuento;
            result.fecha_salida = _registroParqueadero.fecha_salida;
            DateTime fechaIngreso = Convert.ToDateTime(result.fecha_ingreso);
            DateTime fechaSalida =  Convert.ToDateTime(_registroParqueadero.fecha_salida);
            var minutos = (fechaSalida - fechaIngreso).TotalMinutes;
            result.minutos_transcurridos = Convert.ToInt32(minutos);
            int calculo = 0;
            if (result.aplicaDescuento)
            {
                calculo = result.minutos_transcurridos * result.valor_tarifa;
                calculo = calculo - Convert.ToInt32(calculo * 0.3);
                result.valor_tiempo = calculo;
            }
            else
            {
                result.valor_tiempo = result.minutos_transcurridos * result.valor_tarifa;
            }
            
            return result;
        }
    }
}
