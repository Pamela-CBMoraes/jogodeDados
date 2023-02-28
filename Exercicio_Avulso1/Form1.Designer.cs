
namespace Exercicio_Avulso1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnJogador2 = new System.Windows.Forms.Button();
            this.btnJogador1 = new System.Windows.Forms.Button();
            this.lblMostraVencedor = new System.Windows.Forms.Label();
            this.lblVencedor = new System.Windows.Forms.Label();
            this.lblMostraJogador2 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblMostraJogador1 = new System.Windows.Forms.Label();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnReiniciar);
            this.groupBox1.Controls.Add(this.btnJogador2);
            this.groupBox1.Controls.Add(this.btnJogador1);
            this.groupBox1.Controls.Add(this.lblMostraVencedor);
            this.groupBox1.Controls.Add(this.lblVencedor);
            this.groupBox1.Controls.Add(this.lblMostraJogador2);
            this.groupBox1.Controls.Add(this.lblJogador2);
            this.groupBox1.Controls.Add(this.lblMostraJogador1);
            this.groupBox1.Controls.Add(this.lblJogador1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogo de Dados";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(188, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 98);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(122, 245);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 8;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnJogador2
            // 
            this.btnJogador2.Enabled = false;
            this.btnJogador2.Location = new System.Drawing.Point(188, 170);
            this.btnJogador2.Name = "btnJogador2";
            this.btnJogador2.Size = new System.Drawing.Size(75, 23);
            this.btnJogador2.TabIndex = 7;
            this.btnJogador2.Text = "Jogar";
            this.btnJogador2.UseVisualStyleBackColor = true;
            this.btnJogador2.Click += new System.EventHandler(this.btnJogador2_Click);
            // 
            // btnJogador1
            // 
            this.btnJogador1.Location = new System.Drawing.Point(73, 170);
            this.btnJogador1.Name = "btnJogador1";
            this.btnJogador1.Size = new System.Drawing.Size(75, 23);
            this.btnJogador1.TabIndex = 6;
            this.btnJogador1.Text = "Jogar";
            this.btnJogador1.UseVisualStyleBackColor = true;
            this.btnJogador1.Click += new System.EventHandler(this.btnJogador1_Click);
            // 
            // lblMostraVencedor
            // 
            this.lblMostraVencedor.AutoSize = true;
            this.lblMostraVencedor.Location = new System.Drawing.Point(170, 218);
            this.lblMostraVencedor.Name = "lblMostraVencedor";
            this.lblMostraVencedor.Size = new System.Drawing.Size(35, 13);
            this.lblMostraVencedor.TabIndex = 5;
            this.lblMostraVencedor.Text = "label6";
            this.lblMostraVencedor.Visible = false;
            // 
            // lblVencedor
            // 
            this.lblVencedor.AutoSize = true;
            this.lblVencedor.Location = new System.Drawing.Point(111, 218);
            this.lblVencedor.Name = "lblVencedor";
            this.lblVencedor.Size = new System.Drawing.Size(56, 13);
            this.lblVencedor.TabIndex = 4;
            this.lblVencedor.Text = "Vencedor:";
            // 
            // lblMostraJogador2
            // 
            this.lblMostraJogador2.AutoSize = true;
            this.lblMostraJogador2.Location = new System.Drawing.Point(251, 30);
            this.lblMostraJogador2.Name = "lblMostraJogador2";
            this.lblMostraJogador2.Size = new System.Drawing.Size(35, 13);
            this.lblMostraJogador2.TabIndex = 3;
            this.lblMostraJogador2.Text = "label4";
            this.lblMostraJogador2.Visible = false;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Location = new System.Drawing.Point(195, 30);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(57, 13);
            this.lblJogador2.TabIndex = 2;
            this.lblJogador2.Text = "Jogador 2:";
            // 
            // lblMostraJogador1
            // 
            this.lblMostraJogador1.AutoSize = true;
            this.lblMostraJogador1.Location = new System.Drawing.Point(101, 30);
            this.lblMostraJogador1.Name = "lblMostraJogador1";
            this.lblMostraJogador1.Size = new System.Drawing.Size(35, 13);
            this.lblMostraJogador1.TabIndex = 1;
            this.lblMostraJogador1.Text = "label2";
            this.lblMostraJogador1.Visible = false;
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Location = new System.Drawing.Point(45, 30);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(57, 13);
            this.lblJogador1.TabIndex = 0;
            this.lblJogador1.Text = "Jogador 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 325);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnJogador2;
        private System.Windows.Forms.Button btnJogador1;
        private System.Windows.Forms.Label lblMostraVencedor;
        private System.Windows.Forms.Label lblVencedor;
        private System.Windows.Forms.Label lblMostraJogador2;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblMostraJogador1;
        private System.Windows.Forms.Label lblJogador1;
    }
}

