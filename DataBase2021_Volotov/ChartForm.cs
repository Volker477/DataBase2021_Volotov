using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataBase2021_Volotov
{
    public partial class ChartForm : Form
    {
        DataSet ds;
        public ChartForm(DataSet ds)
        {
            this.ds = ds;
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            Diag.Series.Clear();
            Diag.Series.Add(new Series("ColumnSeries")
            {
                ChartType = SeriesChartType.Radar
            });
            Diag.DataSource = ds.Tables[0];
            Diag.Series[0].XValueMember = ds.Tables[0].Columns[0].ToString();
            Diag.Series[0].YValueMembers = ds.Tables[0].Columns[1].ToString();
            Diag.Series[0].IsValueShownAsLabel = true;
            Diag.Series[0].IsVisibleInLegend = true;
            Diag.DataBind();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
