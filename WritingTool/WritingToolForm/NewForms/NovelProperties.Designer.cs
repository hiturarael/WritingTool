namespace Novelis.NewForms
{
    partial class ProjectForm
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
            this.txtNvlTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveNvlProp = new System.Windows.Forms.Button();
            this.btnCancelNvlProp = new System.Windows.Forms.Button();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNvlAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSynopsis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtNvlTitle
            // 
            this.txtNvlTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNvlTitle.Location = new System.Drawing.Point(190, 43);
            this.txtNvlTitle.Name = "txtNvlTitle";
            this.txtNvlTitle.Size = new System.Drawing.Size(402, 27);
            this.txtNvlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Genre";
            // 
            // btnSaveNvlProp
            // 
            this.btnSaveNvlProp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNvlProp.Location = new System.Drawing.Point(192, 455);
            this.btnSaveNvlProp.Name = "btnSaveNvlProp";
            this.btnSaveNvlProp.Size = new System.Drawing.Size(75, 28);
            this.btnSaveNvlProp.TabIndex = 4;
            this.btnSaveNvlProp.Text = "Save";
            this.btnSaveNvlProp.UseVisualStyleBackColor = true;
            this.btnSaveNvlProp.Click += new System.EventHandler(this.BtnSaveNvlProp_Click);
            // 
            // btnCancelNvlProp
            // 
            this.btnCancelNvlProp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNvlProp.Location = new System.Drawing.Point(516, 455);
            this.btnCancelNvlProp.Name = "btnCancelNvlProp";
            this.btnCancelNvlProp.Size = new System.Drawing.Size(75, 28);
            this.btnCancelNvlProp.TabIndex = 5;
            this.btnCancelNvlProp.Text = "Cancel";
            this.btnCancelNvlProp.UseVisualStyleBackColor = true;
            this.btnCancelNvlProp.Click += new System.EventHandler(this.BtnCancelNvlProp_Click);
            // 
            // lbGenres
            // 
            this.lbGenres.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.ItemHeight = 19;
            this.lbGenres.Items.AddRange(new object[] {
            "Fiction",
            "Non Fiction",
            "Science Fiction",
            "Satire",
            "Drama",
            "Action and Adventure",
            "Romance",
            "Mystery",
            "Horror",
            "Self Help",
            "Health",
            "Guide",
            "Travel",
            "Children\'s",
            "Religion, Spirituality, & New Age",
            "Science",
            "History",
            "Math",
            "Anthology",
            "Poetry",
            "Encyclopedia",
            "Dictionary",
            "Comic",
            "Art",
            "Cookbook",
            "Diary",
            "Journal",
            "Prayer Book",
            "Series",
            "Trilogy",
            "Biography",
            "Autobiography",
            "Fantasy"});
            this.lbGenres.Location = new System.Drawing.Point(190, 146);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbGenres.Size = new System.Drawing.Size(402, 61);
            this.lbGenres.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author";
            // 
            // txtNvlAuthor
            // 
            this.txtNvlAuthor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNvlAuthor.Location = new System.Drawing.Point(190, 91);
            this.txtNvlAuthor.Name = "txtNvlAuthor";
            this.txtNvlAuthor.Size = new System.Drawing.Size(402, 27);
            this.txtNvlAuthor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Synopsis";
            // 
            // txtBoxSynopsis
            // 
            this.txtBoxSynopsis.CausesValidation = false;
            this.txtBoxSynopsis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSynopsis.Location = new System.Drawing.Point(192, 235);
            this.txtBoxSynopsis.Name = "txtBoxSynopsis";
            this.txtBoxSynopsis.Size = new System.Drawing.Size(399, 191);
            this.txtBoxSynopsis.TabIndex = 3;
            this.txtBoxSynopsis.Text = "";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 517);
            this.Controls.Add(this.txtBoxSynopsis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNvlAuthor);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.btnCancelNvlProp);
            this.Controls.Add(this.btnSaveNvlProp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNvlTitle);
            this.Name = "ProjectForm";
            this.Text = "Create New Novel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNvlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveNvlProp;
        private System.Windows.Forms.Button btnCancelNvlProp;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNvlAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtBoxSynopsis;
    }
}