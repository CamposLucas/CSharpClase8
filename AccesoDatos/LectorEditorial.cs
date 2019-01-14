using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class LectorEditorial
    {
        public LectorEditorial(SqlConnection conn) {
            this.conn = conn;
        }
        public List<DTO.Editorial> obtenerEditoriales() {
            var listaRet = new List<DTO.Editorial>();

            SqlCommand comando = conn.CreateCommand();
            comando.CommandText = "select Editorial_ID, Nombre from Editorial";
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read()) {
                var editorial = new DTO.Editorial();
                editorial.id = lector["Editorial_ID"].ToString();
                editorial.nombre = lector["Nombre"].ToString();
                listaRet.Add(editorial);
            }
            return listaRet;
        }
        private SqlConnection conn;
    }
}
