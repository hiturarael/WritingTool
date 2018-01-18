namespace WritingToolForm.ProjectMenu.RaceManagement
{
    partial class RaceManagement
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
            this.btnAddRace = new System.Windows.Forms.Button();
            this.btnLoadRace = new System.Windows.Forms.Button();
            this.lbRaces = new System.Windows.Forms.ListBox();
            this.btnDelRace = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRace
            // 
            this.btnAddRace.Location = new System.Drawing.Point(12, 23);
            this.btnAddRace.Name = "btnAddRace";
            this.btnAddRace.Size = new System.Drawing.Size(104, 23);
            this.btnAddRace.TabIndex = 0;
            this.btnAddRace.Text = "Add New Race";
            this.btnAddRace.UseVisualStyleBackColor = true;
            // 
            // btnLoadRace
            // 
            this.btnLoadRace.Location = new System.Drawing.Point(12, 52);
            this.btnLoadRace.Name = "btnLoadRace";
            this.btnLoadRace.Size = new System.Drawing.Size(104, 23);
            this.btnLoadRace.TabIndex = 1;
            this.btnLoadRace.Text = "Load Race";
            this.btnLoadRace.UseVisualStyleBackColor = true;
            // 
            // lbRaces
            // 
            this.lbRaces.FormattingEnabled = true;
            this.lbRaces.Location = new System.Drawing.Point(165, 23);
            this.lbRaces.Name = "lbRaces";
            this.lbRaces.Size = new System.Drawing.Size(352, 251);
            this.lbRaces.TabIndex = 2;
            // 
            // btnDelRace
            // 
            this.btnDelRace.Location = new System.Drawing.Point(12, 81);
            this.btnDelRace.Name = "btnDelRace";
            this.btnDelRace.Size = new System.Drawing.Size(104, 23);
            this.btnDelRace.TabIndex = 3;
            this.btnDelRace.Text = "Delete Race";
            this.btnDelRace.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // RaceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 296);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelRace);
            this.Controls.Add(this.lbRaces);
            this.Controls.Add(this.btnLoadRace);
            this.Controls.Add(this.btnAddRace);
            this.Name = "RaceManagement";
            this.Text = "RaceManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRace;
        private System.Windows.Forms.Button btnLoadRace;
        private System.Windows.Forms.ListBox lbRaces;
        private System.Windows.Forms.Button btnDelRace;
        private System.Windows.Forms.Button btnExit;
    }
}