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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SetReceiptView();
        }

        public void SetReceiptView()
        {
            ReceiptManager.Receiptmanager.ReadReceiptFile();
            //string[] recText = ReceiptManager.Receiptmanager.ReceiptInformation[0].description.Split("\n");
            for (int i = 0; i < ReceiptManager.Receiptmanager.ReceiptInformation.Count; i++)
            {
                TextBox txt = new TextBox();

                txt.Location = new Point(ReceiptManager.Receiptmanager.ReceiptInformation[i].boundingPoly.vertices[0].x, 
                    ReceiptManager.Receiptmanager.ReceiptInformation[i].boundingPoly.vertices[0].y);
                txt.Text = ReceiptManager.Receiptmanager.ReceiptInformation[i].description;
                this.Controls.Add(txt);
                
            }
        }
    }
}
