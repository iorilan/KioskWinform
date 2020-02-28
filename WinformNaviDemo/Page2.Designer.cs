namespace WinformNaviDemo
{
    partial class Page2
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
            this.page2Next = new System.Windows.Forms.Button();
            this.page2Pre = new System.Windows.Forms.Button();
            this.lblPage2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // page2Next
            // 
            this.page2Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page2Next.Location = new System.Drawing.Point(597, 303);
            this.page2Next.Name = "page2Next";
            this.page2Next.Size = new System.Drawing.Size(105, 35);
            this.page2Next.TabIndex = 5;
            this.page2Next.Text = "Next";
            this.page2Next.UseVisualStyleBackColor = true;
            // 
            // page2Pre
            // 
            this.page2Pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page2Pre.Location = new System.Drawing.Point(98, 303);
            this.page2Pre.Name = "page2Pre";
            this.page2Pre.Size = new System.Drawing.Size(105, 35);
            this.page2Pre.TabIndex = 4;
            this.page2Pre.Text = "Previous";
            this.page2Pre.UseVisualStyleBackColor = true;
            // 
            // lblPage2
            // 
            this.lblPage2.AutoSize = true;
            this.lblPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage2.Location = new System.Drawing.Point(333, 112);
            this.lblPage2.Name = "lblPage2";
            this.lblPage2.Size = new System.Drawing.Size(127, 42);
            this.lblPage2.TabIndex = 3;
            this.lblPage2.Text = "Page2";
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.page2Next);
            this.Controls.Add(this.page2Pre);
            this.Controls.Add(this.lblPage2);
            this.Name = "Page2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button page2Next;
        private System.Windows.Forms.Button page2Pre;
        private System.Windows.Forms.Label lblPage2;
    }
}