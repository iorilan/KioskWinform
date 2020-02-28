namespace WinformNaviDemo
{
    partial class Page4
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
            this.page4Pre = new System.Windows.Forms.Button();
            this.lblPage3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // page4Pre
            // 
            this.page4Pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page4Pre.Location = new System.Drawing.Point(98, 303);
            this.page4Pre.Name = "page4Pre";
            this.page4Pre.Size = new System.Drawing.Size(105, 35);
            this.page4Pre.TabIndex = 10;
            this.page4Pre.Text = "Previous";
            this.page4Pre.UseVisualStyleBackColor = true;
            // 
            // lblPage3
            // 
            this.lblPage3.AutoSize = true;
            this.lblPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage3.Location = new System.Drawing.Point(333, 112);
            this.lblPage3.Name = "lblPage3";
            this.lblPage3.Size = new System.Drawing.Size(127, 42);
            this.lblPage3.TabIndex = 9;
            this.lblPage3.Text = "Page4";
            // 
            // Page4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.page4Pre);
            this.Controls.Add(this.lblPage3);
            this.Name = "Page4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button page4Pre;
        private System.Windows.Forms.Label lblPage3;
    }
}