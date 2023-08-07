using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Adınızı daxil edin:");
      string userName = Console.ReadLine();
      Console.WriteLine("Soyadınız daxil edin:");
      string surName = Console.ReadLine();
      Console.WriteLine("Yaşınızı daxil edin:");
      string input3 = Console.ReadLine();
      int a = int.Parse(input3);
      
      
      while (a < 18)
      {
          a=a+1;
          if (a==18)
          {
              break;
          }
          
          Console.WriteLine($"{userName} {surName} {a} Yaşınız Mübarək!");
          
      }
      if (a>18)
      {
          Console.WriteLine($"{userName} {surName} {a} Yaşınız Mübarək!");
      }
       
    
  }
}
