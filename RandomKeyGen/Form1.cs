using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RandomKeyGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand;

        List<char> numbers;
        List<char> lowerCase;
        List<char> upperCase;

        private void Form1_Load(object sender, EventArgs e)
        {
            numbers = Enumerable.Range('0', '9' - '0' + 1).Select(c => (char)c).ToList();
            lowerCase = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToList();
            upperCase = Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => (char)c).ToList();
            rand = new Random((int)DateTime.Now.Ticks);
        }
        
        private void genBtn_Click(object sender, EventArgs e)
        {
            if (!numBox.Checked && !lowerBox.Checked && !upperBox.Checked)
            {
                MessageBox.Show("You need to tick at least 1 checkbox.", "Error");
                return;
            }

            List<char> list = new List<char>();
            if (numBox.Checked)
                list.AddRange(numbers);
            if (lowerBox.Checked)
                list.AddRange(lowerCase);
            if (upperBox.Checked)
                list.AddRange(upperCase);

            PleaseWaitDialog diag = new PleaseWaitDialog();
            
            List<string> keys = new List<string>();
            string key;
            new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < numKeys.Value; i++)
                {
                    key = "";
                    for (int i1 = 0; i1 < lenBox.Value; i1++)
                    {
                        key += list[rand.Next(0, list.Count - 1)];
                    }
                    keys.Add(key);
                }
                diag.CloseDiag();
            })).Start();
            if (diag!= null && !diag.IsDisposed)
                diag.ShowDialog();

            string output = "";
            for (int ii = 0; ii < keys.Count; ii++)
            {
                output += keys[ii] + Environment.NewLine + "-" + Environment.NewLine;
            }
            outBox.Text = output;

        }
    }
}
