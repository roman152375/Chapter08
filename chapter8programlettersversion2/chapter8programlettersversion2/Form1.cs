using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter8programlettersversion2
{
    public partial class Form1 : Form
    {
        private const int MAXLETTERS = 26;
        private const int MAXCHARS = MAXLETTERS - 1;
        private const int LETTERA = 65;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            char oneLetter;
            int index;
            int i;
            int length;
            int[] count = new int[MAXLETTERS];
            string input;
           // string buff;
            length = txtInput.Text.Length;
            if (length == 0)
            {
                MessageBox.Show("You need to enter some Text.", "Missing input");
                txtInput.Focus();
                return;

            }
            input = txtInput.Text;
            input = input.ToUpper();

            for (i = 0; i < input.Length; i++)
            {
                oneLetter = input[i];
                index = oneLetter - LETTERA;
                if (index < 0 || index > MAXCHARS)
                    continue;
                count[index]++;
            }
            ListViewItem which;
            for (i = 0; i < MAXLETTERS; i++)
            {
                oneLetter = (char)(i + LETTERA);
                which = new ListViewItem(oneLetter.ToString());
                which.SubItems.Add(count[i].ToString());
                lstOutput.Items.Add(which);
            }
        }

        private void txtInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
