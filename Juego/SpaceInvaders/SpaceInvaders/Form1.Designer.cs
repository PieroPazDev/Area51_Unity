namespace SpaceInvaders
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invader1 = new System.Windows.Forms.PictureBox();
            this.invader2 = new System.Windows.Forms.PictureBox();
            this.invader3 = new System.Windows.Forms.PictureBox();
            this.invader4 = new System.Windows.Forms.PictureBox();
            this.invader12 = new System.Windows.Forms.PictureBox();
            this.invader11 = new System.Windows.Forms.PictureBox();
            this.invader10 = new System.Windows.Forms.PictureBox();
            this.invader9 = new System.Windows.Forms.PictureBox();
            this.invader8 = new System.Windows.Forms.PictureBox();
            this.invader7 = new System.Windows.Forms.PictureBox();
            this.invader6 = new System.Windows.Forms.PictureBox();
            this.invader5 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.invader1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(410, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 15;
            this.label1.Tag = "score";
            this.label1.Text = "Score: 00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // invader1
            // 
            this.invader1.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader1.Location = new System.Drawing.Point(468, 65);
            this.invader1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader1.Name = "invader1";
            this.invader1.Size = new System.Drawing.Size(38, 41);
            this.invader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader1.TabIndex = 12;
            this.invader1.TabStop = false;
            this.invader1.Tag = "invaders";
            // 
            // invader2
            // 
            this.invader2.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader2.Location = new System.Drawing.Point(426, 65);
            this.invader2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader2.Name = "invader2";
            this.invader2.Size = new System.Drawing.Size(38, 41);
            this.invader2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader2.TabIndex = 11;
            this.invader2.TabStop = false;
            this.invader2.Tag = "invaders";
            // 
            // invader3
            // 
            this.invader3.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader3.Location = new System.Drawing.Point(384, 65);
            this.invader3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader3.Name = "invader3";
            this.invader3.Size = new System.Drawing.Size(38, 41);
            this.invader3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader3.TabIndex = 10;
            this.invader3.TabStop = false;
            this.invader3.Tag = "invaders";
            // 
            // invader4
            // 
            this.invader4.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader4.Location = new System.Drawing.Point(342, 65);
            this.invader4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader4.Name = "invader4";
            this.invader4.Size = new System.Drawing.Size(38, 41);
            this.invader4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader4.TabIndex = 9;
            this.invader4.TabStop = false;
            this.invader4.Tag = "invaders";
            // 
            // invader12
            // 
            this.invader12.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader12.Location = new System.Drawing.Point(5, 65);
            this.invader12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader12.Name = "invader12";
            this.invader12.Size = new System.Drawing.Size(38, 41);
            this.invader12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader12.TabIndex = 8;
            this.invader12.TabStop = false;
            this.invader12.Tag = "invaders";
            // 
            // invader11
            // 
            this.invader11.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader11.Location = new System.Drawing.Point(47, 65);
            this.invader11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader11.Name = "invader11";
            this.invader11.Size = new System.Drawing.Size(38, 41);
            this.invader11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader11.TabIndex = 7;
            this.invader11.TabStop = false;
            this.invader11.Tag = "invaders";
            // 
            // invader10
            // 
            this.invader10.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader10.Location = new System.Drawing.Point(89, 65);
            this.invader10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader10.Name = "invader10";
            this.invader10.Size = new System.Drawing.Size(38, 41);
            this.invader10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader10.TabIndex = 6;
            this.invader10.TabStop = false;
            this.invader10.Tag = "invaders";
            // 
            // invader9
            // 
            this.invader9.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader9.Location = new System.Drawing.Point(131, 65);
            this.invader9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader9.Name = "invader9";
            this.invader9.Size = new System.Drawing.Size(38, 41);
            this.invader9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader9.TabIndex = 5;
            this.invader9.TabStop = false;
            this.invader9.Tag = "invaders";
            // 
            // invader8
            // 
            this.invader8.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader8.Location = new System.Drawing.Point(173, 65);
            this.invader8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader8.Name = "invader8";
            this.invader8.Size = new System.Drawing.Size(38, 41);
            this.invader8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader8.TabIndex = 4;
            this.invader8.TabStop = false;
            this.invader8.Tag = "invaders";
            // 
            // invader7
            // 
            this.invader7.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader7.Location = new System.Drawing.Point(216, 65);
            this.invader7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader7.Name = "invader7";
            this.invader7.Size = new System.Drawing.Size(38, 41);
            this.invader7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader7.TabIndex = 3;
            this.invader7.TabStop = false;
            this.invader7.Tag = "invaders";
            // 
            // invader6
            // 
            this.invader6.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader6.Location = new System.Drawing.Point(258, 65);
            this.invader6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader6.Name = "invader6";
            this.invader6.Size = new System.Drawing.Size(38, 41);
            this.invader6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader6.TabIndex = 2;
            this.invader6.TabStop = false;
            this.invader6.Tag = "invaders";
            // 
            // invader5
            // 
            this.invader5.Image = global::SpaceInvaders.Properties.Resources.inavders;
            this.invader5.Location = new System.Drawing.Point(300, 65);
            this.invader5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invader5.Name = "invader5";
            this.invader5.Size = new System.Drawing.Size(38, 41);
            this.invader5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invader5.TabIndex = 1;
            this.invader5.TabStop = false;
            this.invader5.Tag = "invaders";
            // 
            // player
            // 
            this.player.Image = global::SpaceInvaders.Properties.Resources.tank;
            this.player.Location = new System.Drawing.Point(220, 318);
            this.player.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(38, 41);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Tag = "tank";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(516, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invader1);
            this.Controls.Add(this.invader2);
            this.Controls.Add(this.invader3);
            this.Controls.Add(this.invader4);
            this.Controls.Add(this.invader12);
            this.Controls.Add(this.invader11);
            this.Controls.Add(this.invader10);
            this.Controls.Add(this.invader9);
            this.Controls.Add(this.invader8);
            this.Controls.Add(this.invader7);
            this.Controls.Add(this.invader6);
            this.Controls.Add(this.invader5);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(532, 418);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(532, 418);
            this.Name = "Form1";
            this.Tag = "invaders2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.invader1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invader5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox invader5;
        private System.Windows.Forms.PictureBox invader6;
        private System.Windows.Forms.PictureBox invader7;
        private System.Windows.Forms.PictureBox invader8;
        private System.Windows.Forms.PictureBox invader9;
        private System.Windows.Forms.PictureBox invader10;
        private System.Windows.Forms.PictureBox invader11;
        private System.Windows.Forms.PictureBox invader12;
        private System.Windows.Forms.PictureBox invader4;
        private System.Windows.Forms.PictureBox invader3;
        private System.Windows.Forms.PictureBox invader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox invader1;
    }
}

