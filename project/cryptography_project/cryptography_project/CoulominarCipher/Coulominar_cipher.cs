using cryptography_project.CoulominarCipher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptography_project
{
    public partial class Coulominar_cipher : Form
    {
        static bool enc = true;
        string path;
        string readText;

        string decreptionText = "";
        string encreptionText = "";
        static String alphabets = "abcdefghijklmnopqrstuvwxyz";

        public static String couluminar_cipher_encreption(String plain_text, String key)
        {
            String cipher_text = "";
            while (plain_text.Length % key.Length != 0)
            {
                plain_text += '!';      //adding some chars to plain text for matrix be good
            }
            int y = 0;
            char[,] array = new char[plain_text.Length / key.Length, key.Length]; //make dimentions of array
            for (int i = 0; i < plain_text.Length / key.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                    array[i, j] = plain_text[y++];
            }

            int[] array_numbers = new int[key.Length];
            int t = 1;
            int yy = 0;
            foreach (char c in alphabets)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (c == key[i])
                        array_numbers[i] = yy++;
                }
            }


            int index;
            for (int i = 0; i < key.Length; i++)
            {
                index = Array.IndexOf(array_numbers, i);
                for (int j = 0; j < plain_text.Length / key.Length; j++)
                {
                    cipher_text += array[j, index];
                }
            }


            return cipher_text;
        }

        public static String couluminar_cipher_decreption(String cipher_text, String key)
        {
            String plain_text = "";
            int y = 0;
            char[,] array = new char[cipher_text.Length / key.Length, key.Length];
            char[,] array2 = new char[cipher_text.Length / key.Length, key.Length];
            for (int j = 0; j < key.Length; j++)
            {
                for (int i = 0; i < cipher_text.Length / key.Length; i++)
                {
                    array[i, j] = cipher_text[y];
                    array2[i, j] = cipher_text[y];
                    y++;
                }
            }

            int[] array_numbers = new int[key.Length];
            int t = 1;
            int yy = 0;
            foreach (char c in alphabets)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (c == key[i])
                        array_numbers[i] = yy++;
                }
            }

            int index;
            for (int i = 0; i < key.Length; i++)
            {
                index = Array.IndexOf(array_numbers, i);
                for (int j = 0; j < cipher_text.Length / key.Length; j++)
                {
                    array2[j, index] = array[j, i];
                }
            }

            for (int i = 0; i < cipher_text.Length / key.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                    plain_text += array2[i, j];

            }



            return plain_text;
        }

        public Coulominar_cipher()
        {
            InitializeComponent();
            t.Text = "";;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            t.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            //t.Text = path;

            try
            {
                if (File.Exists(path))
                {
                    // Read all the content in one string
                    // and display the string
                    string str = File.ReadAllText(path);
                    Console.WriteLine("1");
                    Console.WriteLine(str);
                    Console.WriteLine("2");
                    t.AppendText(str);
                    readText = str;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void btn_encry_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_key.Text != "" && t.Text != "")
                {
                    if (enc == true)
                    {
                        encreptionText = couluminar_cipher_encreption(readText, txt_key.Text);
                        Console.WriteLine("*-----*\n");
                        Console.WriteLine(readText);
                       
                        enc = false;
                        t.Text = encreptionText;
                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct Key \n\nChoice file ,please", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Home m = new Home();
            this.Close();
            m.Show();
        }

        private void btn_decry_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_key.Text != "" && t.Text != "")
                {
                    if (enc != true)
                    {
                        decreptionText = couluminar_cipher_decreption(encreptionText, txt_key.Text);
                        enc = true;
                        t.Text = decreptionText;
                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct Key \n\nChoice file ,please", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            About_Algorithm_col m = new About_Algorithm_col();
            m.ShowDialog();
        }

        private void Coulominar_cipher_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_dec_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\A\Desktop\my_file.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes(encreptionText);
                    fs.Write(title, 0, title.Length);

                }
                MessageBox.Show("File Saved\nPath File :" + fileName, "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void txt_key_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
