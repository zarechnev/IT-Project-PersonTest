using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp1
{

    public partial class Form1 : Form
    {
        static string QuestionsFile = "data/questions.txt";
        static string PsychoTypesFile = "data/psycho_types.txt";

        static QuestionsFileLoaderClass QuestionFile = new QuestionsFileLoaderClass(QuestionsFile);
        List<string> QuestionsList = QuestionFile.GetQuestionsList();

        static List<byte> Answer = new List<byte>();

        public Form1()
        {
            InitializeComponent();

            FormQuestion_1.Text = QuestionsList.First();
            QuestionsList.RemoveAt(0);
            FormQuestion_2.Text = QuestionsList.First();
            QuestionsList.RemoveAt(0);
        }

        private void button1Variant1_Click(object sender, EventArgs e)
        {
            Answer.Add(0);

            FormQuestion_1.Text = QuestionsList.First();
            QuestionsList.RemoveAt(0);
            FormQuestion_2.Text = QuestionsList.First();
            QuestionsList.RemoveAt(0);

            if (QuestionsList.Count() == 0) {
                System.Console.WriteLine("Last question.");
                button1Variant1.Enabled = false;
                button2Variant2.Enabled = false;
            }
        }

        private void button2Variant2_Click(object sender, EventArgs e)
        {
            Answer.Add(1);

            FormQuestion_1.Text = QuestionsList.First();
            QuestionsList.RemoveAt(0);
            FormQuestion_2.Text = QuestionsList.First();
            QuestionsList.RemoveAt(0);

            if (QuestionsList.Count() == 0)
            {
                System.Console.WriteLine("Last question.");
                button1Variant1.Enabled = false;
                button2Variant2.Enabled = false;
            }
        }
    }
}
