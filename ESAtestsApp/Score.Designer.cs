namespace ESAtestsApp
{
    partial class ScoreForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitreLb = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.ScoresDataGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TestListB = new System.Windows.Forms.ListBox();
            this.Difficulte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScoresDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitreLb.Image = global::ESAtestsApp.Properties.Resources.Fond;
            this.TitreLb.Location = new System.Drawing.Point(1, 2);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.TitreLb.Size = new System.Drawing.Size(834, 65);
            this.TitreLb.TabIndex = 13;
            this.TitreLb.Text = "Test ESA—Scores";
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(670, 76);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(106, 32);
            this.MenuBtn.TabIndex = 15;
            this.MenuBtn.Text = "Menu Principal";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // ScoresDataGV
            // 
            this.ScoresDataGV.BackgroundColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScoresDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ScoresDataGV.ColumnHeadersHeight = 40;
            this.ScoresDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Difficulte,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.ScoresDataGV.Location = new System.Drawing.Point(405, 182);
            this.ScoresDataGV.Name = "ScoresDataGV";
            this.ScoresDataGV.ReadOnly = true;
            this.ScoresDataGV.Size = new System.Drawing.Size(399, 388);
            this.ScoresDataGV.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestListB
            // 
            this.TestListB.BackColor = System.Drawing.SystemColors.InfoText;
            this.TestListB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TestListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestListB.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.TestListB.FormattingEnabled = true;
            this.TestListB.ItemHeight = 20;
            this.TestListB.Items.AddRange(new object[] {
            "Perception et mémoire associative",
            "Attention et concentration",
            "Calcul mental",
            "Problèmes mathématiques",
            "Problèmes physiques"});
            this.TestListB.Location = new System.Drawing.Point(74, 182);
            this.TestListB.Name = "TestListB";
            this.TestListB.Size = new System.Drawing.Size(297, 322);
            this.TestListB.TabIndex = 27;
            this.TestListB.SelectedIndexChanged += new System.EventHandler(this.TestListB_SelectedIndexChanged);
            // 
            // Difficulte
            // 
            this.Difficulte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Difficulte.HeaderText = "Difficulté";
            this.Difficulte.Name = "Difficulte";
            this.Difficulte.ReadOnly = true;
            this.Difficulte.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Meilleur score";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Score moyen";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.TestListB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ScoresDataGV);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.TitreLb);
            this.Name = "ScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Score_FormClosing);
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoresDataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.DataGridView ScoresDataGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox TestListB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}