using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makeup
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            Enter form = new Enter();
            form.ShowDialog();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display Form = new Display();
            Form.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
