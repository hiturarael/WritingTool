namespace Novelis.ProjectMenu
{
    partial class ProjectMenu
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
            this.btnManageChar = new System.Windows.Forms.Button();
            this.btnManageChptr = new System.Windows.Forms.Button();
            this.btnManageRace = new System.Windows.Forms.Button();
            this.btnManageWorld = new System.Windows.Forms.Button();
            this.btnManageCreatures = new System.Windows.Forms.Button();
            this.btnManageArtifacts = new System.Windows.Forms.Button();
            this.btnPrjStatus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageChar
            // 
            this.btnManageChar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageChar.Location = new System.Drawing.Point(12, 82);
            this.btnManageChar.Name = "btnManageChar";
            this.btnManageChar.Size = new System.Drawing.Size(183, 27);
            this.btnManageChar.TabIndex = 0;
            this.btnManageChar.Text = "Manage Characters";
            this.btnManageChar.UseVisualStyleBackColor = true;
            this.btnManageChar.Click += new System.EventHandler(this.BtnManageChar_Click);
            // 
            // btnManageChptr
            // 
            this.btnManageChptr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageChptr.Location = new System.Drawing.Point(12, 26);
            this.btnManageChptr.Name = "btnManageChptr";
            this.btnManageChptr.Size = new System.Drawing.Size(183, 27);
            this.btnManageChptr.TabIndex = 1;
            this.btnManageChptr.Text = "Manage Chapters";
            this.btnManageChptr.UseVisualStyleBackColor = true;
            this.btnManageChptr.Click += new System.EventHandler(this.BtnManageChptr_Click);
            // 
            // btnManageRace
            // 
            this.btnManageRace.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRace.Location = new System.Drawing.Point(12, 115);
            this.btnManageRace.Name = "btnManageRace";
            this.btnManageRace.Size = new System.Drawing.Size(183, 27);
            this.btnManageRace.TabIndex = 2;
            this.btnManageRace.Text = "Manage Races";
            this.btnManageRace.UseVisualStyleBackColor = true;
            this.btnManageRace.Click += new System.EventHandler(this.BtnManageRace_Click);
            // 
            // btnManageWorld
            // 
            this.btnManageWorld.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageWorld.Location = new System.Drawing.Point(12, 148);
            this.btnManageWorld.Name = "btnManageWorld";
            this.btnManageWorld.Size = new System.Drawing.Size(183, 27);
            this.btnManageWorld.TabIndex = 3;
            this.btnManageWorld.Text = "Manage Locations";
            this.btnManageWorld.UseVisualStyleBackColor = true;
            this.btnManageWorld.Click += new System.EventHandler(this.BtnManageWorld_Click);
            // 
            // btnManageCreatures
            // 
            this.btnManageCreatures.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCreatures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCreatures.Location = new System.Drawing.Point(12, 181);
            this.btnManageCreatures.Name = "btnManageCreatures";
            this.btnManageCreatures.Size = new System.Drawing.Size(183, 27);
            this.btnManageCreatures.TabIndex = 4;
            this.btnManageCreatures.Text = "Manage Creatures";
            this.btnManageCreatures.UseVisualStyleBackColor = true;
            this.btnManageCreatures.Click += new System.EventHandler(this.BtnManageCreatures_Click);
            // 
            // btnManageArtifacts
            // 
            this.btnManageArtifacts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageArtifacts.Location = new System.Drawing.Point(12, 214);
            this.btnManageArtifacts.Name = "btnManageArtifacts";
            this.btnManageArtifacts.Size = new System.Drawing.Size(183, 27);
            this.btnManageArtifacts.TabIndex = 5;
            this.btnManageArtifacts.Text = "Manage Artifacts";
            this.btnManageArtifacts.UseVisualStyleBackColor = true;
            this.btnManageArtifacts.Click += new System.EventHandler(this.BtnManageArtifacts_Click);
            // 
            // btnPrjStatus
            // 
            this.btnPrjStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrjStatus.Location = new System.Drawing.Point(12, 272);
            this.btnPrjStatus.Name = "btnPrjStatus";
            this.btnPrjStatus.Size = new System.Drawing.Size(183, 27);
            this.btnPrjStatus.TabIndex = 6;
            this.btnPrjStatus.Text = "Project Stats";
            this.btnPrjStatus.UseVisualStyleBackColor = true;
            this.btnPrjStatus.Click += new System.EventHandler(this.BtnPrjStatus_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 27);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ProjectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 368);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrjStatus);
            this.Controls.Add(this.btnManageArtifacts);
            this.Controls.Add(this.btnManageCreatures);
            this.Controls.Add(this.btnManageWorld);
            this.Controls.Add(this.btnManageRace);
            this.Controls.Add(this.btnManageChptr);
            this.Controls.Add(this.btnManageChar);
            this.Name = "ProjectMenu";
            this.Text = "ProjectMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageChar;
        private System.Windows.Forms.Button btnManageChptr;
        private System.Windows.Forms.Button btnManageRace;
        private System.Windows.Forms.Button btnManageWorld;
        private System.Windows.Forms.Button btnManageCreatures;
        private System.Windows.Forms.Button btnManageArtifacts;
        private System.Windows.Forms.Button btnPrjStatus;
        private System.Windows.Forms.Button btnExit;
    }
}