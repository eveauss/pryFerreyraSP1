namespace pryFerreyraSP1
{
    partial class frmLogin
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
            pictureBox1 = new PictureBox();
            gbLogin = new GroupBox();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            btnIngresar = new Button();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 397);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(txtContraseña);
            gbLogin.Controls.Add(lblContraseña);
            gbLogin.Controls.Add(txtUsuario);
            gbLogin.Controls.Add(btnIngresar);
            gbLogin.Controls.Add(lblUsuario);
            gbLogin.Location = new Point(44, 59);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(200, 263);
            gbLogin.TabIndex = 8;
            gbLogin.TabStop = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(90, 124);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 10;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(11, 127);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 9;
            lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(90, 76);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 8;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(115, 164);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(11, 76);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 412);
            Controls.Add(gbLogin);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox gbLogin;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private Button btnIngresar;
        private Label lblUsuario;
    }
}
