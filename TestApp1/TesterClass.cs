using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    /// <summary>
    ///  Класс TesterClass реализует логику подчёта.
    /// </summary>
    class TesterClass
    {
        string pTFile;
        List<byte> listOfAns;

        /// <summary>
        /// Конструктор класса TesterClass.
        /// </summary>
        /// <param name="PsychoTypesFile">string путь к файлу описаний психотипов.</param>
        /// <param name="AnswerList">List<byte> список ответов.</param>
        public TesterClass(string PsychoTypesFile, List<byte> AnswerList)
        {
            pTFile = PsychoTypesFile;
            listOfAns = AnswerList;
        }

        /// <summary>
        /// Возвращает описание психотипа.
        /// </summary>
        public string GetPsychoType()
        {
            // Экстраверт - интроверт
            string introEcstrа = "Интроверт";
            int intro = 0;
            int ecstra = 0;
            for (int i = 0; i < 12; i = i + 2)
            {
                if (listOfAns[i] == 1) ecstra++;
                else intro++;
            }
            if (ecstra > intro) introEcstrа = "Экстраверт";
            if (ecstra == intro) introEcstrа = "Амбиверт";

            // Рациональный – иррациональный
            string racionalIrracional = "Иррационал";
            int racional = 0;
            int irracional = 0;
            for (int i = 12; i < 24; i = i + 2)
            {
                if (listOfAns[i] == 1) racional++;
                else irracional++;
            }
            if (racional > irracional) racionalIrracional = "Рационал";

            // Сенсорика – интуиция
            string sensorIntuit = "Интуиция";
            int sensorika = 0;
            int intuicija = 0;
            for (int i = 24; i < 36; i = i + 2)
            {
                if (listOfAns[i] == 1) sensorika++;
                else intuicija++;
            }
            if (sensorika > intuicija) sensorIntuit = "Сенсорика";

            // Логика – этика
            string logikaEtika = "Этика";
            int logika = 0;
            int etika = 0;
            for (int i = 36; i < 48; i = i + 2)
            {
                if (listOfAns[i] == 1) logika++;
                else etika++;
            }
            if (logika > etika) logikaEtika = "Логика";

            string rezultat = "";

            if (racionalIrracional == "Рационал")
                rezultat = logikaEtika + " " + sensorIntuit + " " + introEcstrа;
            else
                rezultat = sensorIntuit + " " + logikaEtika + " " + introEcstrа;

            System.IO.StreamReader file = new System.IO.StreamReader(pTFile);
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                if (line == rezultat)
                {
                    rezultat = rezultat + "." + System.Environment.NewLine;
                    for (int i = 0; i < 5; i++)
                    {
                        rezultat = rezultat + file.ReadLine() + System.Environment.NewLine;
                    }
                }
            }
            return rezultat;
        }
    }
}