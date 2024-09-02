using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CourseWork
{
    public partial class EmploymentCenter
    {
        public static List<EmploymentCenter> employment = new List<EmploymentCenter>();
        public static int count;

        string name;
        public string Name
        {
            get => name;
            set
            {
                string regName = @"^[а-яА-Я]+";
                if (!Regex.IsMatch(value, regName))
                {
                    throw new EmploymentCenterException("Имя должно быть написано на русском языке");
                }
                else
                {
                    name = value;
                }
            }
        }

        int experience;
        public int Experience
        {
            get => experience;
            set
            {
                int e = -1;
                try
                {
                    e = Convert.ToInt32(value);

                }
                catch (EmploymentCenterException ex)
                {
                    throw new EmploymentCenterException("Стаж должен быть целым числом");
                }
                if ((e < 50) && (e >= 0))
                {
                    experience = e;
                }
                else
                {
                    throw new EmploymentCenterException("Стаж должен быть не меньше 0 и меньше 50 лет");
                }
            }
        }

        string qualification;
        public string Qualification
        {
            get => qualification;
            set
            {
                string regName = @"^[а-яА-Я]+";
                if (!Regex.IsMatch(value, regName))
                {
                    throw new EmploymentCenterException("Профессия должна быть написана на русском языке");
                }
                else
                {
                    qualification = value;
                }
            }
        }

        bool wish;
        public bool Wish
        {
            get => wish;
            set
            {
                try
                {
                    wish = Convert.ToBoolean(value);
                }
                catch
                {
                    throw new EmploymentCenterException("Неверный формат ввода");
                }
            }
        }

        string adress;
        public string Adress
        {
            get => adress;
            set
            {
                string regName = @"^[а-яА-Я]+";
                if (!Regex.IsMatch(value, regName))
                {
                    throw new EmploymentCenterException("Адрес должен быть написан на русском языке");
                }
                else
                {
                    adress = value;
                }
            }
        }

        int salary;
        public int Salary
        {
            get => salary;
            set
            {
                int s = 0;
                try
                {
                    s = Convert.ToInt32(value);

                }
                catch (EmploymentCenterException ex)
                {
                    throw new EmploymentCenterException("Зарплата должна быть целым числом");
                }
                if (s >= 12130)
                {
                    salary = s;
                }
                else
                    throw new EmploymentCenterException("Зарплата не может быть меньше МРОТ (12130 руб.)");
            }
        }

        public EmploymentCenter(
            string name,
            int expirience,
            string qualification,
            bool wish,
            string adress,
            int salary)
        {
            Name = name;
            Experience = expirience;
            Qualification = qualification;
            Wish = wish;
            Adress = adress;
            Salary = salary;
        }


        public static void addRecord(EmploymentCenter human)
        {
            employment.Add(human);
            count++;
        }

        public static void deleteRecord(int index)
        {
            employment.RemoveAt(index);
            count--;
        }

        public static void deleteAll()
        {
            employment.Clear();
            count = 0;
        }

        public void changeValue(string field, string value)
        {
            switch (field)
            {
                case "ФИО":
                    this.Name = value;
                    break;
                case "Стаж":
                    int e;
                    try
                    {
                        e = Convert.ToInt32(value);
                    }
                    catch
                    {
                        throw new EmploymentCenterException("Стаж должен быть целым числом");
                    }
                    this.Experience = e;
                    break;
                case "Профессия":
                    this.Qualification = value;
                    break;
                case "Желание работать по специальности":
                    if ((value.Equals("yes")) || (value.Equals("Yes")) ||
                        (value.Equals("Да")) || (value.Equals("да")))
                    {
                        this.Wish = true;
                    }
                    else if ((value.Equals("no")) || (value.Equals("No")) ||
                        (value.Equals("Нет")) || (value.Equals("нет")))
                    {
                        this.Wish = false;
                    }
                    else
                    {
                        throw new EmploymentCenterException("Введите 'да'/'Да'/'yes'/'Yes'/'нет'/'Нет'/'No'/'no'");
                    }
                    break;
                case "Место расположения":
                    this.Adress = value;
                    break;
                case "Заработная плата":
                    int s;
                    try
                    {
                        s = Convert.ToInt32(value);
                    }
                    catch
                    {
                        throw new EmploymentCenterException("Зарплата должна быть целым числом");
                    }
                    EmploymentAnalysis.changeAnalysis(this.Salary, s, this.Qualification);
                    this.Salary = s;
                    break;
                default:
                    throw new EmploymentCenterException("Выберите поля из предложенного списка");


            }
        }

        public override string ToString()
        {
            string strInfo = $"ФИО:{this.Name}; Стаж:{this.Experience}; " +
                $"Профессия:{this.Qualification}; Желание работать по специальности:{this.Wish}; " +
                $"Место расположения:{this.Adress}; Желаемый размер зарплаты:{this.Salary}";
            return strInfo;

        }

        public static List<EmploymentCenter> filter(int exp, string qual)
        {
            List<EmploymentCenter> filteredRecords = new List<EmploymentCenter>();
            
                if (exp!=-1 && (!String.IsNullOrWhiteSpace(qual)))
                {
                    foreach (EmploymentCenter human in employment)
                    {
                        if (human.Experience == exp && human.Qualification.Equals(qual))
                        {
                            filteredRecords.Add(human);
                        }
                    }
                }
                else
                {
                    if (exp!=-1)
                    {
                        foreach (EmploymentCenter human in employment)
                        {
                            if (human.Experience == exp)
                            {
                                filteredRecords.Add(human);
                            }
                        }
                    }
                    else if (!String.IsNullOrWhiteSpace(qual))
                    {
                        foreach (EmploymentCenter human in employment)
                        {
                            if (human.Qualification.Equals(qual))
                            {
                                filteredRecords.Add(human);
                            }
                        }
                    }
                    else
                    {
                        throw new EmploymentCenterException("Введите хотя бы 1 критерий для фильтрации");
                    }
                }
            
            
            return filteredRecords;
        }

        public static List<EmploymentCenter> find(string name)
        {
            List<EmploymentCenter> foundItems = new List<EmploymentCenter>();
            foreach (EmploymentCenter human in employment)
            {
                if (human.Name.Contains(name))
                {
                    foundItems.Add(human);
                }
            }
            return foundItems;

        }

        public static List<EmploymentCenter> sort(string field)
        {
            List<EmploymentCenter> sortedItems = new List<EmploymentCenter>();
            foreach(EmploymentCenter human in employment)
            {
                sortedItems.Add(human);
            }
            switch (field)
            {
                case "ФИО":
                    sortedItems.Sort(delegate (EmploymentCenter human1, EmploymentCenter human2)
                    {
                        return human1.Name.CompareTo(human2.Name);
                    });
                    break;
                case "Стаж":
                    sortedItems.Sort(delegate (EmploymentCenter human1, EmploymentCenter human2)
                    {
                        return human1.Experience.CompareTo(human2.Experience);
                    });
                    break;
                case "Профессия":
                    sortedItems.Sort(delegate (EmploymentCenter human1, EmploymentCenter human2)
                    {
                        return human1.Qualification.CompareTo(human2.Qualification);
                    });
                    break;
                case "Желание работать по специальности":
                    sortedItems.Sort(delegate (EmploymentCenter human1, EmploymentCenter human2)
                    {
                        return human1.Wish.CompareTo(human2.Wish);
                    });
                    break;
                case "Место расположения":
                    sortedItems.Sort(delegate (EmploymentCenter human1, EmploymentCenter human2)
                    {
                        return human1.Adress.CompareTo(human2.Adress);
                    });
                    break;
                case "Заработная плата":
                    sortedItems.Sort(delegate (EmploymentCenter human1, EmploymentCenter human2)
                    {
                        return human1.Salary.CompareTo(human2.Salary);
                    });
                    break;
                default:
                    throw new EmploymentCenterException("Выберите поля из предложенного списка");
            }
            return sortedItems;
        }

    }
}
