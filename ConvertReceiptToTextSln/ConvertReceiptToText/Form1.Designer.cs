﻿namespace ConvertReceiptToText
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblReceipt = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblReceipt
            // 
            this.tblReceipt.AutoScroll = true;
            this.tblReceipt.AutoSize = true;
            this.tblReceipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblReceipt.ColumnCount = 2;
            this.tblReceipt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblReceipt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblReceipt.Controls.Add(this.label2, 1, 0);
            this.tblReceipt.Controls.Add(this.label1, 0, 0);
            this.tblReceipt.Location = new System.Drawing.Point(-1, 2);
            this.tblReceipt.Name = "tblReceipt";
            this.tblReceipt.RowCount = 2;
            this.tblReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblReceipt.Size = new System.Drawing.Size(160, 40);
            this.tblReceipt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "line";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 881);
            this.Controls.Add(this.tblReceipt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tblReceipt.ResumeLayout(false);
            this.tblReceipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
