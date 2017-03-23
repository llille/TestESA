namespace ESAtestsApp
{
    partial class Test3OperationForm
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
            this.Consigne1Lb = new System.Windows.Forms.Label();
            this.AdditionBtn = new System.Windows.Forms.Button();
            this.SoustractionBtn = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.Multiplicationbtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitreLb.Image = global::ESAtestsApp.Properties.Resources.Fond;
            this.TitreLb.Location = new System.Drawing.Point(1, 1);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Padding = new System.Windows.Forms.Padding(40, 15, 0, 0);
            this.TitreLb.Size = new System.Drawing.Size(834, 65);
            this.TitreLb.TabIndex = 15;
            this.TitreLb.Text = "Calcul mental";
            // 
            // Consigne1Lb
            // 
            this.Consigne1Lb.AutoSize = true;
            this.Consigne1Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consigne1Lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Consigne1Lb.Location = new System.Drawing.Point(238, 153);
            this.Consigne1Lb.Name = "Consigne1Lb";
            this.Consigne1Lb.Size = new System.Drawing.Size(287, 20);
            this.Consigne1Lb.TabIndex = 16;
            this.Consigne1Lb.Text = "Choisissez une opération pour ce test : ";
            // 
            // AdditionBtn
            // 
            this.AdditionBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AdditionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdditionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionBtn.Location = new System.Drawing.Point(306, 229);
            this.AdditionBtn.Name = "AdditionBtn";
            this.AdditionBtn.Size = new System.Drawing.Size(156, 40);
            this.AdditionBtn.TabIndex = 17;
            this.AdditionBtn.Text = "+";
            this.AdditionBtn.UseVisualStyleBackColor = false;
            this.AdditionBtn.Click += new System.EventHandler(this.AdditionBtn_Click);
            // 
            // SoustractionBtn
            // 
            this.SoustractionBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SoustractionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoustractionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoustractionBtn.Location = new System.Drawing.Point(306, 307);
            this.SoustractionBtn.Name = "SoustractionBtn";
            this.SoustractionBtn.Size = new System.Drawing.Size(156, 40);
            this.SoustractionBtn.TabIndex = 18;
            this.SoustractionBtn.Text = "-";
            this.SoustractionBtn.UseVisualStyleBackColor = false;
            this.SoustractionBtn.Click += new System.EventHandler(this.SoustractionBtn_Click);
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DivisionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionBtn.Location = new System.Drawing.Point(306, 462);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(156, 40);
            this.DivisionBtn.TabIndex = 19;
            this.DivisionBtn.Text = "/";
            this.DivisionBtn.UseVisualStyleBackColor = false;
            this.DivisionBtn.Click += new System.EventHandler(this.DivisionBtn_Click);
            // 
            // Multiplicationbtn
            // 
            this.Multiplicationbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Multiplicationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiplicationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicationbtn.Location = new System.Drawing.Point(306, 382);
            this.Multiplicationbtn.Name = "Multiplicationbtn";
            this.Multiplicationbtn.Size = new System.Drawing.Size(156, 40);
            this.Multiplicationbtn.TabIndex = 20;
            this.Multiplicationbtn.Text = "x";
            this.Multiplicationbtn.UseVisualStyleBackColor = false;
            this.Multiplicationbtn.Click += new System.EventHandler(this.Multiplicationbtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(670, 76);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(106, 32);
            this.MenuBtn.TabIndex = 23;
            this.MenuBtn.Text = "Menu Principal";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // Test3OperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.Multiplicationbtn);
            this.Controls.Add(this.DivisionBtn);
            this.Controls.Add(this.SoustractionBtn);
            this.Controls.Add(this.AdditionBtn);
            this.Controls.Add(this.Consigne1Lb);
            this.Controls.Add(this.TitreLb);
            this.Name = "Test3OperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test ESA - Calcul mental";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test3Operation_FormClosing);
            this.Load += new System.EventHandler(this.Test3OperationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Label Consigne1Lb;
        private System.Windows.Forms.Button AdditionBtn;
        private System.Windows.Forms.Button SoustractionBtn;
        private System.Windows.Forms.Button DivisionBtn;
        private System.Windows.Forms.Button Multiplicationbtn;
        private System.Windows.Forms.Button MenuBtn;
    }
}