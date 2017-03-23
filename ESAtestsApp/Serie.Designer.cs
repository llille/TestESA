namespace ESAtestsApp
{
    partial class SerieForm
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
            this.MenuBtn = new System.Windows.Forms.Button();
            this.LancerBtn = new System.Windows.Forms.Button();
            this.TitreLb = new System.Windows.Forms.Label();
            this.NumSerieLb = new System.Windows.Forms.Label();
            this.Consigne1Lb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReglesLb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(670, 76);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(106, 32);
            this.MenuBtn.TabIndex = 9;
            this.MenuBtn.Text = "Menu principal";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // LancerBtn
            // 
            this.LancerBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LancerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LancerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LancerBtn.Location = new System.Drawing.Point(275, 446);
            this.LancerBtn.Name = "LancerBtn";
            this.LancerBtn.Size = new System.Drawing.Size(300, 65);
            this.LancerBtn.TabIndex = 10;
            this.LancerBtn.Text = "Lancer le test";
            this.LancerBtn.UseVisualStyleBackColor = false;
            this.LancerBtn.Click += new System.EventHandler(this.LancerBtn_Click);
            // 
            // TitreLb
            // 
            this.TitreLb.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitreLb.Image = global::ESAtestsApp.Properties.Resources.Fond;
            this.TitreLb.Location = new System.Drawing.Point(0, 0);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.TitreLb.Size = new System.Drawing.Size(834, 65);
            this.TitreLb.TabIndex = 11;
            this.TitreLb.Text = "%Nom du test% ";
            // 
            // NumSerieLb
            // 
            this.NumSerieLb.AutoSize = true;
            this.NumSerieLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSerieLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumSerieLb.Location = new System.Drawing.Point(345, 172);
            this.NumSerieLb.Name = "NumSerieLb";
            this.NumSerieLb.Size = new System.Drawing.Size(145, 31);
            this.NumSerieLb.TabIndex = 12;
            this.NumSerieLb.Text = "Serie n°x/y";
            // 
            // Consigne1Lb
            // 
            this.Consigne1Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consigne1Lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Consigne1Lb.Location = new System.Drawing.Point(25, 33);
            this.Consigne1Lb.Name = "Consigne1Lb";
            this.Consigne1Lb.Size = new System.Drawing.Size(535, 90);
            this.Consigne1Lb.TabIndex = 13;
            this.Consigne1Lb.Text = "Règle pour cette série";
            this.Consigne1Lb.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReglesLb);
            this.groupBox1.Controls.Add(this.Consigne1Lb);
            this.groupBox1.Location = new System.Drawing.Point(143, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 139);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ReglesLb
            // 
            this.ReglesLb.AutoSize = true;
            this.ReglesLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReglesLb.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ReglesLb.Location = new System.Drawing.Point(8, -3);
            this.ReglesLb.Name = "ReglesLb";
            this.ReglesLb.Size = new System.Drawing.Size(185, 20);
            this.ReglesLb.TabIndex = 15;
            this.ReglesLb.Text = "Règles pour cette série : ";
            // 
            // SerieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NumSerieLb);
            this.Controls.Add(this.TitreLb);
            this.Controls.Add(this.LancerBtn);
            this.Controls.Add(this.MenuBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SerieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test ESA - Nom du test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Serie_FormClosing);
            this.Load += new System.EventHandler(this.SerieForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button LancerBtn;
        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Label NumSerieLb;
        private System.Windows.Forms.Label Consigne1Lb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ReglesLb;
    }
}