using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Proyecto_Factura
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Errortxtbox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where id_usuario= " + VentanaLogin.Codigo;
            DataSet ds;
           ds = utilidades.Ejecutar(cmd);

            lblLeAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoCli.Text.Trim()) == false)
                {
                    string cmd = string.Format("Select Nom_cli from cliente where id_clientes='{0}'", txtCodigoCli.Text.Trim());

                    DataSet ds = utilidades.Ejecutar(cmd);

                    txtcliente.Text = ds.Tables[0].Rows[0]["Nom_cli"].ToString().Trim();
                    txtCodigoPro.Focus();
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static int contador_fila = 0; 
        private void BtnColocar_Click(object sender, EventArgs e)
        {
            if (utilidades.ValidarFormulario(this,errorProvider1)==false)
            {
                bool existe = false;
                int num_fila = 0;
                if (contador_fila == 0 )
                {
                    dataGridView1.Rows.Add(txtCodigoPro.Text, txtDesPro.Text, txtPreciopro.Text, txtcantidad.Text); 
                    double importe = Convert.ToDouble(dataGridView1.Rows[contador_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contador_fila].Cells[3].Value);// convercion para calcuar el importe 
                    dataGridView1.Rows[contador_fila].Cells[4].Value = importe;

                    contador_fila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dataGridView1.Rows)//se creo una variable de tipo fila 
                    {
                        if (Fila.Cells[0].Value.ToString()== txtCodigoPro.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;// para obtener la posicion de la fila 
                        }
                    }
                    if (existe==true )
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value =(Convert.ToDouble(txtcantidad.Text)+ Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);// convercion para calcuar el importe 

                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;


                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodigoPro.Text, txtDesPro.Text, txtPreciopro.Text, txtcantidad.Text);
                        double importe = Convert.ToDouble(dataGridView1.Rows[contador_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contador_fila].Cells[3].Value);// convercion para calcuar el importe 
                        dataGridView1.Rows[contador_fila].Cells[4].Value = importe;

                        contador_fila++;
                    }
                }
            }
        }
    }
}
