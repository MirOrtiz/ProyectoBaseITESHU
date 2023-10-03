using COMMON.Entidades;
using COMMON.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using System.Reflection;
using System.Text;

namespace DAL
{
    public class Repositorio<T> : IRepositorio<T> where T : Base
    {
        private SqlConnection conexion;
        private AbstractValidator<T> validator;
        private string tabla;

        public Repositorio(string cadenaConexion, AbstractValidator<T> validador)
        {
            conexion = new SqlConnection(cadenaConexion);
            tabla = typeof(T).Name;
            validator = validador;
        }
        public string Error { get; private set; }

        public List<T> Get
        {
            get
            {
                try
                {
                    return ObtenerDatos<T>($"Select * from {tabla} FOR JSON AUTO");
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return null;
                }
            }
        }

        private List<M> ObtenerDatos<M>(string sql) where M : class
        {
            try
            {
                conexion.Open();
                StringBuilder json = new StringBuilder();
                if (!sql.ToLower().Contains("for json auto"))
                {
                    sql += " FOR JSON AUTO";
                }
                using (var cmd = new SqlCommand(sql, conexion))
                {
                    var reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        json.AppendLine("[]");
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            json.AppendLine(reader.GetString(0).ToString());
                        }
                    }
                }
                conexion.Close();
                Error = "";
                return JsonConvert.DeserializeObject<List<M>>(json.ToString());
            }
            catch (Exception ex)
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
                Error = ex.Message;
                return null;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand($"Delete from {tabla} where Id={id}", conexion);
                int r = cmd.ExecuteNonQuery();
                conexion.Close();
                Error = "";
                return r == 1;
            }
            catch (Exception ex)
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
                Error = "";
                return false;
            }
        }

        public T GetById(int id)
        {
            return ObtenerDatos<T>($"Select * from {tabla} where Id={id}").SingleOrDefault();
        }

        public List<M> Query<M>(string sql) where M : class
        {
            return ObtenerDatos<M>(sql);
        }

        public T Update(T entidad)
        {
            try
            {
                entidad.idEmpleado=int.MaxValue;
                ValidationResult validationResult = validator.Validate(entidad);
                if (validationResult.IsValid)
                {
                    List<T> datos = new List<T>();
                    datos.Add(entidad);
                    DataTable table = ToDataTable<T>(datos);
                    conexion.Open();
                    int r = 0;
                    SqlDataAdapter da = new SqlDataAdapter($"Select * from {tabla} where Id={entidad.idEmpleado}", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dt.Rows[0].BeginEdit();
                    foreach (DataColumn colum in dt.Columns)
                    {
                        dt.Rows[0][colum.ColumnName] = table.Rows[0][colum.ColumnName];
                    }
                    dt.Rows[0].EndEdit();
                    var cb = new SqlCommandBuilder(da);
                    da.AcceptChangesDuringUpdate = true;
                    r = da.Update(dt);
                    conexion.Close();
                    Error = "";
                    return r == 1 ? GetById(entidad.idEmpleado) : null;
                }
                else
                {
                    string errors = "Error de validación: ";
                    foreach (var error in validationResult.Errors)
                    {
                        errors += error.ErrorMessage + ". ";
                    }
                    Error = errors;
                    return null;
                }

            }
            catch (Exception ex)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                Error = ex.Message;
                return null;
            }
        }

        public T Insert(T entidad)
        {
            try
            {
                entidad.idEmpleado = int.MaxValue;
                
                ValidationResult validationResult = validator.Validate(entidad);
                if (validationResult.IsValid)
                {
                    List<T> datos = new List<T>();
                    datos.Add(entidad);
                    DataTable table = ToDataTable<T>(datos);
                    conexion.Open();
                    int r = 0;
                    using (var cmd = new SqlCommand($"Select * from {tabla}", conexion))
                    {
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            using (var cb = new SqlCommandBuilder(da))
                            {
                                r = da.Update(table);
                            }
                        }
                    }
                    conexion.Close();
                    Error = "";
                    return r == 1 ? ObtenerDatos<T>($"select top 1 * from {tabla} order by Id desc FOR JSON AUTO").SingleOrDefault() : null;
                }
                else
                {
                    string errors = "Error de validación: ";
                    foreach (var error in validationResult.Errors)
                    {
                        errors += error.ErrorMessage + ". ";
                    }
                    Error = errors;
                    return null;
                }

            }
            catch (Exception ex)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                Error = ex.Message;
                return null;
            }
        }

        protected DataTable ToDataTable<M>(List<M> items)
        {
            DataTable dataTable = new DataTable(typeof(M).Name);

            PropertyInfo[] Props = typeof(M).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (M item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
