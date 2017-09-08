using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class QuestionsFileLoader
    {
        List<string> QuestionsList = new List<string>();

        public QuestionsFileLoader(string FileName)
        {
            string line;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(FileName);
                while ((line = file.ReadLine()) != null)
                {
                    QuestionsList.Add(line);
                }

                file.Close();
            }
            catch
            {
                System.Console.WriteLine("Error during load file!!!");
            }
        }

        public List<string> GetQuestionsList()
        {
            return QuestionsList;
        }
    }
}
