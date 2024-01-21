using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DBIIRecordCompany.datos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BdRecordCompany.OracleConection
{
    internal class Connection
    {
        Data dt = new Data();
        public DataSet selectAll(string tableName)
        {
            DataSet myDS = new DataSet();
            string consulta;
            consulta = "select * from recordcompany";
            myDS = dt.ExecuteSELECT(consulta);
            return myDS;
        }

        public int insertRCompany(int rcCod, string rcName, string rcType)
        {
            int succes = 0;
            string consulta;
            consulta = "INSERT INTO RecordCompany(rcCod, rcName, rcType) VALUES(" + rcCod + ",'" + rcName + "','" + rcType + "')";
            succes = dt.ExecuteDML(consulta);
            return succes;
        }


        public int insertMProducer(int profCard, string artisticName, string yearsExp, string categoryExp)
        {
            int succes = 0;
            string consulta;
            consulta = "INSERT INTO musicproducer(profCard, artisticName, yearsExp,categoryExp) VALUES(" + profCard + ",'" + artisticName + "','" + yearsExp + "','" + categoryExp + "')";
            succes = dt.ExecuteDML(consulta);
            return succes;
        }
        public int insertWork(int rcCod, int profCard, DateTime startDate)
        {
            try
            {
                if (!existRCompany(rcCod)) throw new InvalidOperationException("No existen Compañías Musicales identificadas con el código ingresado!");
                if (!existMProducer(profCard)) throw new InvalidOperationException("No existen Productores Musicales identificados con la tarjeta profesional ingresada!");

                string formattedDate = startDate.ToString("yyyy-MM-dd HH:mm:ss");
                string consulta = $"INSERT INTO Works (rcCod, profCard, startDate) VALUES ({rcCod}, {profCard}, TO_DATE('{formattedDate}', 'YYYY-MM-DD'))";

                int success = dt.ExecuteDML(consulta);
                return success;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar trabajo: {ex.Message}");
                return 0; // O cualquier otro valor que indique fallo
            }
        }

        public int insertWork(int rcCod, int profCard, string startDate)
        {
            try
            {
                if (!existRCompany(rcCod)) throw new InvalidOperationException("No existen Compañías Musicales identificadas con el código ingresado!");
                if (!existMProducer(profCard)) throw new InvalidOperationException("No existen Productores Musicales identificados con la tarjeta profesional ingresada!");

                string consulta = $"INSERT INTO Works (rcCod, profCard, startDate) VALUES ({rcCod}, {profCard}, TO_DATE('{startDate}', 'YYYY-MM-DD'))";

                int success = dt.ExecuteDML(consulta);
                return success;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar trabajo: {ex.Message}");
                return 0; // O cualquier otro valor que indique fallo
            }
        }
        public int insertWork(int rcCod, int profCard, string startDate, string finalDate)
        {
            try
            {
                if (!existRCompany(rcCod)) throw new InvalidOperationException("No existen Compañías Musicales identificadas con el código ingresado!");
                if (!existMProducer(profCard)) throw new InvalidOperationException("No existen Productores Musicales identificados con la tarjeta profesional ingresada!");

                string consulta = $"INSERT INTO Works (rcCod, profCard, startDate, finalDate) VALUES ({rcCod}, {profCard}, TO_DATE('{startDate}', 'YYYY-MM-DD'), TO_DATE('{finalDate}', 'YYYY-MM-DD'))";

                int success = dt.ExecuteDML(consulta);
                return success;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar trabajo: {ex.Message}");
                return 0; // O cualquier otro valor que indique fallo
            }
        }


        public bool existRCompany(int RCCod)
        {
            DataSet myDS = new DataSet();
            string consulta = "SELECT * FROM recordcompany WHERE rccod = " + RCCod;
            myDS = dt.ExecuteSELECT(consulta);

            // Verificar si el DataSet tiene al menos una fila
            return (myDS.Tables.Count > 0 && myDS.Tables[0].Rows.Count > 0);
        }
        public bool existMProducer(int profCard)
        {
            DataSet myDS = new DataSet();
            string consulta = "SELECT * FROM MusicProducer WHERE profCard = " + profCard;
            myDS = dt.ExecuteSELECT(consulta);

            // Verificar si el DataSet tiene al menos una fila
            return (myDS.Tables.Count > 0 && myDS.Tables[0].Rows.Count > 0);
        }
        public DataSet GetRecordsByStartDate(DateTime startDate)
        {
            DataSet myDS = new DataSet();
            try
            {

                string formattedDate = startDate.ToString("yyyy-MM-dd");
                string consulta = $@"SELECT rc.rcCod, rc.rcName, mp.profCard, mp.artisticName, mp.categoryexp, w.startDate, w.finalDate
                                FROM RecordCompany rc
                                JOIN Works w ON rc.rcCod = w.rcCod
                                JOIN MusicProducer mp ON w.profCard = mp.profCard
                                WHERE TRIM(w.startDate) = TO_DATE('{formattedDate}', 'YYYY-MM-DD')";

                myDS = dt.ExecuteSELECT(consulta);

                if (myDS.Tables.Count == 0 && myDS.Tables[0].Rows.Count == 0)
                {   
                    throw new InvalidOperationException($"No se encontraron registros para la fecha: {startDate.ToString("yyyy-MM-dd")}");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al realizar la consulta: {ex.Message}");
            }
            return myDS;
        }


        public int getActiveContracts()
        {
            string consulta = "SELECT COUNT(*) AS Contratos_Vigentes FROM Works WHERE finalDate IS NOT NULL";
            DataSet result = dt.ExecuteSELECT(consulta);

            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(result.Tables[0].Rows[0]["Contratos_Vigentes"]);
            }
            else
            {
                return 0;
            }
        }
    }



}
