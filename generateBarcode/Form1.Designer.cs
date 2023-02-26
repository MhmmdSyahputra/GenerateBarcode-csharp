
namespace generateBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barcodeGenerate = new System.Windows.Forms.PictureBox();
            this.inputEncode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_encode = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodeGenerate
            // 
            this.barcodeGenerate.Location = new System.Drawing.Point(74, 12);
            this.barcodeGenerate.Name = "barcodeGenerate";
            this.barcodeGenerate.Size = new System.Drawing.Size(478, 205);
            this.barcodeGenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barcodeGenerate.TabIndex = 0;
            this.barcodeGenerate.TabStop = false;
            // 
            // inputEncode
            // 
            this.inputEncode.Location = new System.Drawing.Point(242, 259);
            this.inputEncode.Multiline = true;
            this.inputEncode.Name = "inputEncode";
            this.inputEncode.Size = new System.Drawing.Size(229, 35);
            this.inputEncode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encode";
            // 
            // btn_encode
            // 
            this.btn_encode.Location = new System.Drawing.Point(365, 312);
            this.btn_encode.Name = "btn_encode";
            this.btn_encode.Size = new System.Drawing.Size(106, 35);
            this.btn_encode.TabIndex = 5;
            this.btn_encode.Text = "Encode";
            this.btn_encode.UseVisualStyleBackColor = true;
            this.btn_encode.Click += new System.EventHandler(this.btn_encode_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(242, 312);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(99, 35);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(4, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 3);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barcodeGenerate);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_encode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputEncode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERATE BARCODE FORMATCODE 39 | PT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcodeGenerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox barcodeGenerate;
        private System.Windows.Forms.TextBox inputEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_encode;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel1;
    }
}

