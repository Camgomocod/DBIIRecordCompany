using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DBIIRecordCompany.datos
{
    class Datos
    {
        /*paso 1: crear la cadena de conexión*/
        string cadenaConexion = "Data Source=localhost;Persist Security Info=True;User ID=user_developer;Password=oracle;";


        //paso 2: crear el metodo que eejecuta una operación DML
        //insert, update, delete
        public int ejecutarDML(string consulta)
        {
            int filasAfectadas = 0;
            //paso 1: creo una conexion
            OracleConnection miConexion = new OracleConnection(cadenaConexion);

            //paso 2: creo un objeto de tipo Comando el cual estable
            //la instruccion sql que se ejecutará en la BD

            OracleCommand miComando = new OracleCommand(consulta, miConexion);

            //paso 3: abro la conexion
            miConexion.Open();

            /*paso 4: ejecuto el comando. Al ejecutar el comando
             * el devuelve un valor entero que simboliza las filas
             * afectadas en la operacion DML(insert,update,delete). */
            filasAfectadas = miComando.ExecuteNonQuery();

            //paso 5: cerrar la conexion
            miConexion.Close();

            //paso 6: retorno las filas afectadas por la operacion DML
            return filasAfectadas;
        }

        //metodo para ejecutar sentencias SELECT
        public DataSet ejecutarSELECT(string consulta)
        {
            //paso 1: creo un objeto vacio de tipo DataSet
            DataSet ds = new DataSet();


            //paso 2: creo un adaptador
            OracleDataAdapter miAdaptador = new OracleDataAdapter(consulta, cadenaConexion);
            //paso 3: llenar el data set
            miAdaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }

    }
}