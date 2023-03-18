namespace Lesson_01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_middle_name = new System.Windows.Forms.TextBox();
            this.textBox_second_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.button_add_emloyee = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_show_info = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Отчество";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(136, 10);
            this.textBox_first_name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(151, 20);
            this.textBox_first_name.TabIndex = 2;
            this.textBox_first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_first_name_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // textBox_middle_name
            // 
            this.textBox_middle_name.Location = new System.Drawing.Point(136, 32);
            this.textBox_middle_name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_middle_name.Name = "textBox_middle_name";
            this.textBox_middle_name.Size = new System.Drawing.Size(151, 20);
            this.textBox_middle_name.TabIndex = 4;
            this.textBox_middle_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_middle_name_KeyPress);
            // 
            // textBox_second_name
            // 
            this.textBox_second_name.Location = new System.Drawing.Point(136, 55);
            this.textBox_second_name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_second_name.Name = "textBox_second_name";
            this.textBox_second_name.Size = new System.Drawing.Size(151, 20);
            this.textBox_second_name.TabIndex = 5;
            this.textBox_second_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_second_name_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Заработная плата";
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(136, 78);
            this.textBox_salary.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(151, 20);
            this.textBox_salary.TabIndex = 7;
            this.textBox_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_salary_KeyPress);
            // 
            // button_add_emloyee
            // 
            this.button_add_emloyee.Location = new System.Drawing.Point(159, 130);
            this.button_add_emloyee.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_emloyee.Name = "button_add_emloyee";
            this.button_add_emloyee.Size = new System.Drawing.Size(127, 24);
            this.button_add_emloyee.TabIndex = 8;
            this.button_add_emloyee.Text = "Добавить к списку";
            this.button_add_emloyee.UseVisualStyleBackColor = true;
            this.button_add_emloyee.Click += new System.EventHandler(this.add_emloyee_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(301, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 199);
            this.listBox1.TabIndex = 9;
            // 
            // button_show_info
            // 
            this.button_show_info.Location = new System.Drawing.Point(20, 102);
            this.button_show_info.Margin = new System.Windows.Forms.Padding(2);
            this.button_show_info.Name = "button_show_info";
            this.button_show_info.Size = new System.Drawing.Size(266, 24);
            this.button_show_info.TabIndex = 10;
            this.button_show_info.Text = "Количество созданных сотрудников";
            this.button_show_info.UseVisualStyleBackColor = true;
            this.button_show_info.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "Удалить сотрудника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 186);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 24);
            this.button3.TabIndex = 12;
            this.button3.Text = "Изменить заработную плату";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "Сотрудник", "Менеджер" });
            this.comboBox1.Location = new System.Drawing.Point(20, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 215);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_show_info);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_add_emloyee);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_second_name);
            this.Controls.Add(this.textBox_middle_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(618, 262);
            this.Name = "Form1";
            this.Text = "Платёжная ведомость";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button_show_info;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Button button_add_emloyee;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_salary;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_middle_name;
        private System.Windows.Forms.TextBox textBox_second_name;

        private System.Windows.Forms.TextBox textBox_first_name;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}