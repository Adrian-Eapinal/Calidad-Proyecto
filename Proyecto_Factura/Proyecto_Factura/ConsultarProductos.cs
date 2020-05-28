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
    public partial class ConsultarProductos : Consultas
    {
        public ConsultarProductos()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {

                    DataSet ds;


                    string cmd = "select * from Articulo where Nom_pro  LIKE ('%" + textBox1.Text.Trim() + "%')";
                    ds = utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {

                    MessageBox.Show("Ha ocurrido un error:" + error.Message);
                }
            }
        }

        private void ConsultarProductos_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = LLenarDataGV("Articulo").Tables[0];// para llenar el datagridview con el datasource
        }
    }
}
