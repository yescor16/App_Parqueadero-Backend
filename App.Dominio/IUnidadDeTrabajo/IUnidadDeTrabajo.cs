using App.Dominio.IRepositorio;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio.IUnidadDeTrabajo
{
    public interface IUnidadDeTrabajo<T> where T :EntidadBase
    {

        void guardarContexto();
        IRepositorio<T> repositorio<T>() where T : EntidadBase;
    }
}
