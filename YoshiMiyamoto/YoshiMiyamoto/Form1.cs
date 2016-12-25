using System;
using System.Windows.Forms;

namespace YoshiMiyamoto
{

    public partial class Form1 : Form
    {
        private Controller controller;
        public Form1()
        {
            InitializeComponent();
        }

        private void import_Click(object sender, EventArgs e)
        {
            this.fileContents.Text = controller.requestFileContents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new Controller();
        }

        private void process_Click(object sender, EventArgs e)
        {
            try
            {
                double[] results = controller.requestProcess();
                string linesWithNewLine = "";

                foreach (double answer in results)
                {
                    linesWithNewLine += answer.ToString() + "\n";
                }

                this.result.Text = linesWithNewLine + " The above has been stored";
            }
            catch(Exception ex)
            {
                this.result.Text = "Error occured: " + ex.ToString();
            }
        }
    }
}
