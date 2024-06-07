﻿namespace App1
{
    partial class CrearCuenta
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtContrasennia = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUsuarioCrear = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRepiteContrasennia = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(70, 361);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(128, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Crear cuenta";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
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
            this.txtContrasennia.Location = new System.Drawing.Point(70, 187);
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
            this.txtContrasennia.TabIndex = 5;
            this.txtContrasennia.TabStop = false;
            this.txtContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrasennia.TrailingIcon = null;
            this.txtContrasennia.UseSystemPasswordChar = false;
            // 
            // txtUsuarioCrear
            // 
            this.txtUsuarioCrear.AnimateReadOnly = false;
            this.txtUsuarioCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuarioCrear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuarioCrear.Depth = 0;
            this.txtUsuarioCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuarioCrear.HideSelection = true;
            this.txtUsuarioCrear.Hint = "Usuario a crear";
            this.txtUsuarioCrear.LeadingIcon = null;
            this.txtUsuarioCrear.Location = new System.Drawing.Point(70, 116);
            this.txtUsuarioCrear.MaxLength = 32767;
            this.txtUsuarioCrear.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuarioCrear.Name = "txtUsuarioCrear";
            this.txtUsuarioCrear.PasswordChar = '\0';
            this.txtUsuarioCrear.PrefixSuffixText = null;
            this.txtUsuarioCrear.ReadOnly = false;
            this.txtUsuarioCrear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioCrear.SelectedText = "";
            this.txtUsuarioCrear.SelectionLength = 0;
            this.txtUsuarioCrear.SelectionStart = 0;
            this.txtUsuarioCrear.ShortcutsEnabled = true;
            this.txtUsuarioCrear.Size = new System.Drawing.Size(250, 48);
            this.txtUsuarioCrear.TabIndex = 4;
            this.txtUsuarioCrear.TabStop = false;
            this.txtUsuarioCrear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuarioCrear.TrailingIcon = null;
            this.txtUsuarioCrear.UseSystemPasswordChar = false;
            this.txtUsuarioCrear.Click += new System.EventHandler(this.materialTextBox21_Click);
            // 
            // txtRepiteContrasennia
            // 
            this.txtRepiteContrasennia.AnimateReadOnly = false;
            this.txtRepiteContrasennia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRepiteContrasennia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRepiteContrasennia.Depth = 0;
            this.txtRepiteContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRepiteContrasennia.HideSelection = true;
            this.txtRepiteContrasennia.Hint = "Repite la Contraseña";
            this.txtRepiteContrasennia.LeadingIcon = null;
            this.txtRepiteContrasennia.Location = new System.Drawing.Point(70, 267);
            this.txtRepiteContrasennia.MaxLength = 32767;
            this.txtRepiteContrasennia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRepiteContrasennia.Name = "txtRepiteContrasennia";
            this.txtRepiteContrasennia.PasswordChar = '*';
            this.txtRepiteContrasennia.PrefixSuffixText = null;
            this.txtRepiteContrasennia.ReadOnly = false;
            this.txtRepiteContrasennia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRepiteContrasennia.SelectedText = "";
            this.txtRepiteContrasennia.SelectionLength = 0;
            this.txtRepiteContrasennia.SelectionStart = 0;
            this.txtRepiteContrasennia.ShortcutsEnabled = true;
            this.txtRepiteContrasennia.Size = new System.Drawing.Size(250, 48);
            this.txtRepiteContrasennia.TabIndex = 7;
            this.txtRepiteContrasennia.TabStop = false;
            this.txtRepiteContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepiteContrasennia.TrailingIcon = null;
            this.txtRepiteContrasennia.UseSystemPasswordChar = false;
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRepiteContrasennia);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txtContrasennia);
            this.Controls.Add(this.txtUsuarioCrear);
            this.Name = "CrearCuenta";
            this.Text = "CrearCuenta";
            this.Load += new System.EventHandler(this.CrearCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 txtContrasennia;
        private MaterialSkin.Controls.MaterialTextBox2 txtUsuarioCrear;
        private MaterialSkin.Controls.MaterialTextBox2 txtRepiteContrasennia;
    }
}