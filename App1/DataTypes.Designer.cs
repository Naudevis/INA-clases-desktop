namespace App1
{
    partial class DataTypes
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
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnSum = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.llblExample = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TxtNum2
            // 
            this.TxtNum2.BackColor = System.Drawing.Color.MistyRose;
            this.TxtNum2.Location = new System.Drawing.Point(13, 9);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(100, 20);
            this.TxtNum2.TabIndex = 0;
            this.TxtNum2.Text = "1";
            // 
            // TxtNum1
            // 
            this.TxtNum1.BackColor = System.Drawing.Color.MistyRose;
            this.TxtNum1.Location = new System.Drawing.Point(13, 35);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 20);
            this.TxtNum1.TabIndex = 1;
            this.TxtNum1.Text = "b ";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Cyan;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Location = new System.Drawing.Point(164, 61);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(67, 23);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Limpiar";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.Red;
            this.BtnPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlus.Location = new System.Drawing.Point(87, 61);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(67, 23);
            this.BtnPlus.TabIndex = 3;
            this.BtnPlus.Text = "x";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnSum
            // 
            this.BtnSum.BackColor = System.Drawing.Color.Lime;
            this.BtnSum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSum.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSum.FlatAppearance.BorderSize = 0;
            this.BtnSum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSum.Location = new System.Drawing.Point(13, 61);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(67, 23);
            this.BtnSum.TabIndex = 4;
            this.BtnSum.Text = "+";
            this.BtnSum.UseVisualStyleBackColor = false;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(119, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(126, 42);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "1+1=3";
            // 
            // llblExample
            // 
            this.llblExample.AutoSize = true;
            this.llblExample.Location = new System.Drawing.Point(13, 91);
            this.llblExample.Name = "llblExample";
            this.llblExample.Size = new System.Drawing.Size(22, 13);
            this.llblExample.TabIndex = 6;
            this.llblExample.TabStop = true;
            this.llblExample.Text = "tag";
            this.llblExample.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DataTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(241, 110);
            this.Controls.Add(this.llblExample);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.TxtNum2);
            this.Name = "DataTypes";
            this.Text = "DataTypes";
            this.Load += new System.EventHandler(this.DataTypes_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.LinkLabel llblExample;
    }
}