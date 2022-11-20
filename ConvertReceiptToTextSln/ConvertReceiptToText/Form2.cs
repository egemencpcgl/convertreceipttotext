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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetReceiptView();
        }

        public void SetReceiptView()
        {
            ReceiptManager.Receiptmanager.ReadReceiptFile();
            string[] recText = ReceiptManager.Receiptmanager.ReceiptInformation[0].description.Split("\n");
            textBox1.Text = recText[0];
            textBox2.Text = recText[1];
            textBox3.Text = recText[2];
            textBox4.Text = recText[3];
            textBox5.Text = recText[4] + "  " + recText[5];
            textBox6.Text = recText[6];
            textBox7.Text = recText[7];
            textBox8.Text = recText[8];
            textBox9.Text = recText[9];
            textBox10.Text = recText[10];
            textBox11.Text = recText[11] + "  " + recText[15] + "  " + recText[16];
            textBox12.Text = recText[12];
            textBox13.Text = recText[13];
            textBox14.Text = recText[14] + "  " + recText[16] + "  " + recText[17];
            textBox15.Text = recText[18];
            textBox16.Text = recText[19];
            textBox17.Text = recText[20] + "  " + recText[21] + "  " + recText[22];
            textBox18.Text = recText[23];
            textBox19.Text = recText[24] + "  " + recText[25] + "  " + recText[26];
            textBox20.Text = recText[27] + "  " + recText[29];
            textBox21.Text = recText[28] + "  " + recText[30];
            textBox22.Text = recText[31] + "  " + recText[32];
            textBox23.Text = recText[33] + "  " + recText[36] + "  " + recText[39];
            textBox24.Text = recText[34] + "  " + recText[37] + "  " + recText[40];
            textBox25.Text = recText[35] + "  " + recText[38] + "  " + recText[41];
            textBox26.Text = recText[42];
            textBox27.Text = recText[43];
            textBox28.Text = recText[44] + "  " + recText[45];
            textBox29.Text = recText[46];
            textBox30.Text = recText[47] + "  " + recText[48];
            textBox31.Text = recText[49];
        }

    }
}
