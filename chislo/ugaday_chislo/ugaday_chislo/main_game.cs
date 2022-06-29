using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ugaday_chislo
{
    public partial class main_game : Form
    {
        

        Random random = new Random();
        int rand_chislo = 0;
        int otvet = 0;

        public main_game()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void main_game_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                ((TextBox)sender).ReadOnly = false;
            }
            else
            {
                ((TextBox)sender).ReadOnly = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("вы ничего не ввели", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                otvet += 1;
                int vvod_chislo = Convert.ToInt32(textBox1.Text);
                    if (vvod_chislo == rand_chislo)
                    {
                        MessageBox.Show("Поздравляем, вы угадали!, я загадал новое число", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadQuestions();
                    }
                    else if (vvod_chislo < rand_chislo)
                    {
                        MessageBox.Show("Увы, число больше", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (vvod_chislo > rand_chislo)
                    {
                        MessageBox.Show("Увы, число меньше", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                if (otvet == 3)
                {
                    int otvet = 0;
                    MessageBox.Show("Количество попыток закончилось, попробуйте ещё раз", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadQuestions();
                }
            }

        }

        private void loadQuestions()
        {
            rand_chislo = random.Next(0, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
