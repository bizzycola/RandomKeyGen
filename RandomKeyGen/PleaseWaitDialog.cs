using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomKeyGen
{
    public partial class PleaseWaitDialog : Form
    {
        public PleaseWaitDialog()
        {
            InitializeComponent();
        }

        private void PleaseWaitDialog_Load(object sender, EventArgs e)
        {

        }

        bool canClose = false;
        public void CloseDiag()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => CloseDiag()));
                return;
            }
            canClose = true;
            this.Close();
        }

        private void PleaseWaitDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!canClose)
                e.Cancel = true;
        }
    }
}
