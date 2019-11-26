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
            string text2bs64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(text)); //Текст2bs64
            int bs64Lenght = text2bs64.Length;
            string firstHalf = text2bs64.Substring(0,bs64Lenght / 2); // Взял 1 половину текст
            string secondHalf = text2bs64.Substring(bs64Lenght / 2); // 2 половину
            string mergeText = secondHalf + firstHalf; // Объединил
            string tempText; //переменная для временных действий 
            string firstANDlast = ""; // переменная для след. шага
            string firstANDsecond = ""; // переменная для след. шага

            for (int i = 0; i < bs64Lenght/2; i++) // перебрасываю последнюю букву к первым
            {
                tempText = Convert.ToString(mergeText[i]) + Convert.ToString(mergeText[bs64Lenght-i-1]); //беру первую и последнюю буквы
                firstANDlast = firstANDlast + tempText; //записываю их
            }

            for (int i=0; i < bs64Lenght-1;i++)// меняю местами 2 символа
            {

                tempText = Convert.ToString(firstANDlast[i + 1]) + Convert.ToString(firstANDlast[i]);
                i++;
                firstANDsecond = firstANDsecond + tempText;

            }

            string secondBS64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(firstANDsecond)); // еще раз в bs64

            Console.WriteLine(mergeText);
            Console.WriteLine(firstANDlast);
            Console.WriteLine(firstANDsecond);
            Console.WriteLine(secondBS64);
        }
    }
}
