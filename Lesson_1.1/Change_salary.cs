using System;
using System.Windows.Forms;

namespace Lesson_01
{
    public partial class Change_salary : Form
    {
        public string Result { get; private set; }

        public Change_salary()
        {
            InitializeComponent();
        }

        public Change_salary(string texmt_text)
        {
            InitializeComponent();
        }


        private void button_show_info_Click(object sender, EventArgs e)
        {
            Result = textBox_first_name.Text;
            DialogResult = DialogResult.OK;
            Close();
        }


        private void textBox_first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;

            // Проверяем, можно ли ввести первый символ
            if (textBox_first_name.TextLength == 0)
            {
                if (ch == '-')
                {
                    // Разрешаем ввод "-"
                    e.Handled = false;
                    return;
                }
                else if (!char.IsDigit(ch))
                {
                    // Если первый символ не число и не "-", блокируем его
                    e.Handled = true;
                    return;
                }
            }

            // Разрешаем ввод цифр, точки и только одного "-"
            if (char.IsDigit(ch) || ch == '.')
            {
                if (ch == '-' && textBox_first_name.Text.Contains("-"))
                {
                    // Если "-" уже введен, блокируем его повторный ввод
                    e.Handled = true;
                }
                else if (ch == '.' && textBox_first_name.Text.Contains("."))
                {
                    // Если "." уже введена, блокируем её повторный ввод
                    e.Handled = true;
                }
                else
                {
                    // Проверяем, является ли введенный символ числом
                    if (!char.IsDigit(e.KeyChar))
                        // Если первый символ не является числом, то предотвращаем его ввод
                        if (textBox_first_name.TextLength < 2 && e.KeyChar != (char)Keys.Back)
                        {
                            e.Handled = true;
                            return;
                        }
                }
            }
            else if (ch == (char)Keys.Back)
            {
                // Разрешаем удаление символов
                e.Handled = false;
                return;
            }
            else
            {
                // Блокируем все остальные символы
                e.Handled = true;
                return;
            }
        }
    }
}