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
  public partial class Form2 : Form
  {
    Form1 f;  //Form1
    public Form2(Form1 form, string s)
    {
      InitializeComponent();
      f = form;
      //MessageBox.Show(s, "이곳은 Form2");
    }


    private void button1_Click(object sender, EventArgs e)
    {
      f.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      f.Text = textBox1.Text;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      f.label1.Text = textBox1.Text;
    }

    // Form2에서 Common 클래스의 값을 지정
    private void button4_Click(object sender, EventArgs e)
    {
      Common.str = textBox1.Text;
      Common.value = 1024;
    }
  }
}
