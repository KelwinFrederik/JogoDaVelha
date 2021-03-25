
namespace JogoDaVelha
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_PlayGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_NameX = new System.Windows.Forms.TextBox();
            this.Tb_NameO = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.JogX1 = new System.Windows.Forms.CheckBox();
            this.JogO1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_PlayGame
            // 
            this.btn_PlayGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_PlayGame.Location = new System.Drawing.Point(13, 82);
            this.btn_PlayGame.Name = "btn_PlayGame";
            this.btn_PlayGame.Size = new System.Drawing.Size(159, 23);
            this.btn_PlayGame.TabIndex = 0;
            this.btn_PlayGame.Text = "PLAY GAME";
            this.btn_PlayGame.UseVisualStyleBackColor = true;
            this.btn_PlayGame.Click += new System.EventHandler(this.btn_PlayGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o nome do jogador X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o nome do jogador O:";
            // 
            // Tb_NameX
            // 
            this.Tb_NameX.Location = new System.Drawing.Point(154, 12);
            this.Tb_NameX.Name = "Tb_NameX";
            this.Tb_NameX.Size = new System.Drawing.Size(111, 20);
            this.Tb_NameX.TabIndex = 3;
            // 
            // Tb_NameO
            // 
            this.Tb_NameO.Location = new System.Drawing.Point(154, 48);
            this.Tb_NameO.Name = "Tb_NameO";
            this.Tb_NameO.Size = new System.Drawing.Size(111, 20);
            this.Tb_NameO.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(178, 82);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(87, 23);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // JogX1
            // 
            this.JogX1.AutoSize = true;
            this.JogX1.Checked = true;
            this.JogX1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.JogX1.Location = new System.Drawing.Point(287, 15);
            this.JogX1.Name = "JogX1";
            this.JogX1.Size = new System.Drawing.Size(78, 17);
            this.JogX1.TabIndex = 6;
            this.JogX1.Text = "X jogará 1°";
            this.JogX1.UseVisualStyleBackColor = true;
            // 
            // JogO1
            // 
            this.JogO1.AutoSize = true;
            this.JogO1.Location = new System.Drawing.Point(287, 51);
            this.JogO1.Name = "JogO1";
            this.JogO1.Size = new System.Drawing.Size(79, 17);
            this.JogO1.TabIndex = 7;
            this.JogO1.Text = "O jogará 1°";
            this.JogO1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.btn_PlayGame;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(380, 117);
            this.ControlBox = false;
            this.Controls.Add(this.JogO1);
            this.Controls.Add(this.JogX1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.Tb_NameO);
            this.Controls.Add(this.Tb_NameX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PlayGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PlayGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Tb_NameX;
        public System.Windows.Forms.TextBox Tb_NameO;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.CheckBox JogX1;
        private System.Windows.Forms.CheckBox JogO1;
    }
}