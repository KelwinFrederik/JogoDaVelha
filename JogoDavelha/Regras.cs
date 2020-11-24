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
        public static bool hash { get; private set; }
        
        //Methods
        private static void GameOver() 
        {
            if(Winner || hash)
                IsGameRuning = false;
        }

        public static void NewGame() 
        {
            hash = false;
            Winner = false;
            IsGameRuning = true;
        }

        public static void WinnerGame(Form1 form)
        {
            string winner = "", loser = "";
            string whowinner, wholoser;

            //TODO MAIS PROXIMO WINNER
/*
            List<string[,]> btn = new List<string[,]>();
            string[,] btnstring = new string[8, 3]{
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text}
            };

            btn.Add(new string[8,3]{ 
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text},
                {form.button1.Text, form.button6.Text, form.button9.Text}
            }); 
*/           
            
            //{form.button1.Text, form.button6.Text, form.button9.Text });

            //List<string> []btn = [[form.button1.Text, form.button6.Text, form.button9.Text]

            //string[] Btn_Winner = new string[3];

            /*
             * , {"","","" }, { "", "", "" }, { "", "", "" }, { "", "", "" }, { "", "", "" }, { "", "", "" }, { "", "", "" } );
            List<string>[] buttonsWinner = new List<string>[3]; {[form.button1.Text, form.button6.Text, form.button9.Text] };
            buttonsWinner.

            buttonsWinner [form.button1.Text, form.button6.Text, form.button9.Text];
            */


            //TODO Comparação para decidir vencedor;


            if (Winner)
                GameOver();

            form.Label_Information.Text = $"PARABENS !! {winner} VENCEU A PARTIDA!! {loser} TENTE NOVAMENTE!!";
        }

        public static void HashGame(int count,Form1 form) 
        {
            if (count > 9) 
            {
                hash = false;
                GameOver();
            }

            form.Label_Information.Text = "DEU VELHA !! Tente Novamente !!";
        }

        public static int setLetters(object sender, int count)
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
    }
}
