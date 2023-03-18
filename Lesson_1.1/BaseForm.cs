using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lesson_01
{
    public partial class Form1 : Form
    {
        private EmployeeManager _employeeManager;

        public Form1()
        {
            InitializeComponent();
            _employeeManager = EmployeeManager.Instance;
        }

        private void add_emloyee_Click(object sender, EventArgs e)
        {
            Employee emp = null;
            string selectedItem = "";
            if (comboBox1.SelectedIndex !=-1)
            {
                selectedItem = comboBox1.SelectedItem.ToString();
            }

            var fn = textBox_first_name.Text;
            var mn = textBox_middle_name.Text;
            var sn = textBox_second_name.Text;
            float salary;
            if (!float.TryParse(textBox_salary.Text, out salary)) salary = 0;

            if ((fn == "") & (mn == "") & (sn == "") & (salary == 0))
            {
                if (selectedItem != "")
                {
                    if (selectedItem == "Сотрудник")
                    {
                        emp = new Employee();
                    }
                    else
                    {
                        using (var form_change_bonus = new Change_bonus())
                        {
                            int a = 7;
                        }
                    }

                }
                
            }
            else
            {
                if (salary == 0)
                {
                    var emptyDict = new Dictionary<string, string>();
                    emptyDict.Add("first_name", fn);
                    emptyDict.Add("middle_name", mn);
                    emptyDict.Add("second_name", sn);

                    emp = new Employee(emptyDict);
                }
                else
                {
                    var emptyDict = new Dictionary<string, string>();
                    emptyDict.Add("first_name", fn);
                    emptyDict.Add("middle_name", mn);
                    emptyDict.Add("second_name", sn);

                    emp = new Employee(emptyDict, salary);
                }
            }

            _employeeManager.AddEmployee(emp);
            listBox1.Items.Add(emp.ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //int colvo = Employee.get_employee_count();
            var colvo_1 = _employeeManager.GetNumberOfEmployees();
            var colvo_2 = Employee.get_employee_count();

            var min_salary = Employee.get_min_salary();
            MessageBox.Show(
                "Количество созданных сотрудников (по массиву сотрудников): " + colvo_1.ToString() + "\n" +
                "Количество созданных сотрудников (по счётчику сотрудников): " + colvo_2.ToString() + "\n"
                + "Минимальная з/п каждого сотрудника: " + min_salary.ToString(),
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // проверяем, что элемент выбран
            {
                var selectedText = listBox1.SelectedItem.ToString();
                var index = selectedText.IndexOf(" (");
                var result = selectedText.Substring(0, index);
                var find_emp = _employeeManager.FindEmployeeByField("IDEmployee", result);
                if (find_emp != null)
                {
                    _employeeManager.RemoveEmployee(find_emp);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // проверяем, что элемент выбран
                /*string texmt_text = listBox1.SelectedItem.ToString();*/
                /*Change_salary form_change_salary = new Change_salary(texmt_text);*/
                using (var form_change_salary = new Change_salary())
                {
                    var result = form_change_salary.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        var texmt_text = form_change_salary.Result;
                        if (texmt_text != "")
                        {
                            float salary_change;
                            if (!float.TryParse(texmt_text, NumberStyles.Float, CultureInfo.InvariantCulture,
                                    out salary_change)) salary_change = 0;

                            if (salary_change != 0)
                            {
                                var selectedText = listBox1.SelectedItem.ToString();
                                var index = selectedText.IndexOf(":");
                                var result_find = selectedText.Substring(0, index);
                                var find_emp = _employeeManager.FindEmployeeByField("IDEmployee", result_find);
                                if (find_emp != null)
                                {
                                    var base_salaty = find_emp.get_salary();
                                    var fieldsToUpdate = new Dictionary<string, object>()
                                    {
                                        { "salary", base_salaty * (1 + salary_change / 100) }
                                    };

                                    _employeeManager.UpdateEmployee(result_find, fieldsToUpdate);

                                    listBox1.Items[listBox1.SelectedIndex] = find_emp.ToString();
                                }
                            }
                        }
                    }
                }
        }

        private void textBox_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;

            // Разрешаем ввод цифр, точки и запятой
            if (char.IsDigit(ch) || ch == '.' || ch == ',')
            {
                // Проверяем, есть ли уже точка или запятая в строке
                if (textBox_first_name.Text.Contains('.') || textBox_first_name.Text.Contains(','))
                    // Если есть, блокируем ввод новой точки или запятой
                    e.Handled = ch == '.' || ch == ',';
            }
            else if (ch == (char)Keys.Back)
            {
                // Разрешаем удаление символов
                e.Handled = false;
            }
            else
            {
                // Блокируем все остальные символы
                e.Handled = true;
            }
        }

        private void textBox_first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        private void textBox_middle_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        private void textBox_second_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }
        
    }
}