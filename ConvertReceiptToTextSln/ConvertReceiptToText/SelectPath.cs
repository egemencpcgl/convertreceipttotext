using ConvertReceiptToText.ReceiptOperation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertReceiptToText
{
    public partial class SelectPath : Form
    {
        OpenFileDialog file;

        public SelectPath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                ReceiptManager.Receiptmanager.path = file.FileName;
                Form1 form = new Form1();
                form.Show();
            }
        }
    }
}
