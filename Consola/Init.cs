using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
using AccesoDatos.DTO;

namespace Consola
{
    public class Init
    {
        public static void Main(String[] args) {
            var conn = new Conexion();
            var sqlConn = conn.crearConexion();
            var lectorEditorial = new LectorEditorial(sqlConn);
            foreach (Editorial ed in lectorEditorial.obtenerEditoriales()) {
                Console.WriteLine(ed.id);
                Console.WriteLine(ed.nombre);
            }
            conn.Dispose();
        }
    }
}
