using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.buttonFind.Enabled = false;
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxFind.Text.Length > 0)
            {
                this.buttonFind.Enabled = true;
            }
            else
            {
                this.buttonFind.Enabled = false;
            }
        }
    }
}
