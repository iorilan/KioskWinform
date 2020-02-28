namespace WinformNaviDemo
{
    partial class Page3
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
            this.page3Next = new System.Windows.Forms.Button();
            this.page3Pre = new System.Windows.Forms.Button();
            this.lblPage3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // page3Next
            // 
            this.page3Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page3Next.Location = new System.Drawing.Point(597, 303);
            this.page3Next.Name = "page3Next";
            this.page3Next.Size = new System.Drawing.Size(105, 35);
            this.page3Next.TabIndex = 8;
            this.page3Next.Text = "Next";
            this.page3Next.UseVisualStyleBackColor = true;
            // 
            // page3Pre
            // 
            this.page3Pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page3Pre.Location = new System.Drawing.Point(98, 303);
            this.page3Pre.Name = "page3Pre";
            this.page3Pre.Size = new System.Drawing.Size(105, 35);
            this.page3Pre.TabIndex = 7;
            this.page3Pre.Text = "Previous";
            this.page3Pre.UseVisualStyleBackColor = true;
            // 
            // lblPage3
            // 
            this.lblPage3.AutoSize = true;
            this.lblPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage3.Location = new System.Drawing.Point(333, 112);
            this.lblPage3.Name = "lblPage3";
            this.lblPage3.Size = new System.Drawing.Size(127, 42);
            this.lblPage3.TabIndex = 6;
            this.lblPage3.Text = "Page3";
            // 
            // Page3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.page3Next);
            this.Controls.Add(this.page3Pre);
            this.Controls.Add(this.lblPage3);
            this.Name = "Page3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button page3Next;
        private System.Windows.Forms.Button page3Pre;
        private System.Windows.Forms.Label lblPage3;
    }
}