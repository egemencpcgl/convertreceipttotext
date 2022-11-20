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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetReceiptView();
        }

        public void SetReceiptView()
        {
            ReceiptManager.Receiptmanager.ReadReceiptFile();
            Label cntrIndex;
            Label cntrData;
            string[] recText = ReceiptManager.Receiptmanager.ReceiptInformation[0].description.Split("\n");
            for (int i = 0; i < recText.Length; i++)
            {
                cntrIndex = new Label();
                cntrData = new Label();
                if (recText[i] != "")
                {
                    cntrIndex.Text = (i+1).ToString();
                    cntrData.Text = recText[i];
                    cntrIndex.AutoSize= true;
                    cntrData.AutoSize= true;

                    tblReceipt.Controls.Add(cntrIndex, 0, i+1);
                    tblReceipt.Controls.Add(cntrData, 1, i+1);
                    tblReceipt.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
                    tblReceipt.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
                }
            }
        }
    }
}
