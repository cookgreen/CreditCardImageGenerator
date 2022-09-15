using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardImageGenerator
{
    public partial class frmCardViewer : Form
    {
        public frmCardViewer(string filePath)
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(filePath);
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            ClientSize = pictureBox1.Size;
        }
    }
}
