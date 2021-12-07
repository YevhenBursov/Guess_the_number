using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            int max_val = 200;
            int min_val = 0;
            int average_val = max_val / 2;
            int number = Convert.ToInt32(textBox1.Text);
            int counter = 0;
            if (number>max_val || number<min_val)
            {
                MessageBox.Show("Число должно быть в границе от 0 до 200!");
            }
            else
            {
                do
                {
                    DialogResult dialogResult = MessageBox.Show($"Ваше число больше {average_val}?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        min_val = average_val;
                        average_val = (min_val + max_val) / 2;
                    }
                    if(dialogResult== DialogResult.No)
                    {
                        max_val = average_val;
                        average_val = (min_val + max_val) / 2;
                    }
                    counter++;
                } while (average_val!=min_val);
                    MessageBox.Show($"Бинго! Ваше число: {average_val + 1}\n" +
                        $"Количество вопросов: {counter}");                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
