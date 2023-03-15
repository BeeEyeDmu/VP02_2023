using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_MessageBoxes
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      MessageBox.Show("가장 간단한 메시지박스입니다.");
      MessageBox.Show("타이틀을 갖는 메시지박스입니다.", 
        "타이틀 메시지");
      MessageBox.Show("느낌표와 알람 메시지박스입니다.",
        "느낌표와 알람소리", MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation);

      DialogResult result = MessageBox.Show("메시지박스 테스트", "질문",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2);

      string msg = string.Format("당신의 선택 : {0}",
        result.ToString());
      MessageBox.Show(msg);

    }
  }
}
