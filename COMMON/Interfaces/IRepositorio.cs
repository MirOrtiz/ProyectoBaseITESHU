using COMMON.Entidades;
using COMMON.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Interfaces
{
    public interface IRepositorio<T> where T : Base
    {
        /// <summary>
        /// Obtiene el error después de una operación realizada
        /// </summary>
        string Error { get; }
        /// <summary>
        /// Obtiene todos los elementos de la tabla
        /// </summary>
        List<T> Get { get; }
        /// <summary>
        /// Obtiene el elemento correspondiente al Id proporcionado
        /// </summary>
        /// <param name="id">Id del elemento a obtener</param>
        /// <returns>Elemento correspondiente al Id</returns>
        T GetById(int id);

        /// <summary>
        /// Inserta un elemento en la tabla
        /// </summary>
        /// <param name="item">Elemento a insertar</param>
        /// <returns>Elemento insertado, si no se pudo insertar regresa null</returns>
        T Insert(T entidad);

        /// <summary>
        /// Actualiza el elemento en base al Id
        /// </summary>
        /// <param name="entidad">Entidad con los cambios a actualizar</param>
        /// <returns>Entidad actualizada, si no se pudo actualizar regresa null</returns>
        T Update(T entidad);
        /// <summary>
        /// Elimina el elemento correspondiente al id proporcionado
        /// </summary>
        /// <param name="id">Id del elemento a eliminar</param>
        /// <returns>Indica si el elemento pudo ser eliminado</returns>
        bool Delete(int id);
        /// <summary>
        /// Ejecuta la consulta SQL
        /// </summary>
        /// <typeparam name="M">Modelo que mapea el resultado de la consulta</typeparam>
        /// <param name="sql">consulta SQL a ejecutar</param>
        /// <returns>Resultado de la consulta, si hay error regresa null</returns>
        List<M> Query<M>(string sql) where M : class;
        
    }
}
