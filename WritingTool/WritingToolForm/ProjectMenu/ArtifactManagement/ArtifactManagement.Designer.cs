namespace WritingToolForm.ProjectMenu.ArtifactManagement
{
    partial class ArtifactManagement
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
            this.btnDelArtifact = new System.Windows.Forms.Button();
            this.lbArtifacts = new System.Windows.Forms.ListBox();
            this.btnLoadArtifact = new System.Windows.Forms.Button();
            this.btnAddArtifact = new System.Windows.Forms.Button();
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
            // btnDelArtifact
            // 
            this.btnDelArtifact.Location = new System.Drawing.Point(18, 81);
            this.btnDelArtifact.Name = "btnDelArtifact";
            this.btnDelArtifact.Size = new System.Drawing.Size(122, 23);
            this.btnDelArtifact.TabIndex = 13;
            this.btnDelArtifact.Text = "Delete Artifact";
            this.btnDelArtifact.UseVisualStyleBackColor = true;
            // 
            // lbArtifacts
            // 
            this.lbArtifacts.FormattingEnabled = true;
            this.lbArtifacts.Location = new System.Drawing.Point(171, 23);
            this.lbArtifacts.Name = "lbArtifacts";
            this.lbArtifacts.Size = new System.Drawing.Size(352, 251);
            this.lbArtifacts.TabIndex = 12;
            // 
            // btnLoadArtifact
            // 
            this.btnLoadArtifact.Location = new System.Drawing.Point(18, 52);
            this.btnLoadArtifact.Name = "btnLoadArtifact";
            this.btnLoadArtifact.Size = new System.Drawing.Size(122, 23);
            this.btnLoadArtifact.TabIndex = 11;
            this.btnLoadArtifact.Text = "Load Artifact";
            this.btnLoadArtifact.UseVisualStyleBackColor = true;
            // 
            // btnAddArtifact
            // 
            this.btnAddArtifact.Location = new System.Drawing.Point(18, 23);
            this.btnAddArtifact.Name = "btnAddArtifact";
            this.btnAddArtifact.Size = new System.Drawing.Size(122, 23);
            this.btnAddArtifact.TabIndex = 10;
            this.btnAddArtifact.Text = "Add New Artifact";
            this.btnAddArtifact.UseVisualStyleBackColor = true;
            // 
            // ArtifactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 296);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelArtifact);
            this.Controls.Add(this.lbArtifacts);
            this.Controls.Add(this.btnLoadArtifact);
            this.Controls.Add(this.btnAddArtifact);
            this.Name = "ArtifactForm";
            this.Text = "ArtifactForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelArtifact;
        private System.Windows.Forms.ListBox lbArtifacts;
        private System.Windows.Forms.Button btnLoadArtifact;
        private System.Windows.Forms.Button btnAddArtifact;
    }
}