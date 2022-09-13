namespace VisaCardImageGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtCardValidDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCardValidDate.Text.Length != 5 ||
               !txtCardValidDate.Text.Contains("/"))
            {
                e.Cancel = true;
            }
            else
            { 
                string[] tokens = txtCardValidDate.Text.Split('/');
                if (tokens[0].Length != tokens[1].Length)
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtCardNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCardNumber.Text))
            {
                MessageBox.Show("Please input a valid card number!");
                return;
            }
            int _;
            if (txtCardNumber.Text.Length != 16 ||
               int.TryParse(txtCardName.Text, out _))
            {
                MessageBox.Show("Please input a valid card number!");
                return;
            }
            if (string.IsNullOrEmpty(txtCardName.Text))
            {
                MessageBox.Show("Please input a valid card name!");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image File|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fullPath = dialog.FileName;
                VisaCardImage visaCardImage = new VisaCardImage(
                    txtCardNumber.Text, txtCardName.Text, txtCardValidDate.Text,
                    Path.Combine(Environment.CurrentDirectory, "Images/CardVisaImage.png"),
                    GetFontByFile(Path.Combine(Environment.CurrentDirectory, "CreditCardFont.ttf"), 16),
                    GetFontByFile(Path.Combine(Environment.CurrentDirectory, "CreditCardFont.ttf"), 12),
                    fullPath);
                visaCardImage.Save();
                MessageBox.Show("Save Finished!");
            }
        }

        private Font GetFontByFile(string fontFilePath, int fontSize)
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(fontFilePath);
            Font font = new Font(pfc.Families[0], fontSize, FontStyle.Regular, GraphicsUnit.Point, 0);
            return font;
        }
    }
}