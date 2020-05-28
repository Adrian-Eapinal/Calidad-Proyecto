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
    public partial class ConsultarClientes : Consultas

    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("Cliente").Tables[0];// para llenar el datagridview con el datasource
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim())==false)
            {
                try
                {

                    DataSet ds;


                    string cmd = "select * from cliente where Nom_cli LIKE ('%" + textBox1.Text.Trim() + "%')";
                    ds = utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {

                    MessageBox.Show("Ha ocurrido un error:" + error.Message);
                }
            }
        }
    }
}
