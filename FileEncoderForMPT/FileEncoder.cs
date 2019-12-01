using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FileEncoderForMPT
{
    public partial class FileEncoder : Form
    {
        public static string keyForEncoder = "";
        public static string importFileName;
        public static string exportFileName;
        public FileEncoder()
        {
            InitializeComponent();
        }

        private void FileEncoder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

        private void ApplyKeyButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(KeyTextBox.Text);
            if (KeyTextBox.Text.Length >= 4 && KeyTextBox.Text.Length <= 32)
            {
                keyForEncoder = KeyTextBox.Text;
                Encrypt.Enabled = true;
                decryptButton.Enabled = true;
                MessageBox.Show("Ключ успешно установлен", "Успех");
            }
            else
            {
                MessageBox.Show("Ключ должен состоять из 4-32 символов","Ошибка");
                Encrypt.Enabled = false;
            }

        }

        private void KeyGen_Click(object sender, EventArgs e)
        {
            string alphabetS = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm=!@#$%^&*;><:";
            char[] alphabet = alphabetS.ToCharArray();
            Random rnd = new Random();

            int countLetters = rnd.Next(10, 32);
            string key = "";
            for (int i = 0; i < countLetters; i++)
            {
                int letterNumber = rnd.Next(alphabet.Length);
                key = key + alphabet[letterNumber];
            }
            KeyTextBox.Text = key;
            ApplyKeyButton_Click(sender, e);
            Encrypt.Enabled = true;
            decryptButton.Enabled = true;
        }

        private void OpenFileDlg_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                importFileName = openFileDialog1.FileName;
                importFile.Text = importFileName;
                openFileDialog1.FileName = null;
                openFileDialog1.RestoreDirectory = true;
                saveFileDlg.Enabled = true;
            }
        }

        private void SaveFileDlg_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                exportFileName = saveFileDialog1.FileName;
                exportFile.Text = exportFileName;
                saveFileDialog1.FileName = null;
                saveFileDialog1.RestoreDirectory = true;
                KeyGen.Enabled = true;
                KeyTextBox.Enabled = true;
                ApplyKeyButton.Enabled = true;
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {

            string text = Encoding.GetEncoding(1252).GetString(File.ReadAllBytes(importFileName));        
            string key = keyForEncoder;
            int bs64Lenght = text.Length;
            string firstHalf = text.Substring(0, bs64Lenght / 2); 
            string secondHalf = text.Substring(bs64Lenght / 2);
            string mergeText = secondHalf + firstHalf; 
            string tempText;
            string temp64 = ""; 
            for (int i = 0; i < bs64Lenght - 1; i++)
            {

                tempText = Convert.ToString(mergeText[i + 1]) + Convert.ToString(mergeText[i]);
                i++;
                temp64 = temp64 + tempText;
            }
            char[] keyChars = key.ToCharArray();
            char[] textChars = temp64.ToCharArray();
            string lastText = "";
            int temp = 0;
            for (int i = 0; i < textChars.Length; i++)
            {
                if (temp >= keyChars.Length) temp = 0;
                int tempChar = (int)textChars[i] + (int)keyChars[temp];
                temp++;
                char lastTextChar = (char)tempChar;
                lastText = lastText + lastTextChar.ToString();
            }
            File.WriteAllText(exportFileName+".encrypted", lastText);
            MessageBox.Show("Файл успешно зашифрован", "Успех");

            
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                char[] keyChars = keyForEncoder.ToCharArray();
                string text = File.ReadAllText(importFileName);
                string fText = "";
                int temp = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (temp >= keyChars.Length) temp = 0;
                    int textCharsS = (int)text[i] - (int)keyChars[temp];
                    temp++;
                    char tempChar = (char)textCharsS;
                    fText = fText + tempChar.ToString();
                }

                string temp64 = "";
                for (int i = 0; i < fText.Length - 1; i++)
                {

                    string tempText = Convert.ToString(fText[i + 1]) + Convert.ToString(fText[i]);
                    i++;
                    temp64 = temp64 + tempText;
                }

                string firstHalf = temp64.Substring(0, temp64.Length / 2); 
                string secondHalf = temp64.Substring(temp64.Length / 2);
                string mergeTextf = secondHalf + firstHalf;            

                File.WriteAllBytes(exportFileName + ".exe", Encoding.GetEncoding(1252).GetBytes(mergeTextf));
                MessageBox.Show("Файл успешно расшифрован!", "Успех");
            }
            catch
            {
                MessageBox.Show("Ошибка, неверный ключ!","Ошибка");
            }
        }
    }
}
