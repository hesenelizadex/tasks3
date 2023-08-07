
using System;
class HelloWorld {
  static void Main() {
      string input = Console.ReadLine();
      string input2 = Console.ReadLine();
      int a = int.Parse(input);
      int b = int.Parse(input2);
      int c;
      c=0;
      
      
      for (int i = a;i<=b;i++)
      {
          if (i%2==0)
          c=c+i*i;
         
      }
      
       Console.WriteLine(c);
      
    
  }
}
