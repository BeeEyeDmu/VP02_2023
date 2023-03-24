using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_chart2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      chart1.ChartAreas[0].AxisX.Minimum = 0;
      chart1.ChartAreas[0].AxisX.Maximum = 20;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int x = int.Parse(textBox1.Text);
      chart1.Series[0].Points.Add(x);
    }
  }
}
