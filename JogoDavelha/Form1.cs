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
        List<Button> btns;

        public Form1()
        {
            SetListButtons();
            InitializeComponent();
            countCLicks = 0;
            Regras.NewGame();
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
                countCLicks = Regras.setLetters(sender, countCLicks);
            
            Regras.WinnerGame(btns);

            if(countCLicks > 8 && !Regras.Winner)
                Regras.HashGame(countCLicks,this);
        }

        private void SetListButtons()
        {
            btns = new List<Button>();
            //btns.Add(this.Controls.Find());
        }
    }
}
