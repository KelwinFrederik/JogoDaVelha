
namespace JogoDaVelha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PrimeiroJogador = new System.Windows.Forms.Label();
            this.SegundoJogador = new System.Windows.Forms.Label();
            this.SimbolLabelPlayer1 = new System.Windows.Forms.Label();
            this.SimbolLabelPlayer2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Label_Information = new System.Windows.Forms.Label();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelNomeX
            // 
            resources.ApplyResources(this.PrimeiroJogador, "LabelNomeX");
            this.PrimeiroJogador.Name = "LabelNomeX";
            // 
            // LabelNomeO
            // 
            resources.ApplyResources(this.SegundoJogador, "LabelNomeO");
            this.SegundoJogador.Name = "LabelNomeO";
            // 
            // SimbolLabelPlayer1
            // 
            resources.ApplyResources(this.SimbolLabelPlayer1, "SimbolLabelPlayer1");
            this.SimbolLabelPlayer1.Name = "SimbolLabelPlayer1";
            // 
            // SimbolLabelPlayer2
            // 
            resources.ApplyResources(this.SimbolLabelPlayer2, "SimbolLabelPlayer2");
            this.SimbolLabelPlayer2.Name = "SimbolLabelPlayer2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // GamePanel
            // 
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GamePanel.Controls.Add(this.button7);
            this.GamePanel.Controls.Add(this.button8);
            this.GamePanel.Controls.Add(this.button9);
            this.GamePanel.Controls.Add(this.button4);
            this.GamePanel.Controls.Add(this.button5);
            this.GamePanel.Controls.Add(this.button6);
            this.GamePanel.Controls.Add(this.button3);
            this.GamePanel.Controls.Add(this.button2);
            this.GamePanel.Controls.Add(this.button1);
            resources.ApplyResources(this.GamePanel, "GamePanel");
            this.GamePanel.Name = "GamePanel";
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonsClick);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonsClick);
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonsClick);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonsClick);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonsClick);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonsClick);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonsClick);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonsClick);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonsClick);
            // 
            // btn_PlayAgain
            // 
            resources.ApplyResources(this.btn_PlayAgain, "btn_PlayAgain");
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.UseVisualStyleBackColor = true;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btn_Exit, "btn_Exit");
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Label_Information
            // 
            resources.ApplyResources(this.Label_Information, "Label_Information");
            this.Label_Information.Name = "Label_Information";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ControlBox = false;
            this.Controls.Add(this.Label_Information);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SimbolLabelPlayer2);
            this.Controls.Add(this.SimbolLabelPlayer1);
            this.Controls.Add(this.SegundoJogador);
            this.Controls.Add(this.PrimeiroJogador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.GamePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.Label PrimeiroJogador;
        public System.Windows.Forms.Label SegundoJogador;
        public System.Windows.Forms.Label Label_Information;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label SimbolLabelPlayer1;
        public System.Windows.Forms.Label SimbolLabelPlayer2;
    }
}

