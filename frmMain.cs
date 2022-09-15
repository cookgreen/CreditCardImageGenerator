namespace CreditCardImageGenerator
{
    public partial class frmMain : Form
    {
        private List<CreditCardScenario> cards;
        private CreditCardScenarioReader cardsReader;

        public frmMain()
        {
            InitializeComponent();

            cardsReader = new CreditCardScenarioReader();
            cards = cardsReader.Read("CreditCardScenario.ini");

            cmbCardScenarioSelect.DisplayMember = "Name";
            foreach (var card in cards)
            {
                cmbCardScenarioSelect.Items.Add(card);
            }
            if (cmbCardScenarioSelect.Items.Count > 0)
            {
                cmbCardScenarioSelect.SelectedIndex = 0;
            }
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
            CreditCardScenario? card = cmbCardScenarioSelect.SelectedItem as CreditCardScenario;
            if(card == null)
            {
                MessageBox.Show("Please select a valid card!");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image File|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fullPath = dialog.FileName;
                CreditCardImage visaCardImage = new CreditCardImage(
                    txtCardNumber.Text, txtCardName.Text, txtCardValidDate.Text,
                    Path.Combine(Environment.CurrentDirectory, "Images/CardVisaImage.png"),
                    GetFontByFile(Path.Combine(Environment.CurrentDirectory, "CreditCardFont.ttf"), 16),
                    GetFontByFile(Path.Combine(Environment.CurrentDirectory, "CreditCardFont.ttf"), 12),
                    card,
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

        private void btnViewScenarioImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreditCardScenario? card = cmbCardScenarioSelect.SelectedItem as CreditCardScenario;
            if (card != null)
            {
                string cardImageFullPath = Path.Combine(Environment.CurrentDirectory, "Images", card.Image);
                frmCardViewer cardViewer = new frmCardViewer(cardImageFullPath);
                cardViewer.ShowDialog();
            }
        }
    }
}