using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dualsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.KeyPreview = true;

        }




        public void AddValueToResult()
        {
            // Werte Zurücksetzen
            int result = 0;
            lblBin1.Text = "0";
            lblBin2.Text = "0";
            lblBin4.Text = "0";
            lblBin8.Text = "0";
            lblBin16.Text = "0";
            lblBin32.Text = "0";
            lblBin64.Text = "0";
            lblBin128.Text = "0";




            if (checkBox1.Checked)
            {
                result = result + 1;
                lblBin1.Text = "1";
            }

            if (checkBox2.Checked)
            {
                result = result + 2;
                lblBin2.Text = "1";
            }

            if (checkBox4.Checked)
            {
                result = result + 4;
                lblBin4.Text = "1";
            }

            if (checkBox8.Checked)
            {
                result = result + 8;
                lblBin8.Text = "1";
            }

            if (checkBox16.Checked)
            {
                result = result + 16;
                lblBin16.Text = "1";
            }

            if (checkBox32.Checked)
            {
                result = result + 32;
                lblBin32.Text = "1";
            }

            if (checkBox64.Checked)
            {
                result = result + 64;
                lblBin64.Text = "1";
            }

            if (checkBox128.Checked)
            {
                result = result + 128;
                lblBin128.Text = "1";
            }








            lblResult.Text = result.ToString();
        }

        public void ResetBox()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
            checkBox8.Checked = false;
            checkBox16.Checked = false;
            checkBox32.Checked = false;
            checkBox64.Checked = false;
            checkBox128.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AddValueToResult();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            AddValueToResult();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            AddValueToResult();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            AddValueToResult();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            AddValueToResult();
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            AddValueToResult();
        }

        private void checkBox64_CheckedChanged(object sender, EventArgs e)
        {
            AddValueToResult();
        }

        private void checkBox128_CheckedChanged(object sender, EventArgs e)
        {
            AddValueToResult();
        }





        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox4.Checked = true;
                checkBox8.Checked = true;
                checkBox16.Checked = true;
                checkBox32.Checked = true;
                checkBox64.Checked = true;
                checkBox128.Checked = true;
            }
            
            if (e.Control && e.KeyCode == Keys.R)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox8.Checked = false;
                checkBox16.Checked = false;
                checkBox32.Checked = false;
                checkBox64.Checked = false;
                checkBox128.Checked = false;
            }

            if (e.Control && e.KeyCode == Keys.P)
            {
                MessageBox.Show($"Binary: {lblBin1.Text}{lblBin2.Text}{lblBin4.Text}{lblBin8.Text}{lblBin16.Text}{lblBin32.Text}{lblBin64.Text}{lblBin128.Text}{Environment.NewLine}Decimal: {lblResult.Text}", "Result");
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText($"Binary: {lblBin1.Text}{lblBin2.Text}{lblBin4.Text}{lblBin8.Text}{lblBin16.Text}{lblBin32.Text}{lblBin64.Text}{lblBin128.Text}{Environment.NewLine}Decimal: {lblResult.Text}");
            }


            if (e.Control && e.KeyCode == Keys.H)
            {
                MessageBox.Show(
                    $"ESC = Exit Application{Environment.NewLine}" +
                    $"CTRL + R = RESET{Environment.NewLine}" +
                    $"CTRL + A = Check All Checkboxes{Environment.NewLine}" +
                    $"CTRL + P = Show results in MessageBox{Environment.NewLine}" +
                    $"CTRL + C = Copy results to clipboard{Environment.NewLine}" +
                    $"CTRL + H = Show hotkeys", "Hotkeys");
            }













        }


        // Suchen
        private void txtBoxSeachValue_ValueChanged(object sender, EventArgs e)
        {
            if (txtBoxSeachValue.Value == 1)
            {
                ResetBox();
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 2)
            {
                ResetBox();
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 3)
            {
                ResetBox();
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 4)
            {
                ResetBox();
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 5)
            {
                ResetBox();
                checkBox1.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 6)
            {
                ResetBox();
                checkBox2.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 7)
            {
                ResetBox();
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 8)
            {
                ResetBox();
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 9)
            {
                ResetBox();
                checkBox1.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 10)
            {
                ResetBox();
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }


            else if (txtBoxSeachValue.Value == 11)
            {
                ResetBox();
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 12)
            {
                ResetBox();
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 13)
            {
                ResetBox();
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 14)
            {
                ResetBox();
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 15)
            {
                ResetBox();
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 16)
            {
                ResetBox();
                checkBox16.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 17)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 18)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 19)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 20)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 21)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 22)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 23)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 24)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 25)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 26)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 27)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 28)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 29)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 30)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 31)
            {
                ResetBox();
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 32)
            {
                ResetBox();
                checkBox32.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 33)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 34)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 35)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 36)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 37)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 38)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 39)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 40)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 41)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 42)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 43)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 44)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 45)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 46)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 47)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 48)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 49)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 50)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 51)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 52)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 53)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox1.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 54)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 55)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 56)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 57)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 58)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 59)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 60)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 61)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 62)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 63)
            {
                ResetBox();
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 64)
            {
                ResetBox();
                checkBox64.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 65)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 66)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 67)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 68)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 69)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 70)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 71)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 72)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 73)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox1.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 74)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox2.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 75)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 76)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox4.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 77)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox1.Checked = true;
                checkBox4.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 78)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox2.Checked = true;
                checkBox4.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 79)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
                checkBox4.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 80)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 81)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 82)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 83)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 84)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 85)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 86)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 87)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 88)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 89)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 90)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 91)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 92)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 93)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 94)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 95)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 96)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 97)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 98)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 99)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 100)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 101)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 102)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 103)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 104)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 105)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 106)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 107)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 108)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 109)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 109)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 110)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 111)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 112)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 113)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 114)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 115)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 116)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 117)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 118)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 119)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 120)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 121)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 122)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 123)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 124)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 125)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 126)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 127)
            {
                ResetBox();
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 128)
            {
                ResetBox();
                checkBox128.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 129)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 130)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 131)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 132)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 133)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 134)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 135)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 136)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 137)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 138)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 139)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 140)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 141)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 142)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 143)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 144)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 145)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 146)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 147)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 148)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 149)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 150)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 151)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 152)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 153)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 154)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 155)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 156)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 157)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 158)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 159)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 160)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 161)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 162)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 163)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 164)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 165)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 166)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 167)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 168)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 169)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 170)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 171)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 172)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 173)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 174)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 175)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 176)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 177)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 178)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 179)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 180)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 181)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 182)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 183)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 184)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 185)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 186)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 187)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 188)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 189)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }


            else if (txtBoxSeachValue.Value == 190)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 191)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 192)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 193)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 194)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 195)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 196)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 197)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 198)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 199)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 200)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox8.Checked = true;
            }
            // shit dont work

            else if (txtBoxSeachValue.Value == 201)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 202)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 203)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 204)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 205)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 206)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 207)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 208)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 209)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 210)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 211)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 212)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 213)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 214)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 215)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 216)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 217)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 218)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 219)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 220)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 221)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 222)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 223)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 224)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 225)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox1.Checked = true;
            }


            else if (txtBoxSeachValue.Value == 226)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 227)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 228)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 229)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 230)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 231)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 232)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 233)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 234)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 235)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 236)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 237)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 238)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 239)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox8.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 240)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 241)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 242)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 243)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 244)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 245)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 246)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 247)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 248)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 249)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox1.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 250)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 251)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 252)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox8.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 253)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox8.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 254)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 254)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 255)
            {
                ResetBox();
                checkBox128.Checked = true;
                checkBox64.Checked = true;
                checkBox32.Checked = true;
                checkBox16.Checked = true;
                checkBox4.Checked = true;
                checkBox8.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Checked = true;
            }

            else if (txtBoxSeachValue.Value == 0)
            {
                ResetBox();
            }


            else if (txtBoxSeachValue.Value > 255)
            {
                MessageBox.Show("Max. 255");
            }

        }


        private void txtBoxSeachBinaryValue_ValueChanged(object sender, EventArgs e)
        {
            int binaryNumber = int.Parse(txtBoxSeachBinaryValue.Value.ToString());
            int decimalValue = 0;
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            string result = decimalValue.ToString();
            MessageBox.Show(result);





        }

        // Nicht wichtig
        private void lblBin64_Click(object sender, EventArgs e)
        {

        }


    }
}
