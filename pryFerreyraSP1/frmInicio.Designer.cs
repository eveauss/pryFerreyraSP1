namespace pryFerreyraSP1
{
    partial class frmInicio
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
            pictureBox1 = new PictureBox();
            gbLogin = new GroupBox();
            lblBienvenido = new Label();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fondo1;
            pictureBox1.Location = new Point(25, -399);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(736, 1308);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gbLogin
            // 
            gbLogin.BackColor = Color.LightSteelBlue;
            gbLogin.Controls.Add(btnAceptar);
            gbLogin.Controls.Add(lblBienvenido);
            gbLogin.Location = new Point(125, 94);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(515, 263);
            gbLogin.TabIndex = 9;
            gbLogin.TabStop = false;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(142, 92);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(228, 30);
            lblBienvenido.TabIndex = 9;
            lblBienvenido.Text = "Bienvenido al Sistema";
            lblBienvenido.Click += lblContraseña_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.Location = new Point(216, 139);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(gbLogin);
            Controls.Add(pictureBox1);
            Name = "frmInicio";
            Text = "frmInicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox gbLogin;
        private Label lblBienvenido;
        private Button btnAceptar;
    }
}