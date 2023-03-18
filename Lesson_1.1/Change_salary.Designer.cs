using System.ComponentModel;

namespace Lesson_01
{
    partial class Change_salary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_show_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(180, 18);
            this.textBox_first_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(116, 22);
            this.textBox_first_name.TabIndex = 4;
            this.textBox_first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_first_name_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Изменить з/п на:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(303, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "%";
            // 
            // button_show_info
            // 
            this.button_show_info.Location = new System.Drawing.Point(24, 49);
            this.button_show_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_show_info.Name = "button_show_info";
            this.button_show_info.Size = new System.Drawing.Size(337, 30);
            this.button_show_info.TabIndex = 11;
            this.button_show_info.Text = "Изменить";
            this.button_show_info.UseVisualStyleBackColor = true;
            this.button_show_info.Click += new System.EventHandler(this.button_show_info_Click);
            // 
            // Change_salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 92);
            this.Controls.Add(this.button_show_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Change_salary";
            this.Text = "Change_salary";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_show_info;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}