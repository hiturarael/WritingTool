namespace Novelis.ProjectMenu.LocationManagement
{
    partial class LocationManagement
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
            this.btnDelLoc = new System.Windows.Forms.Button();
            this.lbLoc = new System.Windows.Forms.ListBox();
            this.btnLoadLoc = new System.Windows.Forms.Button();
            this.btnAddLoc = new System.Windows.Forms.Button();
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
            // btnDelLoc
            // 
            this.btnDelLoc.Location = new System.Drawing.Point(18, 81);
            this.btnDelLoc.Name = "btnDelLoc";
            this.btnDelLoc.Size = new System.Drawing.Size(122, 23);
            this.btnDelLoc.TabIndex = 18;
            this.btnDelLoc.Text = "Delete Location";
            this.btnDelLoc.UseVisualStyleBackColor = true;
            // 
            // lbLoc
            // 
            this.lbLoc.FormattingEnabled = true;
            this.lbLoc.Location = new System.Drawing.Point(171, 23);
            this.lbLoc.Name = "lbLoc";
            this.lbLoc.Size = new System.Drawing.Size(352, 251);
            this.lbLoc.TabIndex = 17;
            // 
            // btnLoadLoc
            // 
            this.btnLoadLoc.Location = new System.Drawing.Point(18, 52);
            this.btnLoadLoc.Name = "btnLoadLoc";
            this.btnLoadLoc.Size = new System.Drawing.Size(122, 23);
            this.btnLoadLoc.TabIndex = 16;
            this.btnLoadLoc.Text = "Load Location";
            this.btnLoadLoc.UseVisualStyleBackColor = true;
            // 
            // btnAddLoc
            // 
            this.btnAddLoc.Location = new System.Drawing.Point(18, 23);
            this.btnAddLoc.Name = "btnAddLoc";
            this.btnAddLoc.Size = new System.Drawing.Size(122, 23);
            this.btnAddLoc.TabIndex = 15;
            this.btnAddLoc.Text = "Add New Location";
            this.btnAddLoc.UseVisualStyleBackColor = true;
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 296);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelLoc);
            this.Controls.Add(this.lbLoc);
            this.Controls.Add(this.btnLoadLoc);
            this.Controls.Add(this.btnAddLoc);
            this.Name = "LocationForm";
            this.Text = "LocationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelLoc;
        private System.Windows.Forms.ListBox lbLoc;
        private System.Windows.Forms.Button btnLoadLoc;
        private System.Windows.Forms.Button btnAddLoc;
    }
}