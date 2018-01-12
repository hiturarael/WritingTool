namespace WritingToolForm
{
    partial class Main
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
            this.grpBoxLoadPrj = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewPrj = new System.Windows.Forms.Button();
            this.brnLoadPrj = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.lblVrsnNum = new System.Windows.Forms.Label();
            this.listBoxPrjs = new System.Windows.Forms.ListBox();
            this.grpBoxLoadPrj.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxLoadPrj
            // 
            this.grpBoxLoadPrj.Controls.Add(this.listBoxPrjs);
            this.grpBoxLoadPrj.Location = new System.Drawing.Point(312, 15);
            this.grpBoxLoadPrj.Name = "grpBoxLoadPrj";
            this.grpBoxLoadPrj.Size = new System.Drawing.Size(340, 358);
            this.grpBoxLoadPrj.TabIndex = 0;
            this.grpBoxLoadPrj.TabStop = false;
            this.grpBoxLoadPrj.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStats);
            this.groupBox2.Controls.Add(this.brnLoadPrj);
            this.groupBox2.Controls.Add(this.btnNewPrj);
            this.groupBox2.Location = new System.Drawing.Point(15, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnNewPrj
            // 
            this.btnNewPrj.Location = new System.Drawing.Point(85, 19);
            this.btnNewPrj.Name = "btnNewPrj";
            this.btnNewPrj.Size = new System.Drawing.Size(75, 23);
            this.btnNewPrj.TabIndex = 0;
            this.btnNewPrj.Text = "New Project";
            this.btnNewPrj.UseVisualStyleBackColor = true;
            // 
            // brnLoadPrj
            // 
            this.brnLoadPrj.Location = new System.Drawing.Point(85, 68);
            this.brnLoadPrj.Name = "brnLoadPrj";
            this.brnLoadPrj.Size = new System.Drawing.Size(75, 23);
            this.brnLoadPrj.TabIndex = 1;
            this.brnLoadPrj.Text = "Load Project";
            this.brnLoadPrj.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(85, 119);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 23);
            this.btnStats.TabIndex = 2;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // lblVrsnNum
            // 
            this.lblVrsnNum.AutoSize = true;
            this.lblVrsnNum.Location = new System.Drawing.Point(12, 363);
            this.lblVrsnNum.Name = "lblVrsnNum";
            this.lblVrsnNum.Size = new System.Drawing.Size(88, 13);
            this.lblVrsnNum.TabIndex = 2;
            this.lblVrsnNum.Text = "Version Number: ";
            // 
            // listBoxPrjs
            // 
            this.listBoxPrjs.FormattingEnabled = true;
            this.listBoxPrjs.Location = new System.Drawing.Point(8, 19);
            this.listBoxPrjs.Name = "listBoxPrjs";
            this.listBoxPrjs.Size = new System.Drawing.Size(326, 329);
            this.listBoxPrjs.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 385);
            this.Controls.Add(this.lblVrsnNum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBoxLoadPrj);
            this.Name = "Main";
            this.Text = "Novel Writer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpBoxLoadPrj.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxLoadPrj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button brnLoadPrj;
        private System.Windows.Forms.Button btnNewPrj;
        private System.Windows.Forms.Label lblVrsnNum;
        private System.Windows.Forms.ListBox listBoxPrjs;
    }
}

