namespace GAME
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picObstaculo1 = new System.Windows.Forms.PictureBox();
            this.picObstaculo2 = new System.Windows.Forms.PictureBox();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lbPonto = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picObstaculo1
            // 
            this.picObstaculo1.BackColor = System.Drawing.Color.Transparent;
            this.picObstaculo1.Image = ((System.Drawing.Image)(resources.GetObject("picObstaculo1.Image")));
            this.picObstaculo1.Location = new System.Drawing.Point(443, 364);
            this.picObstaculo1.Name = "picObstaculo1";
            this.picObstaculo1.Size = new System.Drawing.Size(53, 87);
            this.picObstaculo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObstaculo1.TabIndex = 3;
            this.picObstaculo1.TabStop = false;
            // 
            // picObstaculo2
            // 
            this.picObstaculo2.BackColor = System.Drawing.Color.Transparent;
            this.picObstaculo2.Image = ((System.Drawing.Image)(resources.GetObject("picObstaculo2.Image")));
            this.picObstaculo2.Location = new System.Drawing.Point(788, 364);
            this.picObstaculo2.Name = "picObstaculo2";
            this.picObstaculo2.Size = new System.Drawing.Size(53, 87);
            this.picObstaculo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObstaculo2.TabIndex = 4;
            this.picObstaculo2.TabStop = false;
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.Color.Transparent;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(61, 401);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(35, 50);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 5;
            this.picMain.TabStop = false;
            // 
            // lbPonto
            // 
            this.lbPonto.AutoSize = true;
            this.lbPonto.BackColor = System.Drawing.Color.Transparent;
            this.lbPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPonto.Location = new System.Drawing.Point(381, 52);
            this.lbPonto.Name = "lbPonto";
            this.lbPonto.Size = new System.Drawing.Size(68, 73);
            this.lbPonto.TabIndex = 6;
            this.lbPonto.Text = "0";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStart.Location = new System.Drawing.Point(51, 182);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(696, 42);
            this.lbStart.TabIndex = 7;
            this.lbStart.Text = "Pressione quaquer tecla para começar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.lbPonto);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.picObstaculo2);
            this.Controls.Add(this.picObstaculo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picObstaculo1;
        private System.Windows.Forms.PictureBox picObstaculo2;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label lbPonto;
        private System.Windows.Forms.Label lbStart;
    }
}

