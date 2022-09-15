using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardImageGenerator
{
    public class CreditCardScenario
    {
        private PointF cardNumberPosition;
        private PointF cardValidDatePosition;
        private PointF cardNamePosition;

        public string Name { get; set; } =  string.Empty;
        public string Image { get; set; } = string.Empty;
        public string CardNumberPos
        {
            set
            {
                string str = value;
                string[] tokens = str.Split(",");
                cardNumberPosition = new PointF(float.Parse(tokens[0].Trim()),float.Parse(tokens[1].Trim()));   
            } 
        }
        public string CardValidDatePos
        {
            set
            {
                string str = value;
                string[] tokens = str.Split(",");
                cardValidDatePosition = new PointF(float.Parse(tokens[0].Trim()), float.Parse(tokens[1].Trim()));
            }
        }
        public string CardNamePos
        {
            set
            {
                string str = value;
                string[] tokens = str.Split(",");
                cardNamePosition = new PointF(float.Parse(tokens[0].Trim()), float.Parse(tokens[1].Trim()));
            }
        }

        public PointF CardNumberPosition { get { return cardNumberPosition; } }
        public PointF CardValidDatePosition { get { return cardValidDatePosition; } }
        public PointF CardNamePosition { get { return cardNamePosition; } }
    }
}
