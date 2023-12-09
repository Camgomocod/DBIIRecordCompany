using DBIIRecordCompany.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBIIRecordCompany.logica
{
    internal class Empresa
    {
        Datos dt = new Datos();

        public int ingresarEmpresa(int id, string nombre, string tipo)
        {
            int resultado;
            string consulta;
            consulta = "INSERT INTO recordCompany(rccod, rcname, rctype) VALUES ('" + id + "','" + nombre + "', '" + tipo + "')";

            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

    }
}
