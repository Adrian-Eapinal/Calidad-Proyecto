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
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }
        public override bool Guardar()
        {
            try
            {
                string cmd = string.Format("EXEC ActualizarClientes '{0}','{1}','{2}'", txtidcli.Text.Trim(), txtNomcli.Text.Trim(), txtApecli.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha guradado correctamente!..");
                return true;

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error:" + error.Message);
                return false;
            }
        }
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarClientes '{0}'", txtidcli.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado correctamente");
            }
            catch (Exception error)
            {

                MessageBox.Show("Ha ocurrido un error" + error.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtidcli.Clear();
            txtApecli.Clear();
            txtNomcli.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
