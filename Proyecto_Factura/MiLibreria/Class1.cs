using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;

            foreach(Control item in Objeto.Controls)
            {
                if (item is Errortxtbox)
                {
                    Errortxtbox Obj = (Errortxtbox)item;
                    if (Obj.validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "No puede estar vacio");
                            HayErrores = true;
                        }
                    }
                    if(Obj.SoloNumeros== true)
                    {
                        int contador = 0, letrasEncontradas = 0;

                        foreach(char letra  in Obj.Text.Trim())
                        {
                            if (char.IsLetter(Obj.Text.Trim(), contador))
                            {
                                letrasEncontradas++;
                            }
                            contador++;
                        }

                        if (letrasEncontradas!=0)
                        {
                            HayErrores = true;
                            ErrorProvider.SetError(Obj, "Este campo solo acepta numeros");
                        }    
                    }
                }
            }
            return HayErrores;
        }

    }
}
