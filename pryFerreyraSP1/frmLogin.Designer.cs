﻿namespace pryFerreyraSP1
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
            gbLogin = new GroupBox();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            btnIngresar = new Button();
            lblUsuario = new Label();
            btnCancelar = new Button();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbLogin
            // 
            gbLogin.BackColor = Color.LightSlateGray;
            gbLogin.Controls.Add(btnCancelar);
            gbLogin.Controls.Add(txtContraseña);
            gbLogin.Controls.Add(lblContraseña);
            gbLogin.Controls.Add(txtUsuario);
            gbLogin.Controls.Add(btnIngresar);
            gbLogin.Controls.Add(lblUsuario);
            gbLogin.ForeColor = Color.Transparent;
            gbLogin.Location = new Point(45, 66);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(200, 263);
            gbLogin.TabIndex = 8;
            gbLogin.TabStop = false;
            gbLogin.Enter += gbLogin_Enter;
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
            btnIngresar.BackColor = Color.White;
            btnIngresar.ForeColor = SystemColors.ActiveCaptionText;
            btnIngresar.Location = new Point(109, 164);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(81, 28);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
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
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(11, 164);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 28);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(300, 412);
            Controls.Add(gbLogin);
            Name = "frmLogin";
            Text = "Login";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbLogin;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private Button btnIngresar;
        private Label lblUsuario;
        private Button btnCancelar;
    }
}
