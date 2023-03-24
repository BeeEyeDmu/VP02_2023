using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_Timer
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.Text = "나의 디지털 시계";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      ClientSize = new Size(300, 300);

      timer1.Enabled = true;
      timer1.Interval = 1000; // 단위: ms, 1초
      timer1.Tick += Timer1_Tick;

      label1.Font = 
        new Font("맑은 고딕", 16, 
          FontStyle.Bold | FontStyle.Italic);

      label1.ForeColor = Color.DarkSlateBlue;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      label1.Text = DateTime.Now.ToString();
      label1.Location = new Point(
        ClientSize.Width/2 - label1.Width/2, 
        ClientSize.Height/2 - label1.Height/2);
    }

    private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
