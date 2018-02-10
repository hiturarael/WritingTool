namespace Novelis.ProjectMenu.ChapterManagement
{
    partial class ChapterForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelChapter = new System.Windows.Forms.Button();
            this.lbChapters = new System.Windows.Forms.ListBox();
            this.btnLoadChapter = new System.Windows.Forms.Button();
            this.btnAddChapter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnDelChapter
            // 
            this.btnDelChapter.Location = new System.Drawing.Point(18, 81);
            this.btnDelChapter.Name = "btnDelChapter";
            this.btnDelChapter.Size = new System.Drawing.Size(122, 23);
            this.btnDelChapter.TabIndex = 13;
            this.btnDelChapter.Text = "Delete Chapter";
            this.btnDelChapter.UseVisualStyleBackColor = true;
            // 
            // lbChapters
            // 
            this.lbChapters.FormattingEnabled = true;
            this.lbChapters.Location = new System.Drawing.Point(171, 23);
            this.lbChapters.Name = "lbChapters";
            this.lbChapters.Size = new System.Drawing.Size(352, 251);
            this.lbChapters.TabIndex = 12;
            // 
            // btnLoadChapter
            // 
            this.btnLoadChapter.Location = new System.Drawing.Point(18, 52);
            this.btnLoadChapter.Name = "btnLoadChapter";
            this.btnLoadChapter.Size = new System.Drawing.Size(122, 23);
            this.btnLoadChapter.TabIndex = 11;
            this.btnLoadChapter.Text = "Load Chapter";
            this.btnLoadChapter.UseVisualStyleBackColor = true;
            // 
            // btnAddChapter
            // 
            this.btnAddChapter.Location = new System.Drawing.Point(18, 23);
            this.btnAddChapter.Name = "btnAddChapter";
            this.btnAddChapter.Size = new System.Drawing.Size(122, 23);
            this.btnAddChapter.TabIndex = 10;
            this.btnAddChapter.Text = "Add New Chapter";
            this.btnAddChapter.UseVisualStyleBackColor = true;
            this.btnAddChapter.Click += new System.EventHandler(this.BtnAddChapter_Click);
            // 
            // ChapterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 296);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelChapter);
            this.Controls.Add(this.lbChapters);
            this.Controls.Add(this.btnLoadChapter);
            this.Controls.Add(this.btnAddChapter);
            this.Name = "ChapterForm";
            this.Text = "ChapterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelChapter;
        private System.Windows.Forms.ListBox lbChapters;
        private System.Windows.Forms.Button btnLoadChapter;
        private System.Windows.Forms.Button btnAddChapter;
    }
}