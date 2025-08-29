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
            gbLogin = new GroupBox();
            btnAceptar = new Button();
            lblBienvenido = new Label();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbLogin
            // 
            gbLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbLogin.BackColor = Color.LightSteelBlue;
            gbLogin.Controls.Add(btnAceptar);
            gbLogin.Controls.Add(lblBienvenido);
            gbLogin.Location = new Point(-3, -5);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(805, 458);
            gbLogin.TabIndex = 9;
            gbLogin.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAceptar.BackColor = Color.White;
            btnAceptar.ForeColor = SystemColors.ActiveCaptionText;
            btnAceptar.Location = new Point(357, 237);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 30);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblBienvenido
            // 
            lblBienvenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(288, 192);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(228, 30);
            lblBienvenido.TabIndex = 11;
            lblBienvenido.Text = "Bienvenido al Sistema";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(gbLogin);
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += frmInicio_Load;
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbLogin;
        private Button btnAceptar;
        private Label lblBienvenido;
    }
}