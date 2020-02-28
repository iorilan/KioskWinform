namespace WinformNaviDemo
{
    partial class Page1
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
            this.lblPage1 = new System.Windows.Forms.Label();
            this.page1Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPage1
            // 
            this.lblPage1.AutoSize = true;
            this.lblPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage1.Location = new System.Drawing.Point(333, 178);
            this.lblPage1.Name = "lblPage1";
            this.lblPage1.Size = new System.Drawing.Size(127, 42);
            this.lblPage1.TabIndex = 0;
            this.lblPage1.Text = "Page1";
            // 
            // page1Next
            // 
            this.page1Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page1Next.Location = new System.Drawing.Point(597, 369);
            this.page1Next.Name = "page1Next";
            this.page1Next.Size = new System.Drawing.Size(105, 35);
            this.page1Next.TabIndex = 2;
            this.page1Next.Text = "Next";
            this.page1Next.UseVisualStyleBackColor = true;
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.page1Next);
            this.Controls.Add(this.lblPage1);
            this.Name = "Page1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPage1;
        private System.Windows.Forms.Button page1Next;
    }
}

