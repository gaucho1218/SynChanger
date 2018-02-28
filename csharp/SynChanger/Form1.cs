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

        private void changeButton_Click(object sender, EventArgs e)
        {
            //! clear existing result
            afterTextBox.Clear();

            //! copy data to afterTextBox
            string strPreText = beforeTextBox.Text;
            for (int i = 0; i < strPreText.Length; ++i)
            {
                switch(strPreText[i])
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
    }
}
