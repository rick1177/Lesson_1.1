using System;
using System.Windows.Forms;

namespace Lesson_01
{
    public partial class Change_bonus : Form
    {
        public string Result { get; private set; }
        
        public Change_bonus()
        {
            InitializeComponent();
        }

        private void textBox_сhange_bonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;

        }

    }
}