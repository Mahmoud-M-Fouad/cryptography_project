using cryptography_project.VigenereCipher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptography_project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            panel1.Height = 100;

            
        }
        public void methodPanelHeight(Panel p, int size1, int size2)
        {
            if (p.Height == size1)
            {
                while (p.Height < size2)
                    p.Height += 1;
            }
            else
            {

                while (p.Height > size1)
                    p.Height -= 1;
            }
        }
        private void btn_Multiplicative_Click(object sender, EventArgs e)
        {
            Multiplicative m = new Multiplicative();
            this.Hide();
            m.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            methodPanelHeight(panel1, 100, 230-44);
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Coulominar_cipher m = new Coulominar_cipher();
            this.Hide();
            m.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Vigenere_cipher m = new Vigenere_cipher();
             this.Hide();
             m.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Vigenere_cipher2 m = new Vigenere_cipher2();
            this.Hide();
            m.Show();
        }
    }
}
