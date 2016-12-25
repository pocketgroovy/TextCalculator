using System;
using eMailSender;
using System.Text;

namespace YoshiMiyamoto
{
    public class Controller
    {
        private FileParser parser;
        private ISend mail;
        private static string filePath = @"../test.txt";
        public Controller():this(filePath)
        {
        }
        public Controller(string path)
        {
            parser = new FileParser(path);
            mail = new FullConfiguredEmail();
        }
        public string requestFileContents()
        { 
            return parser.getContents();
        }

        public double[] requestProcess()
        {
            string[] lines = parser.getLines();
            double[] results = new double[lines.Length];
            
            for (int i = 0; i < lines.Length; i++)
            {
                string[] items = lines[i].Split(';');
                try
                {
                    Calculator calculator = new Calculator(items);
                    double result = calculator.getResult();
                    results[i] = result;
                    storeData(items, result);
                }
                catch (Exception ex)
                {
                    mail.Send("info@pocketgroovy.com", ex.ToString());
                    throw new Exception(ex.ToString());
                }
            }
            return results;
        }

        private void storeData(string[] items, double result)
        {
            StringBuilder nums = new StringBuilder();
            ThermoDBDataSetTableAdapters.CalculationTableAdapter calculationTableAdapter =
                new ThermoDBDataSetTableAdapters.CalculationTableAdapter();
            for(int i = 0; i < items.Length-1; i++)
            {
                nums.Append(" "+items[i]);
            }
            calculationTableAdapter.Insert(1,nums.ToString(), items[items.Length-1], result);
        }
        
    }

}
