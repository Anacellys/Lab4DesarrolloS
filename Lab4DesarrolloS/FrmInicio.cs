using Lab4DesarrolloS.Admistrador;
using Lab4DesarrolloS.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4DesarrolloS
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdm fm = new FrmPrincipalAdm(); 
          
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrinciplaCln frmc = new FrmPrinciplaCln();
            frmc.Show();
        }
    }
}
