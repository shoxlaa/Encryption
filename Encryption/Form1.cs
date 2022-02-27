using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
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
            comboBox1.Items.Add("Encrypt");
            comboBox1.ValueMember = "Value";
            comboBox1.Items.Add("Decrypt");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
