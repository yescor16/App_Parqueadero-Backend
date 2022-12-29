using App.Dominio.IRepositorio;
using App.Transversal.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructura.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : EntidadBase
    {

        protected readonly DatabaseContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repositorio(DatabaseContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        //Operaciones
        public bool actualizar(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            context.Update(entity);
            context.SaveChanges();
            return true;
        }

        public T crear(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            entities.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public bool eliminar(int id)
        {
            if (id.Equals(null)) throw new ArgumentNullException("entity");

            T entity = entities.SingleOrDefault(s => s.ID == id);
            entities.Remove(entity);
            context.SaveChanges();
            return true;
        }

        public List<T> obtenerListadoPorCondicion(Expression<Func<T, bool>> condicion)
        {
            return context.Set<T>().Where(condicion).ToList();
        }

        public T obtenerPorCondicion(Expression<Func<T, bool>> condicion)
        {
            return context.Set<T>().FirstOrDefault(condicion);
        }

        public T obtenerPorId(int id)
        {
            return entities.SingleOrDefault(s => s.ID == id);
        }

        public IEnumerable<T> obtenerTodo()
        {
            return entities.AsEnumerable();
        }



        public List<T> EjecutarSPSinParametros(string nombreSP)
        {
            var query = $@"EXECUTE " + nombreSP;

            var sqlParameters = new List<SqlParameter>();
            return entities
                 .FromSqlRaw(query)
                 .AsNoTracking()
                 .ToList();
        }


      
    }
}
