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

namespace Encryption
{
    public partial class Form1 : Form
    {
        private const string inputValue = "Input...";
        public Form1()
        {
            InitializeComponent();
        }

        interface IEncryptable
        {
            String Encrypt(String s);
            String Decrypt(String s);
        }
        public class XOR : IEncryptable
        {

            public String Encrypt(String inputString)
            {

                char xorKey = 'S';

                String outputString = "";

                int len = inputString.Length;

                for (int i = 0; i < len; i++)
                {
                    outputString = outputString +
                    char.ToString((char)(inputString[i] ^ xorKey));
                }


                return outputString;
            }
            public string Decrypt(string s)
            {
                return Encrypt(s);
            }



        }

        public class CaesarCipher
        {

            public int Shift { get; set; }

            public CaesarCipher(int Shift)
            {
                this.Shift = Shift;
            }
            public StringBuilder encrypt(String text)
            {
                StringBuilder result = new StringBuilder();

                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsUpper(text[i]))
                    {
                        char ch = (char)(((int)text[i] +
                                        Shift - 65) % 26 + 65);
                        result.Append(ch);
                    }
                    else
                    {
                        char ch = (char)(((int)text[i] +
                                        Shift - 97) % 26 + 97);
                        result.Append(ch);
                    }
                }
                return result;
            }
            public StringBuilder decrypt(StringBuilder text)
            {
                StringBuilder result = new StringBuilder();

                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsUpper(text[i]))
                    {
                        char ch = (char)(((int)text[i] -
                                        Shift - 65) % 26 + 65);
                        result.Append(ch);
                    }
                    else
                    {
                        char ch = (char)(((int)text[i] -
                                        Shift - 97) % 26 + 97);
                        result.Append(ch);
                    }
                }
                return result;
            }
        }

        public class BitwiseInversion
        {

        } 



        private void Form1_Load(object sender, EventArgs e)
        {
            inputTextBox.Text = inputValue;
            comboBox1.Items.Add("Encrypt");
            comboBox1.Items.Add("Decrypt");

            comboBox2.Items.Add("XOR"); 
            comboBox2.Items.Add("Caesar"); 
            comboBox2.Items.Add("BitwiseInversion"); 
        }

        private IEncryptable ll; 
       

        private void inputTextBox_Enter(object sender, EventArgs e)
        {
            if (inputTextBox.Text != inputValue)
            {
                return;
            }

            inputTextBox.Text = string.Empty;
        }

        private void inputTextBox_Leave(object sender, EventArgs e)
        {
            if(inputTextBox.Text.Length > 0)

            {
                return;
            }

            inputTextBox.Text = inputValue;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "text file(*.txt)|*.txt";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                   inputTextBox.Text= File.ReadAllText(dialog.FileName);
                }
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "text file(*.txt)|*.txt";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    File.WriteAllText(dialog.FileName, inputTextBox.Text);
                }
            }
        }

        private void encryptDecryptButton_Click(object sender, EventArgs e)
        {
            
            



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ll = new XOR(); 
            }
        }
    }
}
