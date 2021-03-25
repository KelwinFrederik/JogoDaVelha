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
        public static string _Jog01;

        public Form2()
        {
            InitializeComponent();

            JogO1.CheckStateChanged += CheckBoxEventChanged;
            JogX1.CheckStateChanged += CheckBoxEventChanged;

        }

        private void btn_PlayGame_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tb_NameX.Text) && !string.IsNullOrEmpty(Tb_NameO.Text))
            {
                _Jog01 = JogO1.Checked ? Tb_NameO.Text : Tb_NameX.Text;
                this.SetVisibleCore(false);
                Form1 fomr1 = new Form1() { Visible = true };
                fomr1.LabelNomeX.Text = Tb_NameX.Text;
                fomr1.LabelNomeO.Text = Tb_NameO.Text;
            }
            else
                MessageBox.Show("Digite um nome para Cada Jogador");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CheckBoxEventChanged(object obj, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)obj;
            
            if (checkBox.Name == JogO1.Name)
            {
                if (checkBox.CheckState == CheckState.Checked)
                    JogX1.CheckState = CheckState.Unchecked;
                if (checkBox.CheckState == CheckState.Unchecked)
                    JogX1.CheckState = CheckState.Checked;
            }
            else if(checkBox.Name == JogX1.Name)
            {
                if (checkBox.CheckState == CheckState.Checked)
                    JogO1.CheckState = CheckState.Unchecked;
                if (checkBox.CheckState == CheckState.Unchecked)
                    JogO1.CheckState = CheckState.Checked;
            }
        }
    }
}
