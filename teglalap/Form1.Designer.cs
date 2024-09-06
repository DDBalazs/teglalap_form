namespace teglalap
{
    partial class Form
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
            this.btszamol = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.txa = new System.Windows.Forms.TextBox();
            this.txb = new System.Windows.Forms.TextBox();
            this.lbcm = new System.Windows.Forms.Label();
            this.lbc = new System.Windows.Forms.Label();
            this.lbmegoa = new System.Windows.Forms.Label();
            this.lbmegob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btszamol
            // 
            this.btszamol.Location = new System.Drawing.Point(503, 42);
            this.btszamol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btszamol.Name = "btszamol";
            this.btszamol.Size = new System.Drawing.Size(159, 72);
            this.btszamol.TabIndex = 0;
            this.btszamol.Text = "Számolás";
            this.btszamol.UseVisualStyleBackColor = true;
            this.btszamol.Click += new System.EventHandler(this.btszamol_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(503, 139);
            this.btexit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(159, 72);
            this.btexit.TabIndex = 1;
            this.btexit.Text = "Kilépés";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Location = new System.Drawing.Point(108, 43);
            this.lba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(92, 13);
            this.lba.TabIndex = 2;
            this.lba.Text = "a oldal hossza:";
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Location = new System.Drawing.Point(108, 101);
            this.lbb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(92, 13);
            this.lbb.TabIndex = 3;
            this.lbb.Text = "b oldal hossza:";
            // 
            // txa
            // 
            this.txa.Location = new System.Drawing.Point(208, 35);
            this.txa.Name = "txa";
            this.txa.Size = new System.Drawing.Size(100, 20);
            this.txa.TabIndex = 4;
            // 
            // txb
            // 
            this.txb.Location = new System.Drawing.Point(208, 94);
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(100, 20);
            this.txb.TabIndex = 5;
            // 
            // lbcm
            // 
            this.lbcm.AutoSize = true;
            this.lbcm.Location = new System.Drawing.Point(315, 100);
            this.lbcm.Name = "lbcm";
            this.lbcm.Size = new System.Drawing.Size(23, 13);
            this.lbcm.TabIndex = 6;
            this.lbcm.Text = "cm";
            // 
            // lbc
            // 
            this.lbc.AutoSize = true;
            this.lbc.Location = new System.Drawing.Point(315, 42);
            this.lbc.Name = "lbc";
            this.lbc.Size = new System.Drawing.Size(23, 13);
            this.lbc.TabIndex = 7;
            this.lbc.Text = "cm";
            // 
            // lbmegoa
            // 
            this.lbmegoa.AutoSize = true;
            this.lbmegoa.Location = new System.Drawing.Point(111, 171);
            this.lbmegoa.Name = "lbmegoa";
            this.lbmegoa.Size = new System.Drawing.Size(41, 13);
            this.lbmegoa.TabIndex = 8;
            this.lbmegoa.Text = "label1";
            // 
            // lbmegob
            // 
            this.lbmegob.AutoSize = true;
            this.lbmegob.Location = new System.Drawing.Point(111, 220);
            this.lbmegob.Name = "lbmegob";
            this.lbmegob.Size = new System.Drawing.Size(41, 13);
            this.lbmegob.TabIndex = 9;
            this.lbmegob.Text = "label1";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(676, 285);
            this.Controls.Add(this.lbmegob);
            this.Controls.Add(this.lbmegoa);
            this.Controls.Add(this.lbc);
            this.Controls.Add(this.lbcm);
            this.Controls.Add(this.txb);
            this.Controls.Add(this.txa);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btszamol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form";
            this.Text = "Téglalap kerület és terület számítása";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btszamol;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.TextBox txa;
        private System.Windows.Forms.TextBox txb;
        private System.Windows.Forms.Label lbcm;
        private System.Windows.Forms.Label lbc;
        private System.Windows.Forms.Label lbmegoa;
        private System.Windows.Forms.Label lbmegob;
    }
}

