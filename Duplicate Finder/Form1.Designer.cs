namespace Duplicate_Finder
{
    partial class Form1
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
            this.btncheck = new System.Windows.Forms.Button();
            this.lstfiles = new System.Windows.Forms.ListBox();
            this.lstdup = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btncheck
            // 
            this.btncheck.ForeColor = System.Drawing.Color.OrangeRed;
            this.btncheck.Location = new System.Drawing.Point(9, 226);
            this.btncheck.Margin = new System.Windows.Forms.Padding(4);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(172, 28);
            this.btncheck.TabIndex = 0;
            this.btncheck.Text = "Find Duplicate";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstfiles
            // 
            this.lstfiles.FormattingEnabled = true;
            this.lstfiles.ItemHeight = 16;
            this.lstfiles.Location = new System.Drawing.Point(9, 10);
            this.lstfiles.Margin = new System.Windows.Forms.Padding(4);
            this.lstfiles.Name = "lstfiles";
            this.lstfiles.Size = new System.Drawing.Size(456, 100);
            this.lstfiles.TabIndex = 1;
            this.lstfiles.DoubleClick += new System.EventHandler(this.lstfiles_DoubleClick);
            // 
            // lstdup
            // 
            this.lstdup.FormattingEnabled = true;
            this.lstdup.ItemHeight = 16;
            this.lstdup.Location = new System.Drawing.Point(9, 118);
            this.lstdup.Margin = new System.Windows.Forms.Padding(4);
            this.lstdup.Name = "lstdup";
            this.lstdup.Size = new System.Drawing.Size(456, 100);
            this.lstdup.TabIndex = 2;
            this.lstdup.DoubleClick += new System.EventHandler(this.lstdup_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 266);
            this.Controls.Add(this.lstdup);
            this.Controls.Add(this.lstfiles);
            this.Controls.Add(this.btncheck);
            this.Font = new System.Drawing.Font("Neon 80s", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Duplicate_Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.ListBox lstfiles;
        private System.Windows.Forms.ListBox lstdup;
    }
}

