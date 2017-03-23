namespace ESAtestsApp
{
    partial class Test2QuestionForm
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
            this.components = new System.ComponentModel.Container();
            this.TitreLb = new System.Windows.Forms.Label();
            this.NumQuestionLb = new System.Windows.Forms.Label();
            this.EnnonceQuestionLb = new System.Windows.Forms.Label();
            this.MenuPrincipalBtn = new System.Windows.Forms.Button();
            this.Choix1Btn = new System.Windows.Forms.Button();
            this.Choix2Btn = new System.Windows.Forms.Button();
            this.Choix3Btn = new System.Windows.Forms.Button();
            this.AffichageRepTmr = new System.Windows.Forms.Timer(this.components);
            this.VraiOuFauxLb = new System.Windows.Forms.Label();
            this.AfficheOnLoadTmr = new System.Windows.Forms.Timer(this.components);
            this.TempsRepTmr = new System.Windows.Forms.Timer(this.components);
            this.SecondeTmr = new System.Windows.Forms.Timer(this.components);
            this.SablierPb = new System.Windows.Forms.PictureBox();
            this.QuestionGb = new System.Windows.Forms.GroupBox();
            this.RappelLb = new System.Windows.Forms.Label();
            this.TimeLb = new System.Windows.Forms.Label();
            this.ReponseLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SablierPb)).BeginInit();
            this.QuestionGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitreLb.Image = global::ESAtestsApp.Properties.Resources.Fond;
            this.TitreLb.Location = new System.Drawing.Point(0, 1);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.TitreLb.Size = new System.Drawing.Size(834, 65);
            this.TitreLb.TabIndex = 1;
            this.TitreLb.Text = "Attention et concentration";
            // 
            // NumQuestionLb
            // 
            this.NumQuestionLb.AutoSize = true;
            this.NumQuestionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumQuestionLb.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.NumQuestionLb.Location = new System.Drawing.Point(6, -3);
            this.NumQuestionLb.Name = "NumQuestionLb";
            this.NumQuestionLb.Size = new System.Drawing.Size(99, 20);
            this.NumQuestionLb.TabIndex = 2;
            this.NumQuestionLb.Text = "Question 1/5";
            // 
            // EnnonceQuestionLb
            // 
            this.EnnonceQuestionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnnonceQuestionLb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnnonceQuestionLb.Location = new System.Drawing.Point(23, 54);
            this.EnnonceQuestionLb.Name = "EnnonceQuestionLb";
            this.EnnonceQuestionLb.Size = new System.Drawing.Size(669, 59);
            this.EnnonceQuestionLb.TabIndex = 3;
            this.EnnonceQuestionLb.Text = "Ennonce Butt1 = ... Butt2 = .. Butt 3 = ..";
            // 
            // MenuPrincipalBtn
            // 
            this.MenuPrincipalBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuPrincipalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuPrincipalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipalBtn.Location = new System.Drawing.Point(670, 76);
            this.MenuPrincipalBtn.Name = "MenuPrincipalBtn";
            this.MenuPrincipalBtn.Size = new System.Drawing.Size(106, 32);
            this.MenuPrincipalBtn.TabIndex = 4;
            this.MenuPrincipalBtn.Text = "Menu principal";
            this.MenuPrincipalBtn.UseVisualStyleBackColor = false;
            this.MenuPrincipalBtn.Click += new System.EventHandler(this.MenuPrincipalBtn_Click);
            // 
            // Choix1Btn
            // 
            this.Choix1Btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Choix1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choix1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choix1Btn.Location = new System.Drawing.Point(568, 292);
            this.Choix1Btn.Name = "Choix1Btn";
            this.Choix1Btn.Size = new System.Drawing.Size(119, 29);
            this.Choix1Btn.TabIndex = 5;
            this.Choix1Btn.Text = "Butt1";
            this.Choix1Btn.UseVisualStyleBackColor = false;
            this.Choix1Btn.Visible = false;
            this.Choix1Btn.Click += new System.EventHandler(this.Choix1Btn_Click);
            // 
            // Choix2Btn
            // 
            this.Choix2Btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Choix2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choix2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choix2Btn.Location = new System.Drawing.Point(568, 351);
            this.Choix2Btn.Name = "Choix2Btn";
            this.Choix2Btn.Size = new System.Drawing.Size(119, 29);
            this.Choix2Btn.TabIndex = 6;
            this.Choix2Btn.Text = "Butt2";
            this.Choix2Btn.UseVisualStyleBackColor = false;
            this.Choix2Btn.Visible = false;
            this.Choix2Btn.Click += new System.EventHandler(this.Choix2Btn_Click);
            // 
            // Choix3Btn
            // 
            this.Choix3Btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Choix3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choix3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choix3Btn.Location = new System.Drawing.Point(567, 408);
            this.Choix3Btn.Name = "Choix3Btn";
            this.Choix3Btn.Size = new System.Drawing.Size(120, 29);
            this.Choix3Btn.TabIndex = 7;
            this.Choix3Btn.Text = "Butt3";
            this.Choix3Btn.UseVisualStyleBackColor = false;
            this.Choix3Btn.Click += new System.EventHandler(this.Choix3Btn_Click);
            // 
            // AffichageRepTmr
            // 
            this.AffichageRepTmr.Interval = 3000;
            this.AffichageRepTmr.Tick += new System.EventHandler(this.AffichageRepTmr_Tick);
            // 
            // VraiOuFauxLb
            // 
            this.VraiOuFauxLb.AutoSize = true;
            this.VraiOuFauxLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VraiOuFauxLb.ForeColor = System.Drawing.Color.Red;
            this.VraiOuFauxLb.Location = new System.Drawing.Point(65, 485);
            this.VraiOuFauxLb.Name = "VraiOuFauxLb";
            this.VraiOuFauxLb.Size = new System.Drawing.Size(26, 16);
            this.VraiOuFauxLb.TabIndex = 8;
            this.VraiOuFauxLb.Text = "OK";
            this.VraiOuFauxLb.Visible = false;
            // 
            // AfficheOnLoadTmr
            // 
            this.AfficheOnLoadTmr.Interval = 1;
            this.AfficheOnLoadTmr.Tick += new System.EventHandler(this.AfficheOnLoadTmr_Tick);
            // 
            // TempsRepTmr
            // 
            this.TempsRepTmr.Interval = 1000;
            this.TempsRepTmr.Tick += new System.EventHandler(this.TempsRepTmr_Tick);
            // 
            // SecondeTmr
            // 
            this.SecondeTmr.Interval = 1000;
            this.SecondeTmr.Tick += new System.EventHandler(this.SecondeTmr_Tick);
            // 
            // SablierPb
            // 
            this.SablierPb.Image = global::ESAtestsApp.Properties.Resources.hourglass;
            this.SablierPb.Location = new System.Drawing.Point(567, 525);
            this.SablierPb.Name = "SablierPb";
            this.SablierPb.Size = new System.Drawing.Size(35, 34);
            this.SablierPb.TabIndex = 10;
            this.SablierPb.TabStop = false;
            this.SablierPb.Visible = false;
            // 
            // QuestionGb
            // 
            this.QuestionGb.Controls.Add(this.RappelLb);
            this.QuestionGb.Controls.Add(this.EnnonceQuestionLb);
            this.QuestionGb.Controls.Add(this.NumQuestionLb);
            this.QuestionGb.Location = new System.Drawing.Point(58, 114);
            this.QuestionGb.Name = "QuestionGb";
            this.QuestionGb.Size = new System.Drawing.Size(718, 116);
            this.QuestionGb.TabIndex = 11;
            this.QuestionGb.TabStop = false;
            this.QuestionGb.Text = "groupBox1";
            // 
            // RappelLb
            // 
            this.RappelLb.AutoSize = true;
            this.RappelLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RappelLb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RappelLb.Location = new System.Drawing.Point(23, 30);
            this.RappelLb.Name = "RappelLb";
            this.RappelLb.Size = new System.Drawing.Size(129, 16);
            this.RappelLb.TabIndex = 4;
            this.RappelLb.Text = "Rappel des règles : ";
            // 
            // TimeLb
            // 
            this.TimeLb.AutoSize = true;
            this.TimeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLb.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.TimeLb.Location = new System.Drawing.Point(591, 531);
            this.TimeLb.Name = "TimeLb";
            this.TimeLb.Size = new System.Drawing.Size(41, 18);
            this.TimeLb.TabIndex = 12;
            this.TimeLb.Text = "Time";
            this.TimeLb.Visible = false;
            // 
            // ReponseLb
            // 
            this.ReponseLb.AutoSize = true;
            this.ReponseLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReponseLb.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ReponseLb.Location = new System.Drawing.Point(62, 263);
            this.ReponseLb.Name = "ReponseLb";
            this.ReponseLb.Size = new System.Drawing.Size(90, 20);
            this.ReponseLb.TabIndex = 13;
            this.ReponseLb.Text = "Réponses :";
            // 
            // Test2QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.ReponseLb);
            this.Controls.Add(this.TimeLb);
            this.Controls.Add(this.QuestionGb);
            this.Controls.Add(this.SablierPb);
            this.Controls.Add(this.VraiOuFauxLb);
            this.Controls.Add(this.Choix1Btn);
            this.Controls.Add(this.MenuPrincipalBtn);
            this.Controls.Add(this.Choix3Btn);
            this.Controls.Add(this.Choix2Btn);
            this.Controls.Add(this.TitreLb);
            this.Name = "Test2QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test ESA - Attention et concentration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test2Question_FormClosing);
            this.Load += new System.EventHandler(this.Test2QuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SablierPb)).EndInit();
            this.QuestionGb.ResumeLayout(false);
            this.QuestionGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Label NumQuestionLb;
        private System.Windows.Forms.Label EnnonceQuestionLb;
        private System.Windows.Forms.Button MenuPrincipalBtn;
        private System.Windows.Forms.Button Choix1Btn;
        private System.Windows.Forms.Button Choix2Btn;
        private System.Windows.Forms.Button Choix3Btn;
        private System.Windows.Forms.Timer AffichageRepTmr;
        private System.Windows.Forms.Label VraiOuFauxLb;
        private System.Windows.Forms.Timer AfficheOnLoadTmr;
        private System.Windows.Forms.Timer TempsRepTmr;
        private System.Windows.Forms.Timer SecondeTmr;
        private System.Windows.Forms.PictureBox SablierPb;
        private System.Windows.Forms.GroupBox QuestionGb;
        private System.Windows.Forms.Label TimeLb;
        private System.Windows.Forms.Label ReponseLb;
        private System.Windows.Forms.Label RappelLb;
    }
}