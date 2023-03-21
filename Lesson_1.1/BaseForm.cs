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
            // Устанавливаем первый элемент списка
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
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
            float bonus;
            if (!float.TryParse(textBox_bonus.Text, out bonus)) bonus = 0;

            if ((fn == "") & (mn == "") & (sn == "") & (salary == 0) & (bonus ==0))
            {
                if (selectedItem != "")
                {
                    if (selectedItem == "Сотрудник")
                    {
                        emp = new Employee();
                    }
                    else
                    {
                        emp = new Manager();
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

                    if (selectedItem == "Сотрудник")
                    {
                        emp = new Employee(emptyDict);   
                    }
                    else
                    {
                        if (bonus == 0)
                        {
                            emp = new Manager(emptyDict);
                        }
                        else
                        {
                            emp = new Manager(emptyDict, salary, bonus);
                        }
                    }
                }
                else
                {
                    var emptyDict = new Dictionary<string, string>();
                    emptyDict.Add("first_name", fn);
                    emptyDict.Add("middle_name", mn);
                    emptyDict.Add("second_name", sn);

                    if (selectedItem == "Сотрудник")
                    {
                        emp = new Employee(emptyDict, salary);
                    }
                    else
                    {
                        if (bonus == 0)
                        {
                            emp = new Manager(emptyDict, salary);
                        }
                        else
                        {
                            emp = new Manager(emptyDict, salary, bonus);
                        }
                    }
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
            if (listBox1.SelectedIndex != -1)
            {
                // проверяем, что элемент выбран
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
                                result_find = result_find.Substring(0, result_find.IndexOf(' '));
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
        }

        private void textBox_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;

            // Разрешаем ввод цифр и точки
            if (char.IsDigit(ch) || ch == '.')
            {
                var text = textBox_salary.Text;

                // Проверяем, есть ли уже точка или запятая в строке
                if (ch == '.' && (text.Contains('.') || text.Length == 0 || text.EndsWith(".")))
                {
                    e.Handled = true;
                }
                else if (text.Contains('.'))
                {
                    // Проверяем, сколько цифр после точки
                    var parts = text.Split('.');
                    if (parts.Length > 1 && parts[1].Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
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
        
        private void textBox_bonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;

            // Разрешаем ввод цифр и точки
            if (char.IsDigit(ch) || ch == '.')
            {
                var text = textBox_bonus.Text;

                // Проверяем, есть ли уже точка или запятая в строке
                if (ch == '.' && (text.Contains('.') || text.Length == 0 || text.EndsWith(".")))
                {
                    e.Handled = true;
                }
                else if (text.Contains('.'))
                {
                    // Проверяем, сколько цифр после точки
                    var parts = text.Split('.');
                    if (parts.Length > 1 && parts[1].Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Менеджер")
            {
                textBox_bonus.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Сотрудник")
            {
                textBox_bonus.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (change_item.Text == "Изменить запись целиком")
                {
                    button_show_info.Enabled = false;
                    comboBox1.Enabled = false;
                    button_add_emloyee.Enabled = false;
                    delete_item.Enabled = false;
                    change_salary.Enabled = false;
                    change_item.Text = "O.K.";
                }
                else
                {
                    button_show_info.Enabled = true;
                    comboBox1.Enabled = true;
                    button_add_emloyee.Enabled = true;
                    delete_item.Enabled = true;
                    change_salary.Enabled = true;
                    change_item.Text = "Изменить запись целиком";
                }
            }
        }
    }
}