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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String login =(Convert.ToString (login_bx.SelectedItem));
            String Senha = (senha_bx.Text);
            
            switch (login)
            {
                case "Operador":
                    Operador form = new Operador();
                    form.ShowDialog();
                    this.Dispose();
              
                    break;
                default:
                    Ls_ordem teste = new Ls_ordem();
                    teste.MdiParent = this;
                    teste.Show();
                    this.Dispose();
                   


                    break;

            }

        }

    }
}
