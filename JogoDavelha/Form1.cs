using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        int countCLicks;

        public Form1()
        {

            InitializeComponent();
            countCLicks = 0;
            Regras.NewGame(this);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();            
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            this.Close();
        }

        private void buttonSClick(object sender, EventArgs e)
        {
            if(countCLicks < 9 && Regras.IsGameRuning)
                countCLicks = Regras.SetLettres(sender, countCLicks);
            
            Regras.WinnerGame(this);

            if(countCLicks > 8 && !Regras.Winner)
                Regras.HashGame(countCLicks,this);
        }
    }
}
