using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_class
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Random r = new Random();

      // 랜덤 숫자 5개를 출력
      for(int i=0; i<5; i++)
        Console.WriteLine(r.Next(100));

      // 숫자 20개를 랜덤하게 만들어 배열에 저장한다
      int[] a = new int[20];
      for(int i=0; i<20; i++)
        a[i] = r.Next(100);

      Console.WriteLine("배열의 내용 :");
      foreach(var x in a)
        Console.Write(x + " ");
      Console.WriteLine();

      // 최소, 최대, 평균 계산
      int min = a[0];
      int max = a[0];
      int sum = 0;
      for (int i = 0; i < 20; i++) {
        if(a[i] < min) 
          min = a[i];
        if (a[i] > max)
          max = a[i];
        sum += a[i];
      }
      Console.WriteLine("최소값={0}, 최대값={1}, 평균={2}",
        min, max, sum/20.0);
    }
  }
}
