namespace AuTrade
{
    partial class ScannerForm
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
            this.grdScanner = new System.Windows.Forms.DataGridView();
            this.cmbbxScanner = new System.Windows.Forms.ComboBox();
            this.lblSelectScanner = new System.Windows.Forms.Label();
            this.grpbxScanner = new System.Windows.Forms.GroupBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnDeleteScanner = new System.Windows.Forms.Button();
            this.btnAddScanner = new System.Windows.Forms.Button();
            this.chklstMarkets = new System.Windows.Forms.CheckedListBox();
            this.lblInstrument = new System.Windows.Forms.Label();
            this.cmbbxInstrument = new System.Windows.Forms.ComboBox();
            this.txtbxMarketCapBelow = new System.Windows.Forms.TextBox();
            this.lblMarketCapBelow = new System.Windows.Forms.Label();
            this.txtbxMarketCapAbove = new System.Windows.Forms.TextBox();
            this.lblMarketCapAbove = new System.Windows.Forms.Label();
            this.txtbxPriceBelow = new System.Windows.Forms.TextBox();
            this.lblPriceBelow = new System.Windows.Forms.Label();
            this.txtbxPriceAbove = new System.Windows.Forms.TextBox();
            this.lblPriceAbove = new System.Windows.Forms.Label();
            this.txtbxScannerName = new System.Windows.Forms.TextBox();
            this.lblScannerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdScanner)).BeginInit();
            this.grpbxScanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdScanner
            // 
            this.grdScanner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdScanner.Location = new System.Drawing.Point(27, 25);
            this.grdScanner.Name = "grdScanner";
            this.grdScanner.Size = new System.Drawing.Size(791, 232);
            this.grdScanner.TabIndex = 0;
            // 
            // cmbbxScanner
            // 
            this.cmbbxScanner.FormattingEnabled = true;
            this.cmbbxScanner.Location = new System.Drawing.Point(27, 303);
            this.cmbbxScanner.Name = "cmbbxScanner";
            this.cmbbxScanner.Size = new System.Drawing.Size(343, 21);
            this.cmbbxScanner.TabIndex = 1;
            // 
            // lblSelectScanner
            // 
            this.lblSelectScanner.AutoSize = true;
            this.lblSelectScanner.Location = new System.Drawing.Point(24, 278);
            this.lblSelectScanner.Name = "lblSelectScanner";
            this.lblSelectScanner.Size = new System.Drawing.Size(80, 13);
            this.lblSelectScanner.TabIndex = 2;
            this.lblSelectScanner.Text = "Select Scanner";
            // 
            // grpbxScanner
            // 
            this.grpbxScanner.Controls.Add(this.btnClearData);
            this.grpbxScanner.Controls.Add(this.btnDeleteScanner);
            this.grpbxScanner.Controls.Add(this.btnAddScanner);
            this.grpbxScanner.Controls.Add(this.chklstMarkets);
            this.grpbxScanner.Controls.Add(this.lblInstrument);
            this.grpbxScanner.Controls.Add(this.cmbbxInstrument);
            this.grpbxScanner.Controls.Add(this.txtbxMarketCapBelow);
            this.grpbxScanner.Controls.Add(this.lblMarketCapBelow);
            this.grpbxScanner.Controls.Add(this.txtbxMarketCapAbove);
            this.grpbxScanner.Controls.Add(this.lblMarketCapAbove);
            this.grpbxScanner.Controls.Add(this.txtbxPriceBelow);
            this.grpbxScanner.Controls.Add(this.lblPriceBelow);
            this.grpbxScanner.Controls.Add(this.txtbxPriceAbove);
            this.grpbxScanner.Controls.Add(this.lblPriceAbove);
            this.grpbxScanner.Controls.Add(this.txtbxScannerName);
            this.grpbxScanner.Controls.Add(this.lblScannerName);
            this.grpbxScanner.Location = new System.Drawing.Point(34, 351);
            this.grpbxScanner.Name = "grpbxScanner";
            this.grpbxScanner.Size = new System.Drawing.Size(784, 192);
            this.grpbxScanner.TabIndex = 3;
            this.grpbxScanner.TabStop = false;
            this.grpbxScanner.Text = "Update Data";
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(631, 78);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(136, 23);
            this.btnClearData.TabIndex = 15;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            // 
            // btnDeleteScanner
            // 
            this.btnDeleteScanner.Location = new System.Drawing.Point(631, 49);
            this.btnDeleteScanner.Name = "btnDeleteScanner";
            this.btnDeleteScanner.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteScanner.TabIndex = 14;
            this.btnDeleteScanner.Text = "Delete Scanner";
            this.btnDeleteScanner.UseVisualStyleBackColor = true;
            // 
            // btnAddScanner
            // 
            this.btnAddScanner.Location = new System.Drawing.Point(631, 20);
            this.btnAddScanner.Name = "btnAddScanner";
            this.btnAddScanner.Size = new System.Drawing.Size(136, 23);
            this.btnAddScanner.TabIndex = 13;
            this.btnAddScanner.Text = "Add Scanner";
            this.btnAddScanner.UseVisualStyleBackColor = true;
            // 
            // chklstMarkets
            // 
            this.chklstMarkets.FormattingEnabled = true;
            this.chklstMarkets.Location = new System.Drawing.Point(355, 20);
            this.chklstMarkets.Name = "chklstMarkets";
            this.chklstMarkets.Size = new System.Drawing.Size(120, 154);
            this.chklstMarkets.TabIndex = 12;
            // 
            // lblInstrument
            // 
            this.lblInstrument.AutoSize = true;
            this.lblInstrument.Location = new System.Drawing.Point(9, 160);
            this.lblInstrument.Name = "lblInstrument";
            this.lblInstrument.Size = new System.Drawing.Size(56, 13);
            this.lblInstrument.TabIndex = 11;
            this.lblInstrument.Text = "Instrument";
            // 
            // cmbbxInstrument
            // 
            this.cmbbxInstrument.FormattingEnabled = true;
            this.cmbbxInstrument.Location = new System.Drawing.Point(119, 152);
            this.cmbbxInstrument.Name = "cmbbxInstrument";
            this.cmbbxInstrument.Size = new System.Drawing.Size(179, 21);
            this.cmbbxInstrument.TabIndex = 10;
            // 
            // txtbxMarketCapBelow
            // 
            this.txtbxMarketCapBelow.Location = new System.Drawing.Point(119, 125);
            this.txtbxMarketCapBelow.Name = "txtbxMarketCapBelow";
            this.txtbxMarketCapBelow.Size = new System.Drawing.Size(179, 20);
            this.txtbxMarketCapBelow.TabIndex = 9;
            // 
            // lblMarketCapBelow
            // 
            this.lblMarketCapBelow.AutoSize = true;
            this.lblMarketCapBelow.Location = new System.Drawing.Point(9, 132);
            this.lblMarketCapBelow.Name = "lblMarketCapBelow";
            this.lblMarketCapBelow.Size = new System.Drawing.Size(94, 13);
            this.lblMarketCapBelow.TabIndex = 8;
            this.lblMarketCapBelow.Text = "Market Cap Below";
            // 
            // txtbxMarketCapAbove
            // 
            this.txtbxMarketCapAbove.Location = new System.Drawing.Point(119, 98);
            this.txtbxMarketCapAbove.Name = "txtbxMarketCapAbove";
            this.txtbxMarketCapAbove.Size = new System.Drawing.Size(179, 20);
            this.txtbxMarketCapAbove.TabIndex = 7;
            // 
            // lblMarketCapAbove
            // 
            this.lblMarketCapAbove.AutoSize = true;
            this.lblMarketCapAbove.Location = new System.Drawing.Point(9, 105);
            this.lblMarketCapAbove.Name = "lblMarketCapAbove";
            this.lblMarketCapAbove.Size = new System.Drawing.Size(96, 13);
            this.lblMarketCapAbove.TabIndex = 6;
            this.lblMarketCapAbove.Text = "Market Cap Above";
            // 
            // txtbxPriceBelow
            // 
            this.txtbxPriceBelow.Location = new System.Drawing.Point(119, 72);
            this.txtbxPriceBelow.Name = "txtbxPriceBelow";
            this.txtbxPriceBelow.Size = new System.Drawing.Size(179, 20);
            this.txtbxPriceBelow.TabIndex = 5;
            // 
            // lblPriceBelow
            // 
            this.lblPriceBelow.AutoSize = true;
            this.lblPriceBelow.Location = new System.Drawing.Point(9, 79);
            this.lblPriceBelow.Name = "lblPriceBelow";
            this.lblPriceBelow.Size = new System.Drawing.Size(62, 13);
            this.lblPriceBelow.TabIndex = 4;
            this.lblPriceBelow.Text = "Price below";
            // 
            // txtbxPriceAbove
            // 
            this.txtbxPriceAbove.Location = new System.Drawing.Point(119, 46);
            this.txtbxPriceAbove.Name = "txtbxPriceAbove";
            this.txtbxPriceAbove.Size = new System.Drawing.Size(179, 20);
            this.txtbxPriceAbove.TabIndex = 3;
            // 
            // lblPriceAbove
            // 
            this.lblPriceAbove.AutoSize = true;
            this.lblPriceAbove.Location = new System.Drawing.Point(6, 53);
            this.lblPriceAbove.Name = "lblPriceAbove";
            this.lblPriceAbove.Size = new System.Drawing.Size(65, 13);
            this.lblPriceAbove.TabIndex = 2;
            this.lblPriceAbove.Text = "Price Above";
            // 
            // txtbxScannerName
            // 
            this.txtbxScannerName.Location = new System.Drawing.Point(119, 20);
            this.txtbxScannerName.Name = "txtbxScannerName";
            this.txtbxScannerName.Size = new System.Drawing.Size(179, 20);
            this.txtbxScannerName.TabIndex = 1;
            // 
            // lblScannerName
            // 
            this.lblScannerName.AutoSize = true;
            this.lblScannerName.Location = new System.Drawing.Point(6, 27);
            this.lblScannerName.Name = "lblScannerName";
            this.lblScannerName.Size = new System.Drawing.Size(78, 13);
            this.lblScannerName.TabIndex = 0;
            this.lblScannerName.Text = "Scanner Name";
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 582);
            this.Controls.Add(this.grpbxScanner);
            this.Controls.Add(this.lblSelectScanner);
            this.Controls.Add(this.cmbbxScanner);
            this.Controls.Add(this.grdScanner);
            this.Name = "ScannerForm";
            this.Text = "Scanner Form";
            this.Load += new System.EventHandler(this.ScannerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdScanner)).EndInit();
            this.grpbxScanner.ResumeLayout(false);
            this.grpbxScanner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdScanner;
        private System.Windows.Forms.ComboBox cmbbxScanner;
        private System.Windows.Forms.Label lblSelectScanner;
        private System.Windows.Forms.GroupBox grpbxScanner;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnDeleteScanner;
        private System.Windows.Forms.Button btnAddScanner;
        private System.Windows.Forms.CheckedListBox chklstMarkets;
        private System.Windows.Forms.Label lblInstrument;
        private System.Windows.Forms.ComboBox cmbbxInstrument;
        private System.Windows.Forms.TextBox txtbxMarketCapBelow;
        private System.Windows.Forms.Label lblMarketCapBelow;
        private System.Windows.Forms.TextBox txtbxMarketCapAbove;
        private System.Windows.Forms.Label lblMarketCapAbove;
        private System.Windows.Forms.TextBox txtbxPriceBelow;
        private System.Windows.Forms.Label lblPriceBelow;
        private System.Windows.Forms.TextBox txtbxPriceAbove;
        private System.Windows.Forms.Label lblPriceAbove;
        private System.Windows.Forms.TextBox txtbxScannerName;
        private System.Windows.Forms.Label lblScannerName;
    }
}