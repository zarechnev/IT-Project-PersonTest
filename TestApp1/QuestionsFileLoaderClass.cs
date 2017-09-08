using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    /// <summary>
    ///  Класс QuestionsFileLoaderClass подгружает файл с вопросами.
    /// </summary>
    class QuestionsFileLoaderClass
    {
        List<string> QuestionsList = new List<string>();

        /// <summary>
        /// Конструктор класса QuestionsFileLoaderClass.
        /// </summary>
        /// <param name="FileName">Аргумент конструктора - string путь к файлу вопросов.</param>
        public QuestionsFileLoaderClass(string FileName)
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
