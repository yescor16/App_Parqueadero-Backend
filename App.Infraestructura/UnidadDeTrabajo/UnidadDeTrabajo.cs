using App.Dominio.IRepositorio;
using App.Dominio.IUnidadDeTrabajo;
using App.Infraestructura.Repositorio;
using App.Transversal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructura.UnidadDeTrabajo
{
    public class UnidadDeTrabajo<T> : IUnidadDeTrabajo<T> where T : EntidadBase
    {
        public DatabaseContext context;
        public IRepositorio<T> _repository;


        public UnidadDeTrabajo(DatabaseContext context)
        {
            this.context = context;
            _repository = new Repositorio<T>(context);
        }
        public void guardarContexto()
        {
            context.SaveChanges();
        }

        public IRepositorio<T> repositorio<T>() where T : EntidadBase
        {
            return (Repositorio<T>)_repository;
        }

        
    }
}
