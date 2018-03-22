using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynChanger
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void changeSyntax()
        {
            //! clear existing result
            afterTextBox.Clear();

            //! copy data to afterTextBox
            string strPreText = beforeTextBox.Text;
            for (int i = 0; i < strPreText.Length; ++i)
            {
                switch (strPreText[i])
                {
                    case '<':
                        afterTextBox.Text += "&lt;";
                        break;
                    case '>':
                        afterTextBox.Text += "&gt;";
                        break;
                    case '&':
                        afterTextBox.Text += "&amp;";
                        break;
                    case '"':
                        afterTextBox.Text += "&quot;";
                        break;
                    default:
                        afterTextBox.Text += strPreText[i];
                        break;
                }
            }
        }

        private void copyToClipBoard()
        {
            Clipboard.Clear();
            Clipboard.SetText(afterTextBox.Text);
        }

        private void beforeTextBox_TextChanged(object sender, EventArgs e)
        {
            changeSyntax();
            copyToClipBoard();
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if( control.Width - 100 > beforeTextBox.Width )
            {
                beforeTextBox.Width = (control.Width - 100) / 2;

                //! afterbox also need to change x coordination
                afterTextBox.Location = new Point(beforeTextBox.Location.X + beforeTextBox.Width + 60, afterTextBox.Location.Y);
                afterTextBox.Width = (control.Width - 100) / 2;
            }
        }
    }
}
