using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_array
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // 10개짜리 정수 배열을 만들자
      int[] a = new int[10];

      // 10개의 숫자를 입력받아서 배열에 저장
      for(int i = 0; i < 10; i++)
        a[i] = int.Parse(Console.ReadLine());

      // 배열에 저장된 10개의 숫자를 출력하자
      for(int i = 0; i < 10; i++)
        Console.Write(a[i] + " ");
      Console.WriteLine();

      foreach (var x in a)
        Console.Write(x + " ");
      Console.WriteLine();

      // 문자열을 5개 저장할 수 있는 배열을 만들고
      // 입력받은 후
      // 출력하라
      string[] s = new string[5];
      for(int i=0; i<5; i++)
        s[i] = Console.ReadLine();

      foreach(var x in s)
        Console.WriteLine(x);
    }
  }
}
