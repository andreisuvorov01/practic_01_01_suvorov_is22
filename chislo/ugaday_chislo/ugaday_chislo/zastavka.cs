using System;
using System.IO;

namespace ugaday_chislo
{
    public partial class zastavka : Form
    {
        public zastavka()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            string pravila;

            StreamReader sr = new StreamReader(@"pravila.txt");
            while ((pravila = sr.ReadLine()) != null)
            {
                MessageBox.Show(pravila, "Правила", MessageBoxButtons.OK);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form ifrm = new main_game();
            ifrm.Show();
        }
    }
}