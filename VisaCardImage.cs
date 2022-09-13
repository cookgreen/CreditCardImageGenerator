using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisaCardImageGenerator
{
    public class VisaCardImage
    {
        private string cardNumber;
        private string cardName;
        private string cardValidDate;
        private Font cardNumberFont;
        private Font cardValidDateFont;
        private string outputFilePath;
        private string visaCardImageFullPath;

        private Bitmap visaCardImage;

        public VisaCardImage(
            string cardNumber, string cardName, string cardValidDate,
            string visaCardImageFullPath, 
            Font cardNumberFont,
            Font cardValidDateFont,
            string outputFilePath)
        {
            this.cardNumber = cardNumber; 
            this.cardName = cardName;
            this.cardValidDate = cardValidDate;
            this.visaCardImageFullPath = visaCardImageFullPath; 
            this.cardNumberFont = cardNumberFont;
            this.cardValidDateFont = cardValidDateFont;
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

            visaCardImage = new Bitmap(visaCardImageFullPath);
            Graphics g = Graphics.FromImage(visaCardImage);
            g.DrawString(cardNumber, cardNumberFont, Brushes.White, new PointF(143, 250));
            g.DrawString(cardValidDate, cardValidDateFont, Brushes.White, new PointF(340, 318));
            g.DrawString(cardName.ToUpper(), new Font("Arial", 14), Brushes.White, new PointF(145, 350));
            g.Dispose();
        }

        public void Save()
        {
            visaCardImage.Save(outputFilePath);
            visaCardImage.Dispose();
        }
    }
}
