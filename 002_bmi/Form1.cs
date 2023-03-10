using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmi
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double weight, height;

      height = double.Parse(txtH.Text);
      weight = double.Parse(txtW.Text);

      double bmi = weight / (height / 100 * height / 100);
      //label3.Text = "BMI = " + bmi + "입니다.";
      lblBMI.Text = String.Format("BMI = {0:F2}입니다.", bmi);

      // if 문을 추가
      // 판정기준 추가(if~ else 사용)
      if (bmi < 20)
      {
        lblResult.Text = "저체중입니다.";
        pictureBox1.BackColor = Color.Blue;
      }
      else if (bmi < 25)
      {
        lblResult.Text = "정상체중입니다.";
        pictureBox1.BackColor = Color.Green;
      }
      else if (bmi < 30)
      {
        lblResult.Text = "경도비만입니다.";
        pictureBox1.BackColor = Color.Yellow;
      }
      else if (bmi < 40)
      {
        lblResult.Text = "비만입니다.";
        pictureBox1.BackColor = Color.Orange;
      }
      else { 
        lblResult.Text = "고도비만입니다.";
        pictureBox1.BackColor = Color.Red;
        }
      }
  }
}
