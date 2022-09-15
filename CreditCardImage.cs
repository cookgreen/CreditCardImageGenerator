using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardImageGenerator
{
    public class CreditCardImage
    {
        private string cardNumber;
        private string cardName;
        private string cardValidDate;
        private Font cardNumberFont;
        private Font cardValidDateFont;
        private CreditCardScenario cardScenario;
        private string outputFilePath;
        private string creditCardImageFullPath;

        private Bitmap? creditCardImage;

        public CreditCardImage(
            string cardNumber, string cardName, string cardValidDate,
            string creditCardImageFullPath, 
            Font cardNumberFont,
            Font cardValidDateFont,
            CreditCardScenario cardScenario,
            string outputFilePath)
        {
            this.cardNumber = cardNumber; 
            this.cardName = cardName;
            this.cardValidDate = cardValidDate;
            this.creditCardImageFullPath = creditCardImageFullPath; 
            this.cardNumberFont = cardNumberFont;
            this.cardValidDateFont = cardValidDateFont;
            this.cardScenario = cardScenario;
            this.outputFilePath = outputFilePath;

            generateCardImage();
        }

        private void generateCardImage()
        {
            StringBuilder sb = new StringBuilder(cardNumber);
            for (int i = 4; i < sb.Length; i += 4 + 1)
            {
                sb.Insert(i, " ");
            }
            cardNumber = sb.ToString();

            creditCardImage = new Bitmap(creditCardImageFullPath);
            Graphics g = Graphics.FromImage(creditCardImage);
            g.DrawString(cardNumber, cardNumberFont, Brushes.White, cardScenario.CardNumberPosition);
            g.DrawString(cardValidDate, cardValidDateFont, Brushes.White, cardScenario.CardValidDatePosition);
            g.DrawString(cardName.ToUpper(), new Font("Arial", 14), Brushes.White, cardScenario.CardNamePosition);
            g.Dispose();
        }

        public void Save()
        {
            if (creditCardImage != null)
            {
                creditCardImage.Save(outputFilePath);
                creditCardImage.Dispose();
            }
        }
    }
}
