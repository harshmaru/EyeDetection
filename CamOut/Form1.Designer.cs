namespace CamOut
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
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.btns = new System.Windows.Forms.Button();
            this.btncap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgBox
            // 
            this.ImgBox.Location = new System.Drawing.Point(1, 0);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(483, 432);
            this.ImgBox.TabIndex = 0;
            this.ImgBox.TabStop = false;
            // 
            // btns
            // 
            this.btns.Location = new System.Drawing.Point(412, 438);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(72, 23);
            this.btns.TabIndex = 1;
            this.btns.Text = "Start";
            this.btns.UseVisualStyleBackColor = true;
            this.btns.Click += new System.EventHandler(this.btns_Click);
            // 
            // btncap
            // 
            this.btncap.Location = new System.Drawing.Point(331, 438);
            this.btncap.Name = "btncap";
            this.btncap.Size = new System.Drawing.Size(75, 23);
            this.btncap.TabIndex = 2;
            this.btncap.Text = "Capture";
            this.btncap.UseVisualStyleBackColor = true;
            this.btncap.Click += new System.EventHandler(this.btncap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.btncap);
            this.Controls.Add(this.btns);
            this.Controls.Add(this.ImgBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.Button btns;
        private System.Windows.Forms.Button btncap;
    }
}

