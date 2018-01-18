namespace WritingToolForm.ProjectMenu.CreatureManagement
{
    partial class CreatureManagement
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
            this.btnDelCreature = new System.Windows.Forms.Button();
            this.lbCreatures = new System.Windows.Forms.ListBox();
            this.btnLoadCreature = new System.Windows.Forms.Button();
            this.btnAddCreature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnDelCreature
            // 
            this.btnDelCreature.Location = new System.Drawing.Point(18, 81);
            this.btnDelCreature.Name = "btnDelCreature";
            this.btnDelCreature.Size = new System.Drawing.Size(122, 23);
            this.btnDelCreature.TabIndex = 18;
            this.btnDelCreature.Text = "Delete Creature";
            this.btnDelCreature.UseVisualStyleBackColor = true;
            // 
            // lbCreatures
            // 
            this.lbCreatures.FormattingEnabled = true;
            this.lbCreatures.Location = new System.Drawing.Point(171, 23);
            this.lbCreatures.Name = "lbCreatures";
            this.lbCreatures.Size = new System.Drawing.Size(352, 251);
            this.lbCreatures.TabIndex = 17;
            // 
            // btnLoadCreature
            // 
            this.btnLoadCreature.Location = new System.Drawing.Point(18, 52);
            this.btnLoadCreature.Name = "btnLoadCreature";
            this.btnLoadCreature.Size = new System.Drawing.Size(122, 23);
            this.btnLoadCreature.TabIndex = 16;
            this.btnLoadCreature.Text = "Load Creature";
            this.btnLoadCreature.UseVisualStyleBackColor = true;
            // 
            // btnAddCreature
            // 
            this.btnAddCreature.Location = new System.Drawing.Point(18, 23);
            this.btnAddCreature.Name = "btnAddCreature";
            this.btnAddCreature.Size = new System.Drawing.Size(122, 23);
            this.btnAddCreature.TabIndex = 15;
            this.btnAddCreature.Text = "Add New Creature";
            this.btnAddCreature.UseVisualStyleBackColor = true;
            // 
            // CreatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 296);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelCreature);
            this.Controls.Add(this.lbCreatures);
            this.Controls.Add(this.btnLoadCreature);
            this.Controls.Add(this.btnAddCreature);
            this.Name = "CreatureForm";
            this.Text = "CreatureForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelCreature;
        private System.Windows.Forms.ListBox lbCreatures;
        private System.Windows.Forms.Button btnLoadCreature;
        private System.Windows.Forms.Button btnAddCreature;
    }
}