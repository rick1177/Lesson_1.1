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
            this.delete_item = new System.Windows.Forms.Button();
            this.change_salary = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_bonus = new System.Windows.Forms.TextBox();
            this.change_item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Отчество";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(181, 12);
            this.textBox_first_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(200, 22);
            this.textBox_first_name.TabIndex = 2;
            this.textBox_first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_first_name_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // textBox_middle_name
            // 
            this.textBox_middle_name.Location = new System.Drawing.Point(181, 40);
            this.textBox_middle_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_middle_name.Name = "textBox_middle_name";
            this.textBox_middle_name.Size = new System.Drawing.Size(200, 22);
            this.textBox_middle_name.TabIndex = 4;
            this.textBox_middle_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_middle_name_KeyPress);
            // 
            // textBox_second_name
            // 
            this.textBox_second_name.Location = new System.Drawing.Point(181, 68);
            this.textBox_second_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_second_name.Name = "textBox_second_name";
            this.textBox_second_name.Size = new System.Drawing.Size(200, 22);
            this.textBox_second_name.TabIndex = 5;
            this.textBox_second_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_second_name_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Заработная плата";
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(181, 96);
            this.textBox_salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(200, 22);
            this.textBox_salary.TabIndex = 7;
            this.textBox_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_salary_KeyPress);
            // 
            // button_add_emloyee
            // 
            this.button_add_emloyee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_add_emloyee.Location = new System.Drawing.Point(213, 186);
            this.button_add_emloyee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_emloyee.Name = "button_add_emloyee";
            this.button_add_emloyee.Size = new System.Drawing.Size(169, 30);
            this.button_add_emloyee.TabIndex = 8;
            this.button_add_emloyee.Text = "Добавить к списку";
            this.button_add_emloyee.UseVisualStyleBackColor = true;
            this.button_add_emloyee.Click += new System.EventHandler(this.add_emloyee_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(401, 12);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 308);
            this.listBox1.TabIndex = 9;
            // 
            // button_show_info
            // 
            this.button_show_info.Location = new System.Drawing.Point(27, 152);
            this.button_show_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_show_info.Name = "button_show_info";
            this.button_show_info.Size = new System.Drawing.Size(355, 30);
            this.button_show_info.TabIndex = 10;
            this.button_show_info.Text = "Количество созданных сотрудников";
            this.button_show_info.UseVisualStyleBackColor = true;
            this.button_show_info.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_item
            // 
            this.delete_item.Location = new System.Drawing.Point(27, 220);
            this.delete_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_item.Name = "delete_item";
            this.delete_item.Size = new System.Drawing.Size(355, 30);
            this.delete_item.TabIndex = 11;
            this.delete_item.Text = "Удалить сотрудника";
            this.delete_item.UseVisualStyleBackColor = true;
            this.delete_item.Click += new System.EventHandler(this.button2_Click);
            // 
            // change_salary
            // 
            this.change_salary.Location = new System.Drawing.Point(26, 254);
            this.change_salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_salary.Name = "change_salary";
            this.change_salary.Size = new System.Drawing.Size(355, 30);
            this.change_salary.TabIndex = 12;
            this.change_salary.Text = "Изменить заработную плату";
            this.change_salary.UseVisualStyleBackColor = true;
            this.change_salary.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "Сотрудник", "Менеджер" });
            this.comboBox1.Location = new System.Drawing.Point(28, 188);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(26, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Бонус\r\n";
            // 
            // textBox_bonus
            // 
            this.textBox_bonus.Enabled = false;
            this.textBox_bonus.Location = new System.Drawing.Point(182, 124);
            this.textBox_bonus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_bonus.Name = "textBox_bonus";
            this.textBox_bonus.Size = new System.Drawing.Size(200, 22);
            this.textBox_bonus.TabIndex = 7;
            this.textBox_bonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_bonus_KeyPress);
            // 
            // change_item
            // 
            this.change_item.Location = new System.Drawing.Point(28, 288);
            this.change_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_item.Name = "change_item";
            this.change_item.Size = new System.Drawing.Size(355, 30);
            this.change_item.TabIndex = 14;
            this.change_item.Text = "Изменить запись целиком";
            this.change_item.UseVisualStyleBackColor = true;
            this.change_item.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 326);
            this.Controls.Add(this.change_item);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.change_salary);
            this.Controls.Add(this.delete_item);
            this.Controls.Add(this.button_show_info);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_add_emloyee);
            this.Controls.Add(this.textBox_bonus);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_second_name);
            this.Controls.Add(this.textBox_middle_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(818, 312);
            this.Name = "Form1";
            this.Text = "Платёжная ведомость";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button change_item;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_bonus;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button delete_item;
        private System.Windows.Forms.Button change_salary;

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