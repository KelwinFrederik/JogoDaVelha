using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JogoDaVelha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_PlayGame_Click(object sender, EventArgs e)
        {
            if (Tb_NameX.Text != "" && Tb_NameO.Text != "")
            {
                Form1 fomr1 = new Form1() { Visible = true };
                fomr1.LabelNomeX.Text = Tb_NameX.Text;
                fomr1.LabelNomeO.Text = Tb_NameO.Text;
                this.SetVisibleCore(false);
            }
            else
                MessageBox.Show("Digite um nome para Cada Jogador");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
