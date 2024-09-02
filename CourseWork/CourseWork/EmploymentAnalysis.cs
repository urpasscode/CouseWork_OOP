using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class EmploymentAnalysis
    {
        public static Dictionary<string, EmploymentAnalysis> analysis = new Dictionary<string, EmploymentAnalysis>();
        string speciality;
        public string Speciality { get; set; }
        int counter;
        public int Counter { get; set; }
        int summSallary;
        public int SummSalary { get; set; }

        double averageSalary;
        public double AverageSalary { get; set; }

        public EmploymentAnalysis(string speciality, int salary)
        {
            Speciality = speciality;
            SummSalary = salary;
            Counter = 1;
        }

        public static void addAnalysis(string special, int sal)
        {
            EmploymentAnalysis newAnalysis = new EmploymentAnalysis(special, sal);
            if (!analysis.ContainsKey(newAnalysis.Speciality))
            {
                double aS = (newAnalysis.SummSalary / newAnalysis.Counter);
                newAnalysis.AverageSalary = Math.Floor(aS);
                analysis.Add(newAnalysis.Speciality, newAnalysis);
            }
            else
            {
                EmploymentAnalysis currentAnalysis = analysis[newAnalysis.Speciality];
                currentAnalysis.SummSalary += newAnalysis.SummSalary;
                currentAnalysis.Counter++;
                double aS = currentAnalysis.SummSalary / currentAnalysis.Counter;
                currentAnalysis.AverageSalary = Math.Floor(aS);
            }
        }

        public static void changeAnalysis(int oldValue, int newValue, string prof)
        {
            analysis[prof].SummSalary -= oldValue;
            analysis[prof].SummSalary += newValue;
            double aS = analysis[prof].SummSalary / analysis[prof].Counter;
            analysis[prof].AverageSalary = Math.Floor(aS);
        }

        public static Dictionary<string,EmploymentAnalysis> filterAnalysis(string qual)
        {
            Dictionary<string, EmploymentAnalysis> filteredRecords = new Dictionary<string, EmploymentAnalysis>();

            if (!String.IsNullOrWhiteSpace(qual))
            {
                foreach (var an in analysis)
                {
                    if (an.Value.Speciality.Contains(qual))
                    {
                        filteredRecords.Add(an.Value.Speciality,an.Value);
                    }
                }
            }
            else
            {
                throw new EmploymentCenterException("Введите критерий для фильтрации");
            }
            return filteredRecords;
        } 


        public static List<EmploymentAnalysis> sortAnalysis(string field)
        {
            List<EmploymentAnalysis> sortedItems = new List<EmploymentAnalysis>();
            foreach (EmploymentAnalysis an in analysis.Values)
            {
                sortedItems.Add(an);
            }
            switch (field)
            {
                case "Специальность":
                    sortedItems.Sort(delegate (EmploymentAnalysis an1, EmploymentAnalysis an2)
                    {
                        return an1.Speciality.CompareTo(an2.Speciality);
                    });
                    break;
                case "Количество человек":
                    sortedItems.Sort(delegate (EmploymentAnalysis an1, EmploymentAnalysis an2)
                    {
                        return an2.Counter.CompareTo(an2.Counter);
                    });
                    break;
                case "Средний размер желаемой заработной платы":
                    sortedItems.Sort(delegate (EmploymentAnalysis an1, EmploymentAnalysis an2)
                    {
                        return an1.AverageSalary.CompareTo(an2.AverageSalary);
                    });
                    break;
               
                default:
                    throw new EmploymentCenterException("Выберите поля из предложенного списка");
            }
            return sortedItems;
        }

        public static void deleteAll()
        {
            analysis.Clear();
        }

        public static void deleteRecord(string index, int sal)
        {
            if (analysis[index].Counter == 1)
            {
                analysis.Remove(index);
            }
            else{
                analysis[index].Counter--;
                analysis[index].SummSalary -= sal;
                double aS = analysis[index].SummSalary / analysis[index].Counter;
                analysis[index].AverageSalary = Math.Floor(aS);
            }

        }

    }
}
