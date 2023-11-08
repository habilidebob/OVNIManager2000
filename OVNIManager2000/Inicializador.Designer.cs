namespace OVNIManager2000
{
    partial class Inicializador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.nudTripulantes = new System.Windows.Forms.NumericUpDown();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(117, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(357, 44);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "OVNI Manager 2000";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(257, 93);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(138, 22);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Max. Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(257, 128);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(142, 22);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Max. Tripulantes:";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(236, 162);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(163, 22);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta de Origem:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OVNIManager2000.Properties.Resources.ufo;
            this.pictureBox1.Location = new System.Drawing.Point(38, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nudAbduzidos
            // 
            this.nudAbduzidos.Location = new System.Drawing.Point(401, 91);
            this.nudAbduzidos.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudAbduzidos.Name = "nudAbduzidos";
            this.nudAbduzidos.Size = new System.Drawing.Size(133, 27);
            this.nudAbduzidos.TabIndex = 5;
            // 
            // nudTripulantes
            // 
            this.nudTripulantes.Location = new System.Drawing.Point(401, 126);
            this.nudTripulantes.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTripulantes.Name = "nudTripulantes";
            this.nudTripulantes.Size = new System.Drawing.Size(133, 27);
            this.nudTripulantes.TabIndex = 6;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(401, 159);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(133, 30);
            this.cmbPlaneta.TabIndex = 7;
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Location = new System.Drawing.Point(240, 203);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(294, 55);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 270);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.nudTripulantes);
            this.Controls.Add(this.nudAbduzidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            this.Load += new System.EventHandler(this.Inicializador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudAbduzidos;
        private System.Windows.Forms.NumericUpDown nudTripulantes;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Button btnIniciar;
    }
}