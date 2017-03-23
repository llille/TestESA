namespace ESAtestsApp
{
    partial class EnonceForm
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
            this.TitreLb = new System.Windows.Forms.Label();
            this.EnonceLb = new System.Windows.Forms.Label();
            this.ExempleImg = new System.Windows.Forms.PictureBox();
            this.LancerBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.EnonceGrB = new System.Windows.Forms.GroupBox();
            this.ExempleGrB = new System.Windows.Forms.GroupBox();
            this.ExempleLb = new System.Windows.Forms.Label();
            this.DifficulteGrB = new System.Windows.Forms.GroupBox();
            this.DifficulteLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExempleImg)).BeginInit();
            this.EnonceGrB.SuspendLayout();
            this.ExempleGrB.SuspendLayout();
            this.DifficulteGrB.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitreLb.Image = global::ESAtestsApp.Properties.Resources.Fond;
            this.TitreLb.Location = new System.Drawing.Point(0, 1);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.TitreLb.Size = new System.Drawing.Size(834, 65);
            this.TitreLb.TabIndex = 0;
            this.TitreLb.Text = "%nom du test% - Enoncé";
            // 
            // EnonceLb
            // 
            this.EnonceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnonceLb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnonceLb.Location = new System.Drawing.Point(21, 22);
            this.EnonceLb.Name = "EnonceLb";
            this.EnonceLb.Size = new System.Drawing.Size(670, 76);
            this.EnonceLb.TabIndex = 3;
            this.EnonceLb.Text = "%Enoncé%";
            // 
            // ExempleImg
            // 
            this.ExempleImg.Location = new System.Drawing.Point(24, 35);
            this.ExempleImg.Name = "ExempleImg";
            this.ExempleImg.Size = new System.Drawing.Size(352, 196);
            this.ExempleImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExempleImg.TabIndex = 5;
            this.ExempleImg.TabStop = false;
            // 
            // LancerBtn
            // 
            this.LancerBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LancerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LancerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LancerBtn.Location = new System.Drawing.Point(637, 512);
            this.LancerBtn.Name = "LancerBtn";
            this.LancerBtn.Size = new System.Drawing.Size(139, 52);
            this.LancerBtn.TabIndex = 7;
            this.LancerBtn.Text = "OK";
            this.LancerBtn.UseVisualStyleBackColor = false;
            this.LancerBtn.Click += new System.EventHandler(this.LancerBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(670, 76);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(106, 32);
            this.MenuBtn.TabIndex = 8;
            this.MenuBtn.Text = "Menu principal";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // EnonceGrB
            // 
            this.EnonceGrB.Controls.Add(this.EnonceLb);
            this.EnonceGrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnonceGrB.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.EnonceGrB.Location = new System.Drawing.Point(54, 114);
            this.EnonceGrB.Name = "EnonceGrB";
            this.EnonceGrB.Size = new System.Drawing.Size(722, 111);
            this.EnonceGrB.TabIndex = 9;
            this.EnonceGrB.TabStop = false;
            this.EnonceGrB.Text = "Enoncé :";
            // 
            // ExempleGrB
            // 
            this.ExempleGrB.Controls.Add(this.ExempleLb);
            this.ExempleGrB.Controls.Add(this.ExempleImg);
            this.ExempleGrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExempleGrB.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ExempleGrB.Location = new System.Drawing.Point(54, 237);
            this.ExempleGrB.Name = "ExempleGrB";
            this.ExempleGrB.Size = new System.Drawing.Size(722, 248);
            this.ExempleGrB.TabIndex = 10;
            this.ExempleGrB.TabStop = false;
            this.ExempleGrB.Text = "Exemple :";
            // 
            // ExempleLb
            // 
            this.ExempleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExempleLb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExempleLb.Location = new System.Drawing.Point(397, 35);
            this.ExempleLb.MaximumSize = new System.Drawing.Size(1000, 1016);
            this.ExempleLb.Name = "ExempleLb";
            this.ExempleLb.Size = new System.Drawing.Size(294, 196);
            this.ExempleLb.TabIndex = 3;
            this.ExempleLb.Text = "%Exemple%";
            // 
            // DifficulteGrB
            // 
            this.DifficulteGrB.Controls.Add(this.DifficulteLb);
            this.DifficulteGrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficulteGrB.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.DifficulteGrB.Location = new System.Drawing.Point(54, 506);
            this.DifficulteGrB.Name = "DifficulteGrB";
            this.DifficulteGrB.Size = new System.Drawing.Size(555, 58);
            this.DifficulteGrB.TabIndex = 10;
            this.DifficulteGrB.TabStop = false;
            this.DifficulteGrB.Text = "Difficulté choisie : %diff%";
            // 
            // DifficulteLb
            // 
            this.DifficulteLb.AutoSize = true;
            this.DifficulteLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficulteLb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DifficulteLb.Location = new System.Drawing.Point(24, 26);
            this.DifficulteLb.Name = "DifficulteLb";
            this.DifficulteLb.Size = new System.Drawing.Size(142, 16);
            this.DifficulteLb.TabIndex = 4;
            this.DifficulteLb.Text = "%Consigne Difficulte%";
            // 
            // EnonceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.DifficulteGrB);
            this.Controls.Add(this.ExempleGrB);
            this.Controls.Add(this.EnonceGrB);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.LancerBtn);
            this.Controls.Add(this.TitreLb);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "EnonceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test ESA - Nom du test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestEnonce_FormClosing);
            this.Load += new System.EventHandler(this.EnonceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExempleImg)).EndInit();
            this.EnonceGrB.ResumeLayout(false);
            this.ExempleGrB.ResumeLayout(false);
            this.DifficulteGrB.ResumeLayout(false);
            this.DifficulteGrB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Label EnonceLb;
        private System.Windows.Forms.PictureBox ExempleImg;
        private System.Windows.Forms.Button LancerBtn;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.GroupBox EnonceGrB;
        private System.Windows.Forms.GroupBox ExempleGrB;
        private System.Windows.Forms.Label ExempleLb;
        private System.Windows.Forms.GroupBox DifficulteGrB;
        private System.Windows.Forms.Label DifficulteLb;
    }
}