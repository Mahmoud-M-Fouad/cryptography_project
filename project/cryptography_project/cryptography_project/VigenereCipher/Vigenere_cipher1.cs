using cryptography_project.VigenereCipher;
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
    public partial class Vigenere_cipher : Form
    {
        static bool enc = true;
        string path;
        string readText;

        string decreptionText = "";
        string encreptionText = "";
        static String alphabets = "abcdefghijklmnopqrstuvwxyz";
        //--------------------------------------------
        static char[,] char_array = new char[27, 27];

        public static void filling_matrix()
        {

            int counter = 0, counter2 = 0;
            for (int i = 1; i < 27; i++)
            {
                counter2 = counter;
                for (int j = 1; j < 27; j++)
                {
                    char_array[i, j] = alphabets[counter2];
                    counter2 = (counter2 + 1) % 26;
                }
                counter = (counter + 1) % 26;
            }
        }

        public static void filling_matrix_boarders()
        {
            char_array[0, 0] = '!';
            for (int i = 1; i < 27; i++)
            {
                char_array[0, i] = alphabets[i - 1];
                char_array[i, 0] = alphabets[i - 1];
            }
        }

        static String vigenere_encreption_with_table(String plain_text, String key)
        {
            filling_matrix_boarders();
            filling_matrix();
            String cipher_text = "";
            int n, n2;
            int key_counter = 0;

            for (int i = 0; i < plain_text.Length; i++)
            {
                if (plain_text[i] >= 'a' && plain_text[i] <= 'z')
                {
                    n = (int)plain_text[i] - (int)'a';
                    n2 = (int)key[key_counter++] - (int)'a';
                    key_counter = key_counter % key.Length;
                    cipher_text += char_array[n2 + 1, n + 1];
                }
                else
                {
                    cipher_text += plain_text[i];
                }
                   
            }


            return cipher_text;
        }

        static String vigenere_decryprion_with_table(String cipher_text, String key)
        {
            String plain_text = "";
            int n, n2;
            int key_counter = 0;
            for (int i = 0; i < cipher_text.Length; i++)
            {
                if (cipher_text[i] >= 'a' && cipher_text[i] <= 'z')
                {
                    n = (int)cipher_text[i] - (int)'a';
                    n2 = (int)key[key_counter++] - (int)'a';
                    key_counter = key_counter % key.Length;
                    for (int j = 1; j < 27; j++)
                    {
                        if (char_array[n2 + 1, j] == cipher_text[i])
                            plain_text += char_array[0, j];

                    }
                }
                else plain_text += cipher_text[i];

            }

            return plain_text;
        }
        //--------------------------------------------

        public Vigenere_cipher()
        {
            InitializeComponent();
            t.Text = "";

        }

        private void txt_key_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    Console.WriteLine(str);
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
                if (txt_key.Text != ""&& t.Text != "")
                {
                    if (enc == true)
                    {
                        Console.WriteLine("-------------1");
                        //encreptionText = vigenere_encreption(readText, txt_key.Text);
                        encreptionText= vigenere_encreption_with_table(readText, txt_key.Text);
                        Console.WriteLine("-------------2");
                        enc = false;
                        Console.WriteLine(enc);
                        Console.WriteLine(encreptionText);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_key.Text != ""&&t.Text != "")
                {
                    if (enc != true)
                    {
                        //decreptionText = vigenere_decreption(encreptionText, txt_key.Text);
                        Console.WriteLine("-------------1");
                        Console.WriteLine(encreptionText);
                       decreptionText = vigenere_decryprion_with_table(encreptionText, txt_key.Text);
                        Console.WriteLine("-------------2");
                        enc = true;
                        t.Text = decreptionText;
                        Console.WriteLine("-------------3");
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

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            About_Algorithm_vig1 m = new About_Algorithm_vig1();
            m.ShowDialog();
        }
    }
}
