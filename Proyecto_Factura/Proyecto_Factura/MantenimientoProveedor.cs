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
    public partial class MantenimientoProveedor : Mantenimiento
    {
        public MantenimientoProveedor()
        {
            InitializeComponent();
        }
        public override bool Guardar()
        {
            try
            {
                string cmd = string.Format("EXEC ActualizarProveedores '{0}','{1}','{2}','{3}','{4}','{5}'", txtidproveedor.Text.Trim(), txtnomprov.Text.Trim(), txtapeprov.Text.Trim(), txttelprov.Text.Trim(), txtdirprov.Text.Trim(), txtcorprov.Text.Trim());
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
                string cmd = string.Format("EXEC EliminarProveedores '{0}'", txtidproveedor.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado correctamente");
            }
            catch (Exception error)
            {

                MessageBox.Show("Ha ocurrido un error" + error.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
