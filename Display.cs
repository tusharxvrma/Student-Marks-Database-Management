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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void studentReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.reportDataSet);

        }

        private void studentReportBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.reportDataSet);

        }

        private void Display_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportDataSet.studentReport' table. You can move, or remove it, as needed.
            this.studentReportTableAdapter.Fill(this.reportDataSet.studentReport);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxExam.SelectedIndex)
            {
                case 1:this.studentReportTableAdapter.FillByquiz(this.reportDataSet.studentReport);
                    break;
                case 2:
                    this.studentReportTableAdapter.FillBylab(this.reportDataSet.studentReport);
                    break;
                case 3:
                    this.studentReportTableAdapter.FillBylec(this.reportDataSet.studentReport);
                    break;
                case 4:
                    this.studentReportTableAdapter.FillByResearch(this.reportDataSet.studentReport);
                    break;
                case 5:
                    this.studentReportTableAdapter.FillByfinal(this.reportDataSet.studentReport);
                    break;
            }
        }

        private void comboBoxMarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMarks.SelectedIndex)
            {
                
                case 1:
                    this.studentReportTableAdapter.FillBymore(this.reportDataSet.studentReport);
                    break;
                case 2:
                    this.studentReportTableAdapter.FillByless(this.reportDataSet.studentReport);
                    break;
                case 3:
                    this.studentReportTableAdapter.FillBybtwn(this.reportDataSet.studentReport);
                    break;
            }
        }
    }
}
