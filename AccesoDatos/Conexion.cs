﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Conexion : IDisposable {
        public Conexion() {
        }
        public SqlConnection crearConexion() {
            String strConn = @"Server=INSTRUCTOR-403\SQLEXPRESS;Database=Libros;Trusted_Connection=True;";
            conn = new SqlConnection(strConn);

            try {
                conn.Open();
            }
            catch (Exception ex) {
                throw ex;
            }
            return conn;
        }
        public void Dispose() {
            try {
                conn.Close();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        private SqlConnection conn;
    }
}
