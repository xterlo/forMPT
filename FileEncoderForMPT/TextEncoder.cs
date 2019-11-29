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

namespace FileEncoderForMPT
{
    public partial class TextEncoder : Form
    {
        public static string keyForEncoder="";
        public TextEncoder()
        {
            InitializeComponent();
            
        }

        private void TextEncoder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            
            string text = EncryptText.Text; // Взял текст          
            string key = keyForEncoder;
            string text2bs64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(text)); //Текст2bs64
            int bs64Lenght = text2bs64.Length;
            string firstHalf = text2bs64.Substring(0, bs64Lenght / 2); // Взял 1 половину текст
            string secondHalf = text2bs64.Substring(bs64Lenght / 2); // 2 половину
            string mergeText = secondHalf + firstHalf; // Объединил
            string tempText; //переменная для временных действий 
            string temp64 = ""; // переменная для след. шага
            
            for (int i = 0; i < bs64Lenght - 1; i++)// меняю местами 2 символа
            {

                tempText = Convert.ToString(mergeText[i + 1]) + Convert.ToString(mergeText[i]);
                i++;
                temp64 = temp64 + tempText;
            }
            string secondBS64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(temp64)); // еще раз в bs64

            char[] keyChars = key.ToCharArray();
            char[] textChars = secondBS64.ToCharArray();
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
            string EncryptedText = Convert.ToBase64String(Encoding.UTF8.GetBytes(lastText));
            DecryptText.Text = EncryptedText;
            EncryptText.Text = "";
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string text = DecryptText.Text;
                string textCharArrayS = Encoding.UTF8.GetString(Convert.FromBase64String(text));
                string key = keyForEncoder;
                char[] textCharArray = textCharArrayS.ToCharArray();
                int temp = 0;
                string fText = "";
                char[] keyChars = key.ToCharArray();

                for (int i = 0; i < textCharArray.Length; i++)
                {
                    if (temp >= keyChars.Length) temp = 0;
                    int textChars = (int)textCharArray[i] - (int)keyChars[temp];
                    temp++;
                    char tempChar = (char)textChars;
                    fText = fText + tempChar.ToString();
                }
                string secondBS64 = Encoding.UTF8.GetString(Convert.FromBase64String(fText));
                int bs64Lenght = secondBS64.Length;
                string temp64 = "";
                for (int i = 0; i < bs64Lenght - 1; i++)// меняю местами 2 символа
                {

                    string tempText = Convert.ToString(secondBS64[i + 1]) + Convert.ToString(secondBS64[i]);
                    i++;
                    temp64 = temp64 + tempText;
                }
                string firstHalf = temp64.Substring(0, bs64Lenght / 2); // Взял 1 половину текст
                string secondHalf = temp64.Substring(bs64Lenght / 2); // 2 половину
                string mergeText = secondHalf + firstHalf; // Объединил
                string DecryptedText = Encoding.UTF8.GetString(Convert.FromBase64String(mergeText));
                DecryptText.Text = "";
                EncryptText.Text = DecryptedText;
            }
            catch
            {
                MessageBox.Show("Ошибка, неверный ключ!");
            }
        }

        private void ApplyKeyButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(KeyTextBox.Text);
            if (KeyTextBox.Text.Length >= 4 && KeyTextBox.Text.Length <= 32)
            {
                keyForEncoder = KeyTextBox.Text;
                EncryptButton.Enabled = true;
                DecryptText.Enabled = true;
                EncryptText.Enabled = true;
                DecryptButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ключ должен состоять из 4-32 символов");
                EncryptButton.Enabled = false;
                DecryptText.Enabled = false;
                EncryptText.Enabled = false;
                DecryptButton.Enabled = false;
            }
        }

        private void KeyGen_Click(object sender, EventArgs e)
        {
            string alphabetS = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm=!@#$%^&*;><:";
            char[] alphabet = alphabetS.ToCharArray();
            Random rnd = new Random();
            
            int countLetters = rnd.Next(10, 32);
            string key = "";
            for (int i =0; i<countLetters;i++)
            {
                int letterNumber = rnd.Next(alphabet.Length);
                key = key + alphabet[letterNumber];
            }
            KeyTextBox.Text = key;
            ApplyKeyButton_Click(sender, e);
        }
    }
   
}
