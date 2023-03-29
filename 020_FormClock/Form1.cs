using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_FormClock
{
  public partial class Form1 : Form
  {
    // 이 클래스의 변수(필드)
    private Graphics g;
    private bool aClockFlag = true;
    private Point center; // 중심점
    private double radius;  // 반지름
    private int hourHand;   // 시침의 길이
    private int minHand;    // 분침의 길이
    private int secHand;    // 초침의 길이

    const int clientSize = 300; // 상수로 클리이언트 크기를 지정
    const int clockSize = 200;  // 시계의 크기

    public Form1()
    {
      InitializeComponent();
      this.Text = "Form Clock";
      panel1.BackColor = Color.WhiteSmoke;

      this.ClientSize = new Size(clientSize, 
        clientSize+menuStrip1.Height);

      // 그래픽스 객체를 만든다
      g = panel1.CreateGraphics();

      aClockSetting();
      TimerSetting();
    }

    private void aClockSetting()
    {
      center = new Point(clientSize/2, clientSize/2);
      radius = clockSize/2;
      hourHand = (int)(radius*0.45);
      minHand = (int)(radius * 0.55);
      secHand = (int)(radius * 0.65);
    }

    private void TimerSetting()
    {
      Timer timer = new Timer();
      timer.Interval = 1000;
      timer.Tick += Timer_Tick;
      timer.Start();
    }

    // 현재 시간을 읽어와서, 시계를 그린다
    private void Timer_Tick(object sender, EventArgs e)
    {
      DateTime c = DateTime.Now;

      panel1.Refresh();

      if(aClockFlag == true) // 아날로그
      {
        DrawClockFace();  // 시계판

        // 시계바늘을 그린다.(핵심, 각도를 계산)
        double radHr = (c.Hour % 12 + c.Minute / 60) * 30
          * Math.PI / 180; // 시간당 30도
        double radMin = (c.Minute + c.Second / 60) * 6
          * Math.PI / 180; // 분당 6도
        double radSec = c.Second * 6 * Math.PI / 180; //초당 6도

        DrawHands(radHr, radMin, radSec);
      }
      else // 디지털시계
      {

      }
    }

    // 각도를 받아서 시계바늘 그리는 메소드
    private void DrawHands(double radHr, double radMin, double radSec)
    {
      DrawLine(0, 0, (int)(hourHand*Math.Sin(radHr)),
        (int)(hourHand *Math.Cos(radHr)), Brushes.RoyalBlue, 8);
      DrawLine(0,0, (int)(minHand * Math.Sin(radMin)),
        (int)(minHand * Math.Cos(radMin)), Brushes.SkyBlue, 6);
      DrawLine(0, 0, (int)(secHand * Math.Sin(radSec)),
        (int)(secHand * Math.Cos(radSec)), Brushes.OrangeRed, 4);

      // 배꼽
      int coreSize = 16;
      Rectangle r = new Rectangle(
        center.X - coreSize/2, center.Y - coreSize/2,
        coreSize, coreSize);
      g.FillEllipse(Brushes.Gold, r);
      g.DrawEllipse(new Pen(Brushes.Green, 3), r);
    }

    private void DrawLine(int x1, int y1, int x2, int y2, Brush brush, int thick)
    {
      Pen p = new Pen(brush, thick);
      p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
      g.DrawLine(p, center.X + x1, center.Y + y1, 
        center.X + x2, center.Y - y2);
    }

    private void DrawClockFace()
    {
      Pen p = new Pen(Color.LightSteelBlue, 30);
      g.DrawEllipse(p, center.X-clockSize/2,
        center.Y-clockSize/2, clockSize, clockSize);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
