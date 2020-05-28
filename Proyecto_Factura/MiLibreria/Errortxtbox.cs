using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiLibreria
{
    public partial class Errortxtbox : TextBox
    {
        public Errortxtbox()
        {
            InitializeComponent();
        }

        public Boolean validar
        {
            set;
            get;
        }
        public Boolean SoloNumeros
        {
            set;
            get;
        }
           

    }
}
