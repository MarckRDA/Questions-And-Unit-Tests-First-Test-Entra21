using System;
using System.Collections.Generic;
using System.Text;

namespace Test.First.Test
{
    public class QuestionsTest
    {
        public double Question1(double workHours, double minutesWorking, double workPrice)
                    => Math.Round((workHours + (minutesWorking / 60)) * workPrice, 2);


        public string Question2(string[] letters)
        {
            var returnedWord = "";
            
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == "Finalizar")
                {
                    break;
                }
                returnedWord += letters[i];
            }
            
            return returnedWord;
        }

        public string Question3((string name, string isSingle)[] entrevistados)
        {
            var singleMen = new StringBuilder();

            for (int i = 0; i < entrevistados.Length; i++)
            {
                if (entrevistados[i].isSingle == "sim")
                {
                    singleMen.Append($"{entrevistados[i].name}, ");
                }
            }

            singleMen.Remove(singleMen.Length - 2, 2);

            return singleMen.ToString();
        }

        public string Question4(int year) => (year <= 2002) ? "Você é maior de idade!" : "Você é menor de idade!";


        public List<double?> Question5(double?[] numbers)
        {
            
            var returnedValidNumbers = new List<double?>();

            foreach (var number in numbers)
            {
                if(number != null)
                {
                    returnedValidNumbers.Add(number);
                }    
            }

            return returnedValidNumbers;
        }

        public double Question6(List<double> salaries)
        {
            var answers = salaries.Count;
            var sum = 0.0;

            foreach (var salary in salaries)
            {
                if (salary < 0)
                {
                    answers--;
                    continue;
                }

                sum += salary;
            }

            return Math.Round(sum / (answers - 1), 2);
        }

        public double Question7(int[] codes)
        {
            (int id, string UF) scUF = (42, "SC");
            var UFs = new (int id, string UF)[27]
            {
                scUF,
                (11, "RO"),
                (12, "AC"),
                (13, "AM"),
                (14, "RR"),
                (15, "PA"),
                (16, "AP"),
                (17, "TO"),
                (21, "MA"),
                (22, "PI"),
                (23, "CE"),
                (24, "RN"),
                (25, "PB"),
                (26, "PE"),
                (27, "AL"),
                (28, "SE"),
                (29, "BA"),
                (31, "MG"),
                (32, "ES"),
                (33, "RJ"),
                (35, "SP"),
                (41, "PR"),
                (43, "RS"),
                (50, "MS"),
                (51, "MT"),
                (52, "GO"),
                (53, "DF")
            };

            var bornInSC = 0.0;
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i] == scUF.id)
                {
                    bornInSC++;
                }
            }

            return Math.Round((bornInSC * 100) / codes.Length, 2);
        }

        public string Question8(string[,] students)
        {
            var studentsPerClass = 5;
            var morningClass = new string[studentsPerClass];
            var afternoonClass = new string[studentsPerClass];
            var fullTimeClassStudents = new List<string>();

            for (int i = 0; i < studentsPerClass; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var currentClass = j == 0 ? morningClass : afternoonClass;
                    currentClass[i] = students[j,i];
                }
            }

            var onlyHalfPeriodStudents = true;

            foreach (var morningStudent in morningClass)
            {
                foreach (var afternoonStudent in afternoonClass)
                {
                    if (morningStudent == afternoonStudent)
                    {
                        fullTimeClassStudents.Add(morningStudent);
                        onlyHalfPeriodStudents = false;
                    }
                }
            }

            if (onlyHalfPeriodStudents)
            {
                return "todos os alunos estudam em meio período";
            }

            return String.Join(", ", fullTimeClassStudents);
        }


    }
}