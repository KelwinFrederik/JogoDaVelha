using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    class Regras
    {
        public static bool IsGameRuning { get; private set; } 
        public static bool Winner { get; private set; }
        public static bool Hash { get; private set; }
        private static List<Button[]> combinationWin;

        //Methods
        private static void GameOver() 
        {
            if(Winner || Hash)
                IsGameRuning = false;
        }

        public static void NewGame(Form1 form) 
        {
            Hash = false;
            Winner = false;
            IsGameRuning = true;
        }

        public static void WinnerGame(Form1 form)
        {
            string whowinner = "", wholoser="";

            if (WinnerButtons(form, out whowinner)) 
            {
                if (whowinner.ToUpper() == "X")
                {
                    wholoser = form.LabelNomeO.Text;
                    whowinner = form.LabelNomeX.Text;
                }
                else
                {
                    wholoser = form.LabelNomeX.Text;
                    whowinner = form.LabelNomeO.Text;
                }

                Winner = true;
            }


            if (Winner)
            {
                GameOver();
                form.Label_Information.Text = $"PARABENS !! {whowinner} VENCEU A PARTIDA!! {wholoser} TENTE NOVAMENTE!!";
            }
        }

        public static void HashGame(int count,Form1 form) 
        {
            if (count > 9) 
            {
                Hash = false;
                GameOver();
            }

            form.Label_Information.Text = "DEU VELHA !! Tente Novamente !!";
        }

        public static int SetLettres(object sender, int count)
        {
            Button b = (Button)sender;

            if (b.Text == "")
                if (count % 2 == 0)
                {
                    b.Text = "0";
                    count++;
                }
                else
                {
                    b.Text = "X";
                    count++;
                }
            return count;
        }

        private static bool WinnerButtons(Form1 form, out string whowinner)
        {
            bool winner = false;
            whowinner = "";

            if ((
                (form.button1.Text == form.button5.Text && form.button1.Text == form.button7.Text) ||
                (form.button3.Text == form.button5.Text && form.button3.Text == form.button9.Text) ||
                (form.button8.Text == form.button2.Text && form.button8.Text == form.button5.Text) ||
                (form.button4.Text == form.button5.Text && form.button4.Text == form.button6.Text)
               ) && form.button5.Text.Length > 0) 
            {
                whowinner = form.button5.Text;
                winner = true;
            }
            else if ((
                (form.button1.Text == form.button2.Text && form.button1.Text == form.button3.Text) ||
                (form.button1.Text == form.button6.Text && form.button1.Text == form.button9.Text)
                )&& form.button1.Text.Length > 0)
            {
                whowinner = form.button1.Text;
                winner = true;
            }
            else if  ((
                (form.button8.Text == form.button7.Text && form.button8.Text == form.button9.Text) ||
                (form.button3.Text == form.button4.Text && form.button3.Text == form.button7.Text)
                ) && form.button7.Text.Length > 0)
            {
                whowinner = form.button7.Text;
                winner = true;
            }

            return winner;
        }
    }
}
