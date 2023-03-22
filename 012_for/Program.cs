using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_for
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // for(초기조건; 반복조건; 증감조건)
      //    문장;

      //1. 1~100까지 더하기
      int sum = 0;
      
      for (int i = 1; i <= 100; i++)
        sum += i;

      Console.WriteLine("1~100의 합 : {0}", sum);

      //2. 1~100 홀수의 합
      sum = 0;

      for (int i = 1; i <= 100; i++)
        if (i % 2 == 1)
          sum += i;

      Console.WriteLine("1~100의 홀수의 합 : {0}", sum);

      //3. 1~100 역수의 합
      double rSum = 0;

      for (int i = 1; i <= 100; i++)
        rSum += 1.0 / i;

      Console.WriteLine("1~100 역수의 합 : {0}", rSum);

      // 구구단
      Console.Write("구구단의 단을 입력 : ");
      int n = int.Parse(Console.ReadLine());
      for(int i=1; i<=9; i++)
        Console.WriteLine("{0} x {1} = {2}", n, i, n*i);

      // x의 y승 = x를 y번 곱한다
      Console.Write("입력 : ");
      int x = int.Parse(Console.ReadLine());
      Console.Write("입력 : ");
      int y = int.Parse(Console.ReadLine());

      int exp = 1;
      for (int i = 0; i < y; i++)  // for(int i=1; i<=y; i++)
        exp *= x;
      Console.WriteLine("{0}의 {1}승 = {2}", x, y, exp);

      // 팩토리얼
      // n! = 1*2*...*n
      Console.Write("n! 계산, n을 입력 :");
      n = int.Parse(Console.ReadLine());
      int fact = 1;
      for (int i = 1; i <= n; i++)
        fact *= i;
      Console.WriteLine("{0}! = {1}", n, fact);
    }
  }
}
