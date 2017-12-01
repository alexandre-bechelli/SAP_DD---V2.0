using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP_DD_V2
{
    public partial class Ls_ordem : Form
    {
        public Ls_ordem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operador form3 = new Operador();
            form3.Show();
            this.Dispose();
        }
    }
}
