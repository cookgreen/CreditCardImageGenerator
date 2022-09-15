using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardImageGenerator
{
    public class CreditCardScenarioReader
    {
        public List<CreditCardScenario> Read(string iniFile)
        {
            List<CreditCardScenario> creditCardScenarios = new List<CreditCardScenario>();

            StreamReader reader = new StreamReader(iniFile);
            CreditCardScenario? creditCardScenario = null;
            while (reader.Peek() > -1)
            {
                string? line = reader.ReadLine();
                if(!string.IsNullOrEmpty(line))
                {
                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        creditCardScenario = new CreditCardScenario();
                        creditCardScenario.Name = line.Substring(line.IndexOf("[") + 1, line.IndexOf("]") - 1);
                    }
                    else if (creditCardScenario != null)
                    {
                        string[] tokens = line.Trim().Split("=");
                        switch (tokens[0].Trim())
                        {
                            case "Image":
                                creditCardScenario.Image = tokens[1].Trim();
                                break;
                            case "CardNumberPos":
                                creditCardScenario.CardNumberPos = tokens[1].Trim();
                                break;
                            case "CardValidDatePos":
                                creditCardScenario.CardValidDatePos = tokens[1].Trim();
                                break;
                            case "CardNamePos":
                                creditCardScenario.CardNamePos = tokens[1].Trim();

                                creditCardScenarios.Add(creditCardScenario);
                                break;
                        }
                    }
                }
            }

            return creditCardScenarios;
        }

        public void Write(string iniFile, List<CreditCardScenario> creditCardScenarios)
        {
            if(File.Exists(iniFile))
            {
                File.Delete(iniFile);
            }

            StreamWriter streamWriter = new StreamWriter(iniFile);
            foreach(var scenario in creditCardScenarios)
            {
                streamWriter.WriteLine(string.Format("[{0}]", scenario.Name));
                streamWriter.WriteLine(string.Format("Image = {0}", scenario.Image));
                streamWriter.WriteLine(string.Format("CardNumberPos = {0}", scenario.CardNumberPos));
                streamWriter.WriteLine(string.Format("CardValidDatePos = {0}", scenario.CardValidDatePos));
                streamWriter.WriteLine(string.Format("CardNamePos = {0}", scenario.CardNamePos));
                streamWriter.WriteLine(string.Format(Environment.NewLine));
            }
        }
    }
}
