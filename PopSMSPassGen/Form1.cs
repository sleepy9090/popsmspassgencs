/**
 *  @file           Form1.cs / PopSMSPassGen
 *  @brief          Password Generator for the Sega Master System Game Prince of Persia
 *  @copyright      Shawn M. Crawford 2019
 *  @date           04/04/2019
 *
 *  @remark Author  Shawn M. Crawford (sleepy9090)
 *
 *  @note           N/A
 *
 */
using System;
using System.Windows.Forms;

namespace PopSMSPassGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            textBoxPassword.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
        }

        private void populateComboBoxes()
        {
            for (int x = 1; x <= 14; x++)
            {
                comboBoxLevel.Items.Add(x);
            }
            comboBoxLevel.SelectedIndex = 0;

            for (int x = 0; x <= 7; x++)
            {
                comboBoxHealth.Items.Add(x);
            }
            comboBoxHealth.SelectedIndex = 0;

            for (int x = 0; x <= 99; x++)
            {
                comboBoxRemainingTime.Items.Add(x);
            }
            comboBoxRemainingTime.SelectedIndex = 0;
        }

        string encodePassword(int num)
        {
            string result = "";

            switch (num)
            {
                case 0:
                    result = "A";
                    break;
                case 1:
                    result = "B";
                    break;
                case 2:
                    result = "C";
                    break;
                case 3:
                    result = "D";
                    break;
                case 4:
                    result = "E";
                    break;
                case 5:
                    result = "F";
                    break;
                case 6:
                    result = "G";
                    break;
                case 7:
                    result = "H";
                    break;
                case 8:
                    result = "I";
                    break;
                case 9:
                    result = "J";
                    break;
                case 10:
                    result = "K";
                    break;
                case 11:
                    result = "L";
                    break;
                case 12:
                    result = "M";
                    break;
                case 13:
                    result = "N";
                    break;
                case 14:
                    result = "O";
                    break;
                case 15:
                    result = "P";
                    break;
                case 16:
                    result = "Q";
                    break;
                case 17:
                    result = "R";
                    break;
                case 18:
                    result = "S";
                    break;
                case 19:
                    result = "T";
                    break;
                case 20:
                    result = "U";
                    break;
                case 21:
                    result = "V";
                    break;
                case 22:
                    result = "W";
                    break;
                case 23:
                    result = "X";
                    break;
                case 24:
                    result = "Y";
                    break;
                case 25:
                    result = "Z";
                    break;
                default:
                    result = "?";
                    // Got a value less than 0 or greater than 25. Should not happen. Password generation Failed.
                    break;
            }
            return result;
        }

        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            int level = (int)comboBoxLevel.SelectedItem;
            int health = (int)comboBoxHealth.SelectedItem;
            int remainingTime = (int)comboBoxRemainingTime.SelectedItem;

            int digit1 = 0;
            int digit2 = 0;
            int digit3 = 0;
            int digit4 = 0;
            int digit5 = 0;
            int digit6 = 0;

            digit1 = level - 1;
            digit3 = remainingTime % 10;
            digit2 = (remainingTime - digit3) / 10;
            digit4 = health;
            digit5 = 0;
            digit6 = (10 + digit1 + digit2 + digit3 + digit4 + digit5) % 26;

            textBoxPassword.Text = encodePassword(digit1) + encodePassword(digit2) + encodePassword(digit3) + encodePassword(digit4) + encodePassword(digit5) + encodePassword(digit6);
        }
    }
}
