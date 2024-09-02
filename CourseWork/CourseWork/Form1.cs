using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;



namespace CourseWork
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(int hWnd, string text, string caption, uint type);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.info();
        }

        private void printAnalysis()
        {
            listView2.Items.Clear();
            int listIndex = 1;
            foreach (var analys in EmploymentAnalysis.analysis)
            {

                string[] item = { listIndex.ToString(), analys.Value.Speciality, analys.Value.Counter.ToString(),
                    analys.Value.AverageSalary.ToString() };
                ListViewItem lvi = new ListViewItem(item);
                lvi.ImageIndex = 0;
                listView2.Items.Add(lvi);
                listIndex++;
            }
        }

        private void printList()
        {
            recordsCount.Text = EmploymentCenter.count.ToString();
            listView1.Items.Clear();
            int listIndex = 1;
            foreach (EmploymentCenter human in EmploymentCenter.employment)
            {
                string w = "";
                if (human.Wish)
                {
                    w = "Да";
                }
                else
                {
                    w = "Нет";
                }

                string[] item = { listIndex.ToString(), human.Name, human.Experience.ToString(), human.Qualification,
                w, human.Adress, human.Salary.ToString() };
                ListViewItem lvi = new ListViewItem(item);
                lvi.ImageIndex = 0;
                listView1.Items.Add(lvi);
                listIndex++;
            }
        }


        private void addHuman_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(fio.Text) || String.IsNullOrWhiteSpace(exp.Text) ||
                    String.IsNullOrWhiteSpace(qual.Text) || String.IsNullOrWhiteSpace(adr.Text) ||
                    String.IsNullOrWhiteSpace(sal.Text))
                {
                    throw new EmploymentCenterException("Заполните пустые поля");
                }
                else
                {
                    int salary = Convert.ToInt32(sal.Text);
                    int experience = Convert.ToInt32(exp.Text);
                    bool w = true;
                    if (yes.Checked)
                    {
                        w = true;
                    }
                    if (no.Checked)
                    {
                        w = false;
                    }
                    if (!(no.Checked) && !(yes.Checked))
                    {
                        throw new EmploymentCenterException("Заполните пустые поля");
                    }
                    EmploymentCenter newHuman = new EmploymentCenter(fio.Text, experience, qual.Text, w, adr.Text, salary);
                    bool f = false;
                    foreach(EmploymentCenter human in EmploymentCenter.employment)
                    {
                        if (human.Name.Equals(newHuman.Name) && human.Qualification.Equals(newHuman.Qualification))
                        {
                            f = true;
                            
                        }
                    }
                    if (f)
                    {
                        throw new EmploymentCenterException("Запись с такими ФИО и специальностью уже существует");
                    }
                    else
                    {
                        EmploymentCenter.addRecord(newHuman);
                        EmploymentAnalysis.addAnalysis(newHuman.Qualification, newHuman.Salary);
                        MessageBox(0, "Информация успешно добавлена", "Успешно!", 0);
                        printList();
                        printAnalysis();
                    }
                    
                }
            }
            catch (EmploymentCenterException ex)
            {
                MessageBox(0, ex.Message, "Ошибка!", 0);
            }

        }

        private void fio_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(fio, "Фамилия И. О.");
        }

        private void exp_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(exp, "Количество лет");
        }

        private void adr_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(exp, "Введите район, в котором проживаемт безработный");
        }

        private void sal_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(exp, "Желаемый размер заработной платы, руб.");
        }

        private void editNumber_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(exp, "Введите номер редактируемой записи");
        }

        private void newValue_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(exp, "Введите новое значение");
        }

        private void deleteNumber_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(exp, "Введите номер удаляемой записи");
        }

        private void filterExp_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(exp, "Стаж, количество лет");
        }

        private void filterQual_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(exp, "Профессия безработного");
        }

        private void searchFio_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(exp, "Введите фамилию для поиска");
        }

        private void editRecord_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrWhiteSpace(editNumber.Text))
                {
                    throw new EmploymentCenterException("Введите номер записи");
                }
                if (String.IsNullOrWhiteSpace(newValue.Text))
                {
                    throw new EmploymentCenterException("Введите новое значение");
                }
                int index = -1;
                try
                {
                    index = Convert.ToInt32(editNumber.Text);
                }
                catch
                {
                    throw new EmploymentCenterException("Неверный формат ввода номера записи");
                }
                if (index < 1 || index > EmploymentCenter.employment.Count)
                {
                    throw new EmploymentCenterException("Номер записи должен находиться в допустимом диапазоне");
                }
                else
                {
                    string field = chooseEdit.Text;
                    string value = newValue.Text;
                    EmploymentCenter.employment[index - 1].changeValue(field, value);
                }

                this.printList();
                printAnalysis();
                MessageBox(0, "Информация успешно изменена", "Успешно!", 0);
            }
            catch (EmploymentCenterException ex)
            {
                MessageBox(0, ex.Message, "Ошибка!", 0);
            }
        }

        private void deleteField_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(deleteNumber.Text))
                {
                    throw new EmploymentCenterException("Введите номер записи");
                }
                int index = -1;
                try
                {
                    index = Convert.ToInt32(deleteNumber.Text);
                }
                catch
                {
                    throw new EmploymentCenterException("Неверный формат ввода номера записи");
                }
                if (index < 1 || index > EmploymentCenter.employment.Count)
                {
                    throw new EmploymentCenterException("Номер записи должен находиться в допустимом диапазоне");
                }
                else
                {
                    EmploymentAnalysis.deleteRecord(EmploymentCenter.employment[index - 1].Qualification, 
                        EmploymentCenter.employment[index - 1].Salary);
                    EmploymentCenter.deleteRecord(index - 1);
                    
                    this.printList();
                    this.printAnalysis();
                    MessageBox(0, "Информация успешно удалена", "Успешно!", 0);
                }

            }
            catch (EmploymentCenterException ex)
            {
                MessageBox(0, ex.Message, "Ошибка!", 0);
            }
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            EmploymentAnalysis.deleteAll();
            EmploymentCenter.deleteAll();
            MessageBox(0, "Все данные успешно удалены", "Успешно!", 0);
            this.printList();
        }

        private void saveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("employmentCenter.txt");
                foreach (EmploymentCenter human in EmploymentCenter.employment)
                {
                    sw.WriteLine(human.ToString());
                }
                sw.Close();
                MessageBox(0, "Данные успешно сохранены", "Успешно!", 0);
            }
            catch (Exception ex)
            {
                MessageBox(0, "Не удалось сохранить файл", "Ошибка!", 0);
            }

        }

        private void readFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                EmploymentCenter.deleteAll();
                StreamReader reader = new StreamReader("employmentCenter.txt");

                string st = "";
                while (!reader.EndOfStream)
                {
                    string[] info = reader.ReadLine().Split(';');
                    List<string> infoValues = new List<string>();
                    foreach (string value in info)
                    {
                        infoValues.Add(value.Split(':')[1]);
                        st += value.Split(':')[1];
                    }
                    EmploymentCenter human = new EmploymentCenter(infoValues[0], Convert.ToInt32(infoValues[1]), infoValues[2],
                        Convert.ToBoolean(infoValues[3]), infoValues[4], Convert.ToInt32(infoValues[5]));
                    EmploymentCenter.addRecord(human);
                }
                reader.Close();
                this.printList();
                MessageBox(0, "Чтение данных прошло успешно", "Успешно!", 0);
            }
            catch
            {
                MessageBox(0, "Не удалось прочитать файл", "Ошибка!", 0);
            }

        }



        private void filterRecords_Click(object sender, EventArgs e)
        {
            if (EmploymentCenter.employment.Count != 0)
            {
                try
                {
                    if (String.IsNullOrWhiteSpace(filterQual.Text) && String.IsNullOrWhiteSpace(filterExp.Text))
                    {
                        throw new EmploymentCenterException("Заполните хотя бы один критерий для фильтрации");
                    }
                    if (String.IsNullOrWhiteSpace(filterExp.Text))
                    {
                        filterExp.Text = "-1";
                    }
                    string qual = filterQual.Text;
                    int exp = Convert.ToInt32(filterExp.Text);
                    if (exp < -1 || exp > 50)
                    {
                        throw new EmploymentCenterException("Стаж должен находиться в диапазоне от 1 до 50");
                    }
                    List<EmploymentCenter> filteredItems = EmploymentCenter.filter(exp, qual);
                    listView1.Items.Clear();

                    if (filteredItems.Count != 0)
                    {
                        int listIndex = 1;
                        foreach (EmploymentCenter human in filteredItems)
                        {
                            string w = "";
                            if (human.Wish)
                            {
                                w = "Да";
                            }
                            else
                            {
                                w = "Нет";
                            }
                            string[] item = {listIndex.ToString(), human.Name, human.Experience.ToString(),
                            human.Qualification, w,
                            human.Adress, human.Salary.ToString()};
                            ListViewItem lvi = new ListViewItem(item);
                            lvi.ImageIndex = 0;
                            listView1.Items.Add(lvi);
                            listIndex++;
                        }
                    }
                    else
                    {
                        MessageBox(0, "По данному запросу безработные не найдены", "", 0);
                    }
                }
                catch (EmploymentCenterException ex)
                {
                    MessageBox(0, ex.Message, "Ошибка!", 0);
                }
                
            }
            else
            {
                MessageBox(0, "Сначала заполните базу данных", "Ошибка!", 0);
            }


        }
        private void resetAll_Click(object sender, EventArgs e)
        {
            this.printList();
        }

        private void aboutApp_Click(object sender, EventArgs e)
        {
            this.info();
        }

        private void info()
        {
            string message = "Название БД: Центр занятости\nАвтор работы: Мартьянова Анастасия\n" +
                "Группа: 20ВП1\nКраткое описание:\nБаза данных содержит информацию о " +
                "центре занятости. " +
                "\nВы можете добавлять информацию о безработных, " +
                "производить ее " +
                "изменение, удаление, фильтрацию, сортировку и поиск по заданному критерию.";
            MessageBox(0, message, "Информация о БД", 0);

        }

        private void sortItems_Click(object sender, EventArgs e)
        {
            if (EmploymentCenter.employment.Count != 0)
            {
                listView1.Items.Clear();
                string fieldName = chooseSort.Text;
                try
                {
                    List<EmploymentCenter> sortedItems = EmploymentCenter.sort(fieldName);
                    int listIndex = 1;
                    foreach (EmploymentCenter human in sortedItems)
                    {
                        string w = "";
                        if (human.Wish)
                        {
                            w = "Да";
                        }
                        else
                        {
                            w = "Нет";
                        }
                        string[] item = {listIndex.ToString(), human.Name, human.Experience.ToString(),
                            human.Qualification, w,
                            human.Adress, human.Salary.ToString()};
                        ListViewItem lvi = new ListViewItem(item);
                        lvi.ImageIndex = 0;
                        listView1.Items.Add(lvi);
                        listIndex++;
                    }
                }
                catch(EmploymentCenterException ex)
                {
                    MessageBox(0, ex.Message, "Ошибка!", 0);
                }

            }
            else
            {
                MessageBox(0, "Сначала заполните базу данных", "Ошибка!", 0);
            }
        }

        private void findItems_Click(object sender, EventArgs e)
        {
            if (EmploymentCenter.employment.Count != 0)
            {
                try
                {
                    if (searchFio.Text == "")
                    {
                        throw new EmploymentCenterException("Заполните пустые поля");
                    }

                    string name = searchFio.Text;
                    List<EmploymentCenter> humans = EmploymentCenter.find(name);

                    listView1.Items.Clear();

                    if (humans.Count != 0)
                    {
                        int listIndex = 1;
                        foreach (EmploymentCenter human in humans)
                        {
                            string w = "";
                            if (human.Wish)
                            {
                                w = "Да";
                            }
                            else
                            {
                                w = "Нет";
                            }
                            string[] item = {listIndex.ToString(), human.Name, human.Experience.ToString(),
                            human.Qualification, w,
                            human.Adress, human.Salary.ToString()};
                            ListViewItem lvi = new ListViewItem(item);
                            lvi.ImageIndex = 0;
                            listView1.Items.Add(lvi);
                            listIndex++;
                        }
                    }
                    else
                    {
                        MessageBox(0, "По данному запросу безработные не найдены", "", 0);
                    }
                }
                catch (EmploymentCenterException ex)
                {
                    MessageBox(0, ex.Message, "Ошибка!", 0);
                }
            }
            else
            {
                MessageBox(0, "Сначала заполните базу данных", "Ошибка!", 0);
            }


        }

        private void filterProfessions_Click(object sender, EventArgs e)
        {
            if (EmploymentAnalysis.analysis.Count == 0)
            {
                MessageBox(0, "Сначала заполните базу данных", "Ошибка!", 0);
            }
            else
            {
                try
                {
                    if (String.IsNullOrWhiteSpace(profession.Text))
                    {
                        throw new EmploymentCenterException("Заполните критерий для фильтрации");
                    }
                    string qual = profession.Text;
                    Dictionary<string, EmploymentAnalysis> filteredItems = EmploymentAnalysis.filterAnalysis(qual);
                    listView2.Items.Clear();

                    if (filteredItems.Count != 0)
                    {
                        int listIndex = 1;
                        foreach (var an in filteredItems)
                        {
                            string[] item = { listIndex.ToString(), an.Value.Speciality, an.Value.Counter.ToString(), an.Value.AverageSalary.ToString() };
                            ListViewItem lvi = new ListViewItem(item);
                            lvi.ImageIndex = 0;
                            listView2.Items.Add(lvi);
                            listIndex++;
                        }
                    }
                    else
                    {
                        MessageBox(0, "По данному запросу профессии не найдены", "", 0);
                    }
                }
                catch (EmploymentCenterException ex)
                {
                    MessageBox(0, ex.Message, "Ошибка!", 0);
                }
            }

        }

        private void resetProfessions_Click(object sender, EventArgs e)
        {
            printAnalysis();
        }

        private void sortProfessions_Click(object sender, EventArgs e)
        {
            if (EmploymentAnalysis.analysis.Count != 0)
            {
                listView2.Items.Clear();
                string fieldName = chooseForProfession.Text;
                try
                {
                    List<EmploymentAnalysis> sortedItems = EmploymentAnalysis.sortAnalysis(fieldName);
                    int listIndex = 1;
                    foreach (var an in sortedItems)
                    {
                        string[] item = { listIndex.ToString(), an.Speciality, an.Counter.ToString(), an.AverageSalary.ToString() };
                        ListViewItem lvi = new ListViewItem(item);
                        lvi.ImageIndex = 0;
                        listView2.Items.Add(lvi);
                        listIndex++;
                    }
                }
                catch (EmploymentCenterException ex)
                {
                    MessageBox(0, ex.Message, "Ошибка!", 0);
                }

            }
            else
            {
                MessageBox(0, "Сначала заполните базу данных", "Ошибка!", 0);
            }
        }
    }
}