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
    public partial class MantenimientoProductos :Mantenimiento
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        public override bool Guardar()
        {
            if (utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizarArticulos '{0}','{1}','{2}'", txtidpro.Text.Trim(), txtdescripcion.Text.Trim(), txtprecio.Text.Trim());
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
            else
            {
                return false;
            }
           
        }
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulos '{0}'", txtidpro.Text.Trim());
                utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado correctamente");
            }
            catch (Exception error)
            {

             MessageBox.Show("Ha ocurrido un error"+error.Message);
            }
        }

        private void Txtidpro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtidpro.Clear();
            txtdescripcion.Clear();
            txtprecio.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
