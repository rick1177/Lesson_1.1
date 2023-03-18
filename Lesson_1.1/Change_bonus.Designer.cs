using System.ComponentModel;

namespace Lesson_01
{
    partial class Change_bonus
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
            this.button_show_info = new System.Windows.Forms.Button();
            this.textBox_change_bonus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_show_info
            // 
            this.button_show_info.Location = new System.Drawing.Point(17, 38);
            this.button_show_info.Margin = new System.Windows.Forms.Padding(2);
            this.button_show_info.Name = "button_show_info";
            this.button_show_info.Size = new System.Drawing.Size(253, 24);
            this.button_show_info.TabIndex = 14;
            this.button_show_info.Text = "Изменить";
            this.button_show_info.UseVisualStyleBackColor = true;
            // 
            // textBox_change_bonus
            // 
            this.textBox_change_bonus.Location = new System.Drawing.Point(134, 13);
            this.textBox_change_bonus.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_change_bonus.Name = "textBox_change_bonus";
            this.textBox_change_bonus.Size = new System.Drawing.Size(136, 20);
            this.textBox_change_bonus.TabIndex = 13;
            this.textBox_change_bonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_сhange_bonus_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Назначить бонус:";
            // 
            // Change_bonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 75);
            this.Controls.Add(this.button_show_info);
            this.Controls.Add(this.textBox_change_bonus);
            this.Controls.Add(this.label1);
            this.Name = "Change_bonus";
            this.Text = "Change_bonus";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_show_info;
        private System.Windows.Forms.TextBox textBox_change_bonus;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}