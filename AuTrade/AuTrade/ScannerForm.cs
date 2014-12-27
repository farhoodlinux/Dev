using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AuTrade.Repository;

namespace AuTrade
{
    public partial class ScannerForm : Form
    {
        public ScannerForm()
        {
            InitializeComponent();
        }

        private void ScannerForm_Load(object sender, EventArgs e)
        {
            grdScanner.DataSource=ScannerRepository.GetAllRecord();
        }
    }
}
