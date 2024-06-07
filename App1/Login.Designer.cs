namespace App1
{
    partial class Login
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
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtContrasennia = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.Hint = "Ingrese el usuario";
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(64, 15);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PrefixSuffixText = null;
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(250, 48);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.Click += new System.EventHandler(this.materialTextBox21_Click);
            // 
            // txtContrasennia
            // 
            this.txtContrasennia.AnimateReadOnly = false;
            this.txtContrasennia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContrasennia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContrasennia.Depth = 0;
            this.txtContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasennia.HideSelection = true;
            this.txtContrasennia.Hint = "Contraseña";
            this.txtContrasennia.LeadingIcon = null;
            this.txtContrasennia.Location = new System.Drawing.Point(64, 86);
            this.txtContrasennia.MaxLength = 32767;
            this.txtContrasennia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasennia.Name = "txtContrasennia";
            this.txtContrasennia.PasswordChar = '*';
            this.txtContrasennia.PrefixSuffixText = null;
            this.txtContrasennia.ReadOnly = false;
            this.txtContrasennia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContrasennia.SelectedText = "";
            this.txtContrasennia.SelectionLength = 0;
            this.txtContrasennia.SelectionStart = 0;
            this.txtContrasennia.ShortcutsEnabled = true;
            this.txtContrasennia.Size = new System.Drawing.Size(250, 48);
            this.txtContrasennia.TabIndex = 1;
            this.txtContrasennia.TabStop = false;
            this.txtContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrasennia.TrailingIcon = null;
            this.txtContrasennia.UseSystemPasswordChar = false;
            this.txtContrasennia.Click += new System.EventHandler(this.materialTextBox22_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(81, 169);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(91, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Ingresar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.Location = new System.Drawing.Point(215, 175);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 36);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Crear cuenta";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtUsuario);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.txtContrasennia);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(172, 169);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(387, 225);
            this.materialCard1.TabIndex = 4;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(250, 114);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(229, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Bienvenidos(as) a Tienda Stylos";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialCard1);
            this.Name = "Login";
            this.Text = "Login";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtContrasennia;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialTextBox2 txtUsuario;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}