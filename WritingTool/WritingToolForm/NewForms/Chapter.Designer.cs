namespace WritingToolForm.NewForms
{
    partial class Chapter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.rtbChapter = new System.Windows.Forms.RichTextBox();
            this.btnSaveChapter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chapter Title";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(85, 34);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(1106, 20);
            this.txtBoxTitle.TabIndex = 1;
            // 
            // rtbChapter
            // 
            this.rtbChapter.Location = new System.Drawing.Point(15, 122);
            this.rtbChapter.Name = "rtbChapter";
            this.rtbChapter.Size = new System.Drawing.Size(1176, 577);
            this.rtbChapter.TabIndex = 2;
            this.rtbChapter.Text = "";
            // 
            // btnSaveChapter
            // 
            this.btnSaveChapter.Location = new System.Drawing.Point(1012, 731);
            this.btnSaveChapter.Name = "btnSaveChapter";
            this.btnSaveChapter.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChapter.TabIndex = 3;
            this.btnSaveChapter.Text = "Save";
            this.btnSaveChapter.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1116, 731);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 736);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Word Count:";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(85, 736);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(35, 13);
            this.lblWordCount.TabIndex = 6;
            this.lblWordCount.Text = "####";
            // 
            // Chapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 766);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChapter);
            this.Controls.Add(this.rtbChapter);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.label1);
            this.Name = "Chapter";
            this.Text = "Chapter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.RichTextBox rtbChapter;
        private System.Windows.Forms.Button btnSaveChapter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWordCount;
    }
}