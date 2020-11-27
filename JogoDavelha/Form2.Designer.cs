
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
            this.SuspendLayout();
            // 
            // btn_PlayGame
            // 
            this.btn_PlayGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_PlayGame.Location = new System.Drawing.Point(16, 90);
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
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o nome do jogador X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o nome do jogador O:";
            // 
            // Tb_NameX
            // 
            this.Tb_NameX.Location = new System.Drawing.Point(157, 20);
            this.Tb_NameX.Name = "Tb_NameX";
            this.Tb_NameX.Size = new System.Drawing.Size(111, 20);
            this.Tb_NameX.TabIndex = 3;
            // 
            // Tb_NameO
            // 
            this.Tb_NameO.Location = new System.Drawing.Point(157, 56);
            this.Tb_NameO.Name = "Tb_NameO";
            this.Tb_NameO.Size = new System.Drawing.Size(111, 20);
            this.Tb_NameO.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(181, 90);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(87, 23);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.btn_PlayGame;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(278, 125);
            this.ControlBox = false;
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
    }
}