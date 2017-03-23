namespace ESAtestsApp
{
    partial class Test3QuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitreLb = new System.Windows.Forms.Label();
            this.MenuPrincipalBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.ReponseTextLb = new System.Windows.Forms.TextBox();
            this.ReponseGb = new System.Windows.Forms.GroupBox();
            this.VraiOuFauxLb = new System.Windows.Forms.Label();
            this.TempsLb = new System.Windows.Forms.Label();
            this.EnnonceGb = new System.Windows.Forms.GroupBox();
            this.EnnonceQuestionLb = new System.Windows.Forms.Label();
            this.AffichageRepTmr = new System.Windows.Forms.Timer(this.components);
            this.TempsRepTmr = new System.Windows.Forms.Timer(this.components);
            this.FiniTmr = new System.Windows.Forms.Timer(this.components);
            this.SecondeTmr = new System.Windows.Forms.Timer(this.components);
            this.SablierPb = new System.Windows.Forms.PictureBox();
            this.DemarerBtn = new System.Windows.Forms.Button();
            this.ReponseGb.SuspendLayout();
            this.EnnonceGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SablierPb)).BeginInit();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitreLb.Image = global::ESAtestsApp.Properties.Resources.Fond;
            this.TitreLb.Location = new System.Drawing.Point(1, 2);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.TitreLb.Size = new System.Drawing.Size(834, 65);
            this.TitreLb.TabIndex = 2;
            this.TitreLb.Text = "Calcul mental";
            // 
            // MenuPrincipalBtn
            // 
            this.MenuPrincipalBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuPrincipalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuPrincipalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipalBtn.Location = new System.Drawing.Point(670, 76);
            this.MenuPrincipalBtn.Name = "MenuPrincipalBtn";
            this.MenuPrincipalBtn.Size = new System.Drawing.Size(106, 32);
            this.MenuPrincipalBtn.TabIndex = 5;
            this.MenuPrincipalBtn.Text = "Menu principal";
            this.MenuPrincipalBtn.UseVisualStyleBackColor = false;
            this.MenuPrincipalBtn.Click += new System.EventHandler(this.MenuPrincipalBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Location = new System.Drawing.Point(664, 513);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(112, 41);
            this.OKBtn.TabIndex = 8;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Visible = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ReponseTextLb
            // 
            this.ReponseTextLb.Location = new System.Drawing.Point(161, 54);
            this.ReponseTextLb.Name = "ReponseTextLb";
            this.ReponseTextLb.Size = new System.Drawing.Size(140, 26);
            this.ReponseTextLb.TabIndex = 10;
            this.ReponseTextLb.TextChanged += new System.EventHandler(this.ReponseTextLb_TextChanged);
            // 
            // ReponseGb
            // 
            this.ReponseGb.Controls.Add(this.ReponseTextLb);
            this.ReponseGb.Controls.Add(this.VraiOuFauxLb);
            this.ReponseGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReponseGb.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ReponseGb.Location = new System.Drawing.Point(56, 342);
            this.ReponseGb.Name = "ReponseGb";
            this.ReponseGb.Size = new System.Drawing.Size(720, 132);
            this.ReponseGb.TabIndex = 11;
            this.ReponseGb.TabStop = false;
            this.ReponseGb.Text = "Réponse";
            // 
            // VraiOuFauxLb
            // 
            this.VraiOuFauxLb.AutoSize = true;
            this.VraiOuFauxLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VraiOuFauxLb.ForeColor = System.Drawing.Color.Red;
            this.VraiOuFauxLb.Location = new System.Drawing.Point(158, 85);
            this.VraiOuFauxLb.Name = "VraiOuFauxLb";
            this.VraiOuFauxLb.Size = new System.Drawing.Size(45, 16);
            this.VraiOuFauxLb.TabIndex = 12;
            this.VraiOuFauxLb.Text = "label1";
            this.VraiOuFauxLb.Visible = false;
            // 
            // TempsLb
            // 
            this.TempsLb.AutoSize = true;
            this.TempsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempsLb.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.TempsLb.Location = new System.Drawing.Point(549, 523);
            this.TempsLb.Name = "TempsLb";
            this.TempsLb.Size = new System.Drawing.Size(43, 20);
            this.TempsLb.TabIndex = 11;
            this.TempsLb.Text = "Time";
            this.TempsLb.Visible = false;
            // 
            // EnnonceGb
            // 
            this.EnnonceGb.AutoSize = true;
            this.EnnonceGb.Controls.Add(this.EnnonceQuestionLb);
            this.EnnonceGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnnonceGb.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.EnnonceGb.Location = new System.Drawing.Point(56, 153);
            this.EnnonceGb.Name = "EnnonceGb";
            this.EnnonceGb.Size = new System.Drawing.Size(718, 137);
            this.EnnonceGb.TabIndex = 13;
            this.EnnonceGb.TabStop = false;
            this.EnnonceGb.Text = "Question 1/10";
            // 
            // EnnonceQuestionLb
            // 
            this.EnnonceQuestionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnnonceQuestionLb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnnonceQuestionLb.Location = new System.Drawing.Point(84, 72);
            this.EnnonceQuestionLb.Name = "EnnonceQuestionLb";
            this.EnnonceQuestionLb.Size = new System.Drawing.Size(537, 37);
            this.EnnonceQuestionLb.TabIndex = 7;
            this.EnnonceQuestionLb.Text = "Enonce ";
            // 
            // AffichageRepTmr
            // 
            this.AffichageRepTmr.Interval = 4000;
            this.AffichageRepTmr.Tick += new System.EventHandler(this.AffichageRepTmr_Tick);
            // 
            // TempsRepTmr
            // 
            this.TempsRepTmr.Interval = 5000;
            this.TempsRepTmr.Tick += new System.EventHandler(this.TempsRepTmr_Tick);
            // 
            // FiniTmr
            // 
            this.FiniTmr.Interval = 4000;
            this.FiniTmr.Tick += new System.EventHandler(this.FiniTmr_Tick);
            // 
            // SecondeTmr
            // 
            this.SecondeTmr.Interval = 1000;
            this.SecondeTmr.Tick += new System.EventHandler(this.SecondeTmr_Tick);
            // 
            // SablierPb
            // 
            this.SablierPb.Image = global::ESAtestsApp.Properties.Resources.hourglass;
            this.SablierPb.Location = new System.Drawing.Point(525, 516);
            this.SablierPb.Name = "SablierPb";
            this.SablierPb.Size = new System.Drawing.Size(35, 34);
            this.SablierPb.TabIndex = 15;
            this.SablierPb.TabStop = false;
            this.SablierPb.Visible = false;
            // 
            // DemarerBtn
            // 
            this.DemarerBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DemarerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DemarerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemarerBtn.Location = new System.Drawing.Point(273, 501);
            this.DemarerBtn.Name = "DemarerBtn";
            this.DemarerBtn.Size = new System.Drawing.Size(225, 53);
            this.DemarerBtn.TabIndex = 16;
            this.DemarerBtn.Text = "Lancer le test";
            this.DemarerBtn.UseVisualStyleBackColor = false;
            this.DemarerBtn.Visible = false;
            this.DemarerBtn.Click += new System.EventHandler(this.DemarerLb_Click);
            // 
            // Test3QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.DemarerBtn);
            this.Controls.Add(this.TempsLb);
            this.Controls.Add(this.EnnonceGb);
            this.Controls.Add(this.ReponseGb);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.MenuPrincipalBtn);
            this.Controls.Add(this.TitreLb);
            this.Controls.Add(this.SablierPb);
            this.Name = "Test3QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test ESA - Calcul mental";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test3Question_FormClosing);
            this.Load += new System.EventHandler(this.Test3QuestionForm_Load);
            this.ReponseGb.ResumeLayout(false);
            this.ReponseGb.PerformLayout();
            this.EnnonceGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SablierPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Button MenuPrincipalBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.TextBox ReponseTextLb;
        private System.Windows.Forms.GroupBox ReponseGb;
        private System.Windows.Forms.Label VraiOuFauxLb;
        private System.Windows.Forms.GroupBox EnnonceGb;
        private System.Windows.Forms.Label EnnonceQuestionLb;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label TempsLb;
        private System.Windows.Forms.Timer AffichageRepTmr;
        private System.Windows.Forms.Timer TempsRepTmr;
        private System.Windows.Forms.Timer FiniTmr;
        private System.Windows.Forms.Timer SecondeTmr;
        private System.Windows.Forms.PictureBox SablierPb;
        private System.Windows.Forms.Button DemarerBtn;
    }
}