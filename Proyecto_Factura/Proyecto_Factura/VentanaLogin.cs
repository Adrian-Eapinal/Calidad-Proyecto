using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;
using System.Data;






namespace Proyecto_Factura
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }



        public static string Codigo = "";
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * from Usuarios WHERE account = '{0}' AND password = '{1}'", txtNomAcc.Text.Trim(), txtpass.Text.Trim());
                DataSet ds = utilidades.Ejecutar(CMD);//Nos  devuelve un dataset

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();


                if (cuenta==txtNomAcc.Text.Trim() && contra== txtpass.Text.Trim())
                {
                   if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"])== true)
                    {
                        VentanaAdmin VenAd = new VentanaAdmin();
                        this.Hide();
                        VenAd.Show();


                    }
                    else
                    {
                        VentanaUser VenUs = new VentanaUser();
                        this.Hide();
                        VenUs.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contrase;a incorrecta");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Usuario o contrase;a incorrecta");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
