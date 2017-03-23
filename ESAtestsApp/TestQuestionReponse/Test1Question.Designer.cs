namespace ESAtestsApp
{
    partial class Test1QuestionForm
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
            this.MenuPrincipalBtn = new System.Windows.Forms.Button();
            this.EnnonceQuestionLb = new System.Windows.Forms.Label();
            this.NumQuestionLb = new System.Windows.Forms.Label();
            this.DemarrerBtn = new System.Windows.Forms.Button();
            this.AffichageTmr = new System.Windows.Forms.Timer(this.components);
            this.ReponseGb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reponse3vfLb = new System.Windows.Forms.Label();
            this.Reponse4vfLb = new System.Windows.Forms.Label();
            this.Reponse2vfLb = new System.Windows.Forms.Label();
            this.Reponse1vfLb = new System.Windows.Forms.Label();
            this.Reponse4Tb = new System.Windows.Forms.TextBox();
            this.Reponse2Tb = new System.Windows.Forms.TextBox();
            this.Reponse3Tb = new System.Windows.Forms.TextBox();
            this.Reponse1Tb = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.AfficheRepTmr = new System.Windows.Forms.Timer(this.components);
            this.TempsLb = new System.Windows.Forms.Label();
            this.SecondeTmr = new System.Windows.Forms.Timer(this.components);
            this.QuestionGb = new System.Windows.Forms.GroupBox();
            this.SablierPb = new System.Windows.Forms.PictureBox();
            this.TitreLb = new System.Windows.Forms.Label();
            this.ReponseGb.SuspendLayout();
            this.QuestionGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SablierPb)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipalBtn
            // 
            this.MenuPrincipalBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuPrincipalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuPrincipalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipalBtn.Location = new System.Drawing.Point(670, 76);
            this.MenuPrincipalBtn.Name = "MenuPrincipalBtn";
            this.MenuPrincipalBtn.Size = new System.Drawing.Size(106, 32);
            this.MenuPrincipalBtn.TabIndex = 3;
            this.MenuPrincipalBtn.Text = "Menu principal";
            this.MenuPrincipalBtn.UseVisualStyleBackColor = false;
            this.MenuPrincipalBtn.Click += new System.EventHandler(this.MenuPrincipalBtn_Click);
            // 
            // EnnonceQuestionLb
            // 
            this.EnnonceQuestionLb.AutoSize = true;
            this.EnnonceQuestionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnnonceQuestionLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnnonceQuestionLb.Location = new System.Drawing.Point(30, 29);
            this.EnnonceQuestionLb.Name = "EnnonceQuestionLb";
            this.EnnonceQuestionLb.Size = new System.Drawing.Size(54, 16);
            this.EnnonceQuestionLb.TabIndex = 2;
            this.EnnonceQuestionLb.Text = "Enonce";
            // 
            // NumQuestionLb
            // 
            this.NumQuestionLb.AutoSize = true;
            this.NumQuestionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumQuestionLb.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.NumQuestionLb.Location = new System.Drawing.Point(6, -3);
            this.NumQuestionLb.Name = "NumQuestionLb";
            this.NumQuestionLb.Size = new System.Drawing.Size(97, 20);
            this.NumQuestionLb.TabIndex = 1;
            this.NumQuestionLb.Text = "Question ../..";
            this.NumQuestionLb.Visible = false;
            // 
            // DemarrerBtn
            // 
            this.DemarrerBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DemarrerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DemarrerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemarrerBtn.Location = new System.Drawing.Point(273, 501);
            this.DemarrerBtn.Name = "DemarrerBtn";
            this.DemarrerBtn.Size = new System.Drawing.Size(225, 53);
            this.DemarrerBtn.TabIndex = 17;
            this.DemarrerBtn.Text = "Lancer le test";
            this.DemarrerBtn.UseVisualStyleBackColor = false;
            this.DemarrerBtn.Click += new System.EventHandler(this.DemarrerBtn_Click);
            // 
            // AffichageTmr
            // 
            this.AffichageTmr.Interval = 1000;
            this.AffichageTmr.Tick += new System.EventHandler(this.AffichageTmr_Tick);
            // 
            // ReponseGb
            // 
            this.ReponseGb.Controls.Add(this.label1);
            this.ReponseGb.Controls.Add(this.Reponse3vfLb);
            this.ReponseGb.Controls.Add(this.Reponse4vfLb);
            this.ReponseGb.Controls.Add(this.Reponse2vfLb);
            this.ReponseGb.Controls.Add(this.Reponse1vfLb);
            this.ReponseGb.Controls.Add(this.Reponse4Tb);
            this.ReponseGb.Controls.Add(this.Reponse2Tb);
            this.ReponseGb.Controls.Add(this.Reponse3Tb);
            this.ReponseGb.Controls.Add(this.Reponse1Tb);
            this.ReponseGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReponseGb.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ReponseGb.Location = new System.Drawing.Point(58, 271);
            this.ReponseGb.Name = "ReponseGb";
            this.ReponseGb.Size = new System.Drawing.Size(718, 156);
            this.ReponseGb.TabIndex = 18;
            this.ReponseGb.TabStop = false;
            this.ReponseGb.Text = "Réponses";
            this.ReponseGb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Donnez les chiffres associés : ";
            // 
            // Reponse3vfLb
            // 
            this.Reponse3vfLb.AutoSize = true;
            this.Reponse3vfLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reponse3vfLb.ForeColor = System.Drawing.Color.Red;
            this.Reponse3vfLb.Location = new System.Drawing.Point(391, 114);
            this.Reponse3vfLb.Name = "Reponse3vfLb";
            this.Reponse3vfLb.Size = new System.Drawing.Size(126, 16);
            this.Reponse3vfLb.TabIndex = 12;
            this.Reponse3vfLb.Text = "Mauvaise Reponse";
            this.Reponse3vfLb.Visible = false;
            // 
            // Reponse4vfLb
            // 
            this.Reponse4vfLb.AutoSize = true;
            this.Reponse4vfLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reponse4vfLb.ForeColor = System.Drawing.Color.Red;
            this.Reponse4vfLb.Location = new System.Drawing.Point(547, 114);
            this.Reponse4vfLb.Name = "Reponse4vfLb";
            this.Reponse4vfLb.Size = new System.Drawing.Size(126, 16);
            this.Reponse4vfLb.TabIndex = 11;
            this.Reponse4vfLb.Text = "Mauvaise Reponse";
            this.Reponse4vfLb.Visible = false;
            // 
            // Reponse2vfLb
            // 
            this.Reponse2vfLb.AutoSize = true;
            this.Reponse2vfLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reponse2vfLb.ForeColor = System.Drawing.Color.Red;
            this.Reponse2vfLb.Location = new System.Drawing.Point(235, 114);
            this.Reponse2vfLb.Name = "Reponse2vfLb";
            this.Reponse2vfLb.Size = new System.Drawing.Size(126, 16);
            this.Reponse2vfLb.TabIndex = 10;
            this.Reponse2vfLb.Text = "Mauvaise Reponse";
            this.Reponse2vfLb.Visible = false;
            // 
            // Reponse1vfLb
            // 
            this.Reponse1vfLb.AutoSize = true;
            this.Reponse1vfLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reponse1vfLb.ForeColor = System.Drawing.Color.Red;
            this.Reponse1vfLb.Location = new System.Drawing.Point(69, 114);
            this.Reponse1vfLb.Name = "Reponse1vfLb";
            this.Reponse1vfLb.Size = new System.Drawing.Size(126, 16);
            this.Reponse1vfLb.TabIndex = 9;
            this.Reponse1vfLb.Text = "Mauvaise Reponse";
            this.Reponse1vfLb.Visible = false;
            // 
            // Reponse4Tb
            // 
            this.Reponse4Tb.Location = new System.Drawing.Point(551, 74);
            this.Reponse4Tb.Name = "Reponse4Tb";
            this.Reponse4Tb.Size = new System.Drawing.Size(69, 26);
            this.Reponse4Tb.TabIndex = 7;
            this.Reponse4Tb.Visible = false;
            this.Reponse4Tb.TextChanged += new System.EventHandler(this.Reponse4TB_TextChanged);
            // 
            // Reponse2Tb
            // 
            this.Reponse2Tb.Location = new System.Drawing.Point(241, 74);
            this.Reponse2Tb.Name = "Reponse2Tb";
            this.Reponse2Tb.Size = new System.Drawing.Size(69, 26);
            this.Reponse2Tb.TabIndex = 5;
            this.Reponse2Tb.TextChanged += new System.EventHandler(this.Reponse2TB_TextChanged);
            // 
            // Reponse3Tb
            // 
            this.Reponse3Tb.Location = new System.Drawing.Point(397, 74);
            this.Reponse3Tb.Name = "Reponse3Tb";
            this.Reponse3Tb.Size = new System.Drawing.Size(69, 26);
            this.Reponse3Tb.TabIndex = 6;
            this.Reponse3Tb.TextChanged += new System.EventHandler(this.Reponse3TB_TextChanged);
            // 
            // Reponse1Tb
            // 
            this.Reponse1Tb.Location = new System.Drawing.Point(74, 74);
            this.Reponse1Tb.Name = "Reponse1Tb";
            this.Reponse1Tb.Size = new System.Drawing.Size(69, 26);
            this.Reponse1Tb.TabIndex = 4;
            this.Reponse1Tb.TextChanged += new System.EventHandler(this.Reponse1TB_TextChanged);
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.Location = new System.Drawing.Point(664, 513);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(112, 41);
            this.OKBtn.TabIndex = 19;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Visible = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // AfficheRepTmr
            // 
            this.AfficheRepTmr.Interval = 1;
            this.AfficheRepTmr.Tick += new System.EventHandler(this.AfficheRepTmr_Tick);
            // 
            // TempsLb
            // 
            this.TempsLb.AutoSize = true;
            this.TempsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempsLb.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.TempsLb.Location = new System.Drawing.Point(559, 527);
            this.TempsLb.Name = "TempsLb";
            this.TempsLb.Size = new System.Drawing.Size(54, 18);
            this.TempsLb.TabIndex = 20;
            this.TempsLb.Text = "Temps";
            this.TempsLb.Visible = false;
            // 
            // SecondeTmr
            // 
            this.SecondeTmr.Interval = 1000;
            this.SecondeTmr.Tick += new System.EventHandler(this.SecondeTmr_Tick);
            // 
            // QuestionGb
            // 
            this.QuestionGb.Controls.Add(this.NumQuestionLb);
            this.QuestionGb.Controls.Add(this.EnnonceQuestionLb);
            this.QuestionGb.Location = new System.Drawing.Point(58, 114);
            this.QuestionGb.Name = "QuestionGb";
            this.QuestionGb.Size = new System.Drawing.Size(718, 59);
            this.QuestionGb.TabIndex = 21;
            this.QuestionGb.TabStop = false;
            this.QuestionGb.Text = "groupBox1";
            this.QuestionGb.Visible = false;
            // 
            // SablierPb
            // 
            this.SablierPb.Image = global::ESAtestsApp.Properties.Resources.hourglass;
            this.SablierPb.Location = new System.Drawing.Point(535, 520);
            this.SablierPb.Name = "SablierPb";
            this.SablierPb.Size = new System.Drawing.Size(35, 34);
            this.SablierPb.TabIndex = 22;
            this.SablierPb.TabStop = false;
            this.SablierPb.Visible = false;
            // 
            // TitreLb
            // 
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitreLb.Image = global::ESAtestsApp.Properties.Resources.Fond;
            this.TitreLb.Location = new System.Drawing.Point(0, 0);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.TitreLb.Size = new System.Drawing.Size(834, 65);
            this.TitreLb.TabIndex = 0;
            this.TitreLb.Text = "Perception et mémoire associative";
            // 
            // Test1QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.QuestionGb);
            this.Controls.Add(this.TempsLb);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.ReponseGb);
            this.Controls.Add(this.DemarrerBtn);
            this.Controls.Add(this.MenuPrincipalBtn);
            this.Controls.Add(this.TitreLb);
            this.Controls.Add(this.SablierPb);
            this.Name = "Test1QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test ESA - Perception et mémoire associative";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test1Question_FormClosing);
            this.Load += new System.EventHandler(this.Test1QuestionForm_Load);
            this.ReponseGb.ResumeLayout(false);
            this.ReponseGb.PerformLayout();
            this.QuestionGb.ResumeLayout(false);
            this.QuestionGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SablierPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuPrincipalBtn;
        private System.Windows.Forms.Label EnnonceQuestionLb;
        private System.Windows.Forms.Label NumQuestionLb;
        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Button DemarrerBtn;
        private System.Windows.Forms.Timer AffichageTmr;
        private System.Windows.Forms.GroupBox ReponseGb;
        private System.Windows.Forms.TextBox Reponse4Tb;
        private System.Windows.Forms.TextBox Reponse2Tb;
        private System.Windows.Forms.TextBox Reponse3Tb;
        private System.Windows.Forms.TextBox Reponse1Tb;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label Reponse3vfLb;
        private System.Windows.Forms.Label Reponse4vfLb;
        private System.Windows.Forms.Label Reponse2vfLb;
        private System.Windows.Forms.Label Reponse1vfLb;
        private System.Windows.Forms.Timer AfficheRepTmr;
        private System.Windows.Forms.Label TempsLb;
        private System.Windows.Forms.Timer SecondeTmr;
        private System.Windows.Forms.GroupBox QuestionGb;
        private System.Windows.Forms.PictureBox SablierPb;
        private System.Windows.Forms.Label label1;

    }
}