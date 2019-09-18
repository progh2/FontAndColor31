using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FontAndColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TlsbtnFont_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fontDlg.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    //this.rtbText.Font = this.fontDlg.Font;
                    this.rtbText.SelectionFont = this.fontDlg.Font;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("폰트 변경을 취소했습니다", "알림");
                    break;
            }
        }

        private void TlsbtbColor_Click(object sender, EventArgs e)
        {
            DialogResult result = this.colorDlg.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    this.rtbText.SelectionColor = this.colorDlg.Color;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("색 변경을 취소했습니다", "알림");
                    break;
            }
        }
    }
}
