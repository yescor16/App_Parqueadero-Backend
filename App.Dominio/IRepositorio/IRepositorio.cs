using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio.IRepositorio
{
    public interface IRepositorio<T> where T : EntidadBase
    {
        T crear(T entity);
        bool eliminar(int Id);
        bool actualizar(T entity);

        T obtenerPorId(int id);
        IEnumerable<T> obtenerTodo();
        T obtenerPorCondicion(Expression<Func<T, bool>> condicion);
        List<T> obtenerListadoPorCondicion(Expression<Func<T, bool>> condicion);

        List<T> EjecutarSPSinParametros(string nombreSP);
    }
}
