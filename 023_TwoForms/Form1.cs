using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _023_TwoForms
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    Form2 f;
    private void button1_Click(object sender, EventArgs e)
    {
      if(f == null)
       f = new Form2(this, "나는 Form1이야");
      f.Show();
      this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      label1.Text = f.textBox1.Text; 
    }

    // Common 클래스에서 값을 가져오기
    private void button3_Click(object sender, EventArgs e)
    {
      MessageBox.Show(Common.str + "\n" + Common.value);
    }
  }

  public static class Common
  {
    // 멤버변수 = field(필드)
    public static string str = "";
    public static int value = 0;
  }
}
