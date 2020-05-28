using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public class utilidades
    {

        public static DataSet Ejecutar(string cmd)// desde aqui se va a ser todas las inserciones a la BD
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");//creacion de instancia para pasar la cadena de conexion.
            Con.Open();

            DataSet DS = new DataSet();// Para almacenar los datos 
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);// para adaptar los datos que me devuelva la consulta a la BD
            DP.Fill(DS);//Para que el SqldataAdapter me llene el DataSet

            Con.Close();// Es recomendable cerrar la conexion antes de devolver los datos.

            return DS;
        }   

    }
}
