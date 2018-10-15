namespace Bots
{
    partial class FormInCaptcha
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
            this.btOK = new System.Windows.Forms.Button();
            this.textCaptcha = new System.Windows.Forms.TextBox();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(137, 7);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click_1);
            // 
            // textCaptcha
            // 
            this.textCaptcha.Location = new System.Drawing.Point(7, 7);
            this.textCaptcha.Name = "textCaptcha";
            this.textCaptcha.Size = new System.Drawing.Size(124, 20);
            this.textCaptcha.TabIndex = 4;
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(7, 36);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(349, 112);
            this.pictureBoxCaptcha.TabIndex = 3;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // FormInCaptcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 155);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.textCaptcha);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Name = "FormInCaptcha";
            this.Text = "FormInCaptcha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox textCaptcha;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
    }
}