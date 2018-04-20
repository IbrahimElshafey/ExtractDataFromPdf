namespace TransactionsReaderPrototype
{
    partial class Form1
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
            this.SelectPdf = new System.Windows.Forms.Button();
            this.StartProcessing_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PdfFile_txt = new System.Windows.Forms.TextBox();
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openPdfDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // SelectPdf
            // 
            this.SelectPdf.Location = new System.Drawing.Point(465, 40);
            this.SelectPdf.Name = "SelectPdf";
            this.SelectPdf.Size = new System.Drawing.Size(44, 34);
            this.SelectPdf.TabIndex = 16;
            this.SelectPdf.Text = "...";
            this.SelectPdf.UseVisualStyleBackColor = true;
            // 
            // StartProcessing_btn
            // 
            this.StartProcessing_btn.Location = new System.Drawing.Point(55, 111);
            this.StartProcessing_btn.Name = "StartProcessing_btn";
            this.StartProcessing_btn.Size = new System.Drawing.Size(144, 45);
            this.StartProcessing_btn.TabIndex = 15;
            this.StartProcessing_btn.Text = "Generate CSV";
            this.StartProcessing_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "PDF File";
            // 
            // PdfFile_txt
            // 
            this.PdfFile_txt.Location = new System.Drawing.Point(131, 46);
            this.PdfFile_txt.Name = "PdfFile_txt";
            this.PdfFile_txt.Size = new System.Drawing.Size(328, 22);
            this.PdfFile_txt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 323);
            this.Controls.Add(this.SelectPdf);
            this.Controls.Add(this.StartProcessing_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PdfFile_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SelectPdf;
        private System.Windows.Forms.Button StartProcessing_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PdfFile_txt;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openPdfDialog;
    }
}

