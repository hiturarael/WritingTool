namespace WritingToolForm.ProjectMenu.CharacterManagement
{
    partial class CharacterForm
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
            this.btnDelChar = new System.Windows.Forms.Button();
            this.lbChars = new System.Windows.Forms.ListBox();
            this.btnLoadChar = new System.Windows.Forms.Button();
            this.btnAddChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnDelChar
            // 
            this.btnDelChar.Location = new System.Drawing.Point(18, 70);
            this.btnDelChar.Name = "btnDelChar";
            this.btnDelChar.Size = new System.Drawing.Size(122, 23);
            this.btnDelChar.TabIndex = 8;
            this.btnDelChar.Text = "Delete Character";
            this.btnDelChar.UseVisualStyleBackColor = true;
            // 
            // lbChars
            // 
            this.lbChars.FormattingEnabled = true;
            this.lbChars.Location = new System.Drawing.Point(171, 12);
            this.lbChars.Name = "lbChars";
            this.lbChars.Size = new System.Drawing.Size(352, 251);
            this.lbChars.TabIndex = 7;
            // 
            // btnLoadChar
            // 
            this.btnLoadChar.Location = new System.Drawing.Point(18, 41);
            this.btnLoadChar.Name = "btnLoadChar";
            this.btnLoadChar.Size = new System.Drawing.Size(122, 23);
            this.btnLoadChar.TabIndex = 6;
            this.btnLoadChar.Text = "Load Character";
            this.btnLoadChar.UseVisualStyleBackColor = true;
            // 
            // btnAddChar
            // 
            this.btnAddChar.Location = new System.Drawing.Point(18, 12);
            this.btnAddChar.Name = "btnAddChar";
            this.btnAddChar.Size = new System.Drawing.Size(122, 23);
            this.btnAddChar.TabIndex = 5;
            this.btnAddChar.Text = "Add New Character";
            this.btnAddChar.UseVisualStyleBackColor = true;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 296);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelChar);
            this.Controls.Add(this.lbChars);
            this.Controls.Add(this.btnLoadChar);
            this.Controls.Add(this.btnAddChar);
            this.Name = "CharacterForm";
            this.Text = "CharacterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelChar;
        private System.Windows.Forms.ListBox lbChars;
        private System.Windows.Forms.Button btnLoadChar;
        private System.Windows.Forms.Button btnAddChar;
    }
}