using BarcodeLib;
using QRCoder;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace QRCODE_BARCODE_GENERATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //int u = textBox1.TextLength;

           // if (u >8  )
           // {
          //      MessageBox.Show("ÜRÜN KODU 8 RAKAMDAN UZUN OLAMAZ !");
          //      textBox1.Text = "";
          //  }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Oluşturulacak Kodu Giriniz");
            }
            else
            {
                int u = textBox1.TextLength;


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(10);
                pictureBox1.Image = qrCodeImage;




            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (pictureBox1.Image != null)
                {
                    Image img = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                    Graphics g = Graphics.FromImage(img);

                    g.CopyFromScreen(PointToScreen(pictureBox1.Location), new Point(0, 0), new Size(pictureBox1.Width, pictureBox1.Height));

                    Clipboard.SetImage(img);

                    g.Dispose();


                }
                else
                {
                    MessageBox.Show("BARKOD/QRKod Oluşturmadan Kaydedilemez");
                }
            }
            catch
            {



            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = null
              ;
            pictureBox1.Image = null;
        }
    }
}