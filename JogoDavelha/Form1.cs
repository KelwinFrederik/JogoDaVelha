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
        }
        

        private void On_PageLoad()
        {
            DefineOrdemJogadores();
            
            Regras.NewGame(this);
            Regras.SetFirstPlayer();

            Label_Information.Text = $"jogador {PrimeiroJogador.Text} inicirá o jogo. \nBy.: Kelwin F. Alves";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();            
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Tb_NameX.Text = Form2._JogadorX;
            form2.Tb_NameO.Text = Form2._JogadorO;

            form2.ShowDialog();
            this.Close();
        }

        private void buttonsClick(object sender, EventArgs e)
        {
            if(countCLicks <= 9 && Regras.IsGameRuning)
                countCLicks = Regras.SetLettres(sender, countCLicks);
            
            Regras.WinnerGame(this);

            if(countCLicks > 9 && !Regras.Winner)
                Regras.HashGame(countCLicks,this);
        }

        private void DefineOrdemJogadores()
        {
            PrimeiroJogador.Text = Form2._JogadorX;
            SegundoJogador.Text = Form2._JogadorO;

            if (!Form2._PrimeiroX)
            {
                PrimeiroJogador.Text = Form2._JogadorO;
                SegundoJogador.Text = Form2._JogadorX;

                string TrocaAuxiliar = SimbolLabelPlayer1.Text;

                SimbolLabelPlayer1.Text = SimbolLabelPlayer2.Text;
                SimbolLabelPlayer2.Text = TrocaAuxiliar;
            }
        }
    }
}
