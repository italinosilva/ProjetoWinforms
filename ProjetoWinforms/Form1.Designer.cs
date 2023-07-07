namespace ProjetoWinforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            Redefina = new LinkLabel();
            label4 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 45F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(58, 39);
            label1.Name = "label1";
            label1.Size = new Size(560, 70);
            label1.TabIndex = 0;
            label1.Text = "PALMEIRASCHOOL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(198, 210);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(198, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 34);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(198, 280);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(198, 313);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(163, 36);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(227, 355);
            button1.Name = "button1";
            button1.Size = new Size(105, 40);
            button1.TabIndex = 5;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Redefina
            // 
            Redefina.AutoSize = true;
            Redefina.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Redefina.LinkColor = Color.FromArgb(0, 192, 0);
            Redefina.Location = new Point(208, 488);
            Redefina.Name = "Redefina";
            Redefina.Size = new Size(173, 17);
            Redefina.TabIndex = 6;
            Redefina.TabStop = true;
            Redefina.Text = "Clique aqui para redefinir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(198, 469);
            label4.Name = "label4";
            label4.Size = new Size(191, 17);
            label4.TabIndex = 7;
            label4.Text = "Esqueceu Usuário ou Senha?";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(218, 519);
            label5.Name = "label5";
            label5.Size = new Size(149, 17);
            label5.TabIndex = 9;
            label5.Text = "Não possui cadastro?";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(0, 192, 0);
            linkLabel1.Location = new Point(240, 537);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(85, 17);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastre-se";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(127, 99);
            label6.Name = "label6";
            label6.Size = new Size(417, 19);
            label6.TabIndex = 11;
            label6.Text = "Seja bem-vindo(a) ao sistema do #MaiorCampeãoDoBrasil!";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com;
            pictureBox1.Location = new Point(660, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(668, 808);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Redefina);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.Lime;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel Redefina;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
        private Label label6;
        private PictureBox pictureBox1;
    }
}