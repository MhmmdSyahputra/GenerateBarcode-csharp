using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace generateBarcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_encode_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_39 };
                barcodeGenerate.Image = writer.Write(inputEncode.Text);
            }
            catch
            {
                MessageBox.Show("Your Code Empty!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            inputEncode.Text = "";
            barcodeGenerate.Image = null;
        }
    }
}
