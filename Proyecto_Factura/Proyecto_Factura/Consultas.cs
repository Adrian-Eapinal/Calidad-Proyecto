﻿using System;
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
    public partial class Consultas : Base
    {
        public Consultas()
        {
            InitializeComponent();
        }
        public DataSet LLenarDataGV(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT * FROM " + tabla);
            DS = utilidades.Ejecutar(cmd);

            return DS;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count==0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;// para procesar lo que se quiere 
                Close();
            }
        }
    }
}
