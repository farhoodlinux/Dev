namespace AuTrade
{
    partial class Home
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
            this.lstBxError = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnScannerForm = new System.Windows.Forms.Button();
            this.btnAppForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxError
            // 
            this.lstBxError.FormattingEnabled = true;
            this.lstBxError.Location = new System.Drawing.Point(12, 13);
            this.lstBxError.Name = "lstBxError";
            this.lstBxError.Size = new System.Drawing.Size(498, 160);
            this.lstBxError.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(516, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(651, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnScannerForm
            // 
            this.btnScannerForm.Location = new System.Drawing.Point(516, 42);
            this.btnScannerForm.Name = "btnScannerForm";
            this.btnScannerForm.Size = new System.Drawing.Size(112, 23);
            this.btnScannerForm.TabIndex = 3;
            this.btnScannerForm.Text = "Scanner Form";
            this.btnScannerForm.UseVisualStyleBackColor = true;
            // 
            // btnAppForm
            // 
            this.btnAppForm.Location = new System.Drawing.Point(516, 71);
            this.btnAppForm.Name = "btnAppForm";
            this.btnAppForm.Size = new System.Drawing.Size(112, 23);
            this.btnAppForm.TabIndex = 4;
            this.btnAppForm.Text = "App Setting Form";
            this.btnAppForm.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 262);
            this.Controls.Add(this.btnAppForm);
            this.Controls.Add(this.btnScannerForm);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstBxError);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxError;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnScannerForm;
        private System.Windows.Forms.Button btnAppForm;
    }
}