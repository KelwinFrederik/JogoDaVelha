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
            countCLicks = 1;   
            On_PageLoad();
            Regras.NewGame(this);
        }
        

        private void On_PageLoad()
        {
            string information = $"jogador {Form2._Jog01} inicirá o jogo. \nBy.: Kelwin F. Alves";
            Label_Information.Text = information;
            LabelNomeO.TextChanged += Regras.SetFirstPlayer;
            LabelNomeX.TextChanged += Regras.SetFirstPlayer;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();            
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Tb_NameX.Text = LabelNomeX.Text;
            form2.Tb_NameO.Text = LabelNomeO.Text;

            form2.ShowDialog();
            this.Close();
        }

        private void buttonSClick(object sender, EventArgs e)
        {
            if(countCLicks <= 9 && Regras.IsGameRuning)
                countCLicks = Regras.SetLettres(sender, countCLicks);
            
            Regras.WinnerGame(this);

            if(countCLicks > 9 && !Regras.Winner)
                Regras.HashGame(countCLicks,this);
        }
    }
}
