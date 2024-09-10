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
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void studentReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.reportDataSet);

        }

        private void Enter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportDataSet.studentReport' table. You can move, or remove it, as needed.
            this.studentReportTableAdapter.Fill(this.reportDataSet.studentReport);

        }

        private void studentReportDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double sum = 0;
            int rowCount = 0;
            double average = 0;

            if (e.RowIndex >= 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    string data = studentReportDataGridView.Rows[e.RowIndex].Cells[i].Value.ToString();

                    if (!string.IsNullOrEmpty(data))
                    {
                        rowCount += 1;
                    }
                }
                if (rowCount == 8)
                {
                    sum = (double)studentReportDataGridView.Rows[e.RowIndex].Cells[3].Value + (double)studentReportDataGridView.Rows[e.RowIndex].Cells[4].Value + (double)studentReportDataGridView.Rows[e.RowIndex].Cells[5].Value + (double)studentReportDataGridView.Rows[e.RowIndex].Cells[6].Value + (double)studentReportDataGridView.Rows[e.RowIndex].Cells[7].Value;
                    average = sum / 5;
                    studentReportDataGridView.Rows[e.RowIndex].Cells[8].Value = average;
                    studentReportDataGridView.Refresh();
                }
            }

        }

        private void brnAvg_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int rowcount = 0;
            foreach (DataGridViewRow row in studentReportDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    double cellValue = (double)row.Cells[8].Value;
                    sum += cellValue;
                    rowcount++;
                }
            }
            sum /= rowcount;
            MessageBox.Show("The class Average is: " + sum.ToString());
        }

        private void btnSTdDev_Click(object sender, EventArgs e)
        {
            List<double> averages = new List<double>();

            foreach (DataGridViewRow row in studentReportDataGridView.Rows)
            {
                if (!row.IsNewRow && row.Cells[8].Value != null)
                {
                    double average;
                    if (double.TryParse(row.Cells[8].Value.ToString(), out average))
                    {
                        averages.Add(average);
                    }
                }
            }

            if (averages.Count > 1) 
            {
                double mean = averages.Average();
                double sumOfSquaresOfDifferences = averages.Select(val => (val - mean) * (val - mean)).Sum();
                double stdDev = Math.Sqrt(sumOfSquaresOfDifferences / (averages.Count - 1));

                MessageBox.Show("The standard deviation is: " + stdDev.ToString("F2"));
            }
            else
            {
                MessageBox.Show("Not enough data to calculate standard deviation.");
            }
        }
    }
}
