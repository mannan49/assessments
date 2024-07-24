using System;

class MainClass {

  public static string StringExpression(string str) {

     string res = str.Replace("plus", "+");
     res = res.Replace("minus", "-");
     res = res.Replace("zero", "0");
     res = res.Replace("one", "1");
     res = res.Replace("two", "2");
     res = res.Replace("three", "3");
     res = res.Replace("four", "4");
     res = res.Replace("five", "5");
     res = res.Replace("six", "6");
     res = res.Replace("seven", "7");
     res = res.Replace("eight", "8");
     res = res.Replace("nine", "9");

  string num="";
  int gain=0;

     for(int i=0; i<res.Length; i++)
     {
       if(res[i]!= '-' && res[i]!= '+')
      {
        num= num+ res[i];
      }
      else if( res[i]== '-')
      {
        int k=Convert.ToInt32(num);
        gain=gain+k;
        num="-";
      }
      else if( res[i]== '+')
      {
        int k=Convert.ToInt32(num);
        gain=gain+k;
        num="+";
      }

     }
     int j=Convert.ToInt32(num);
        gain=gain+j;

        char[] buffer = gain.ToString().ToCharArray();

        string output = "";

        if(buffer[0] == '-' ){
          output += "negative";
        }

      

        for( int i=0; i< buffer.Length ; i++){
          switch (buffer[i])
{
    case '0':
        output += "zero";
        break;
    case '1':
        output += "one";
        break;
    case '2':
        output += "two";
        break;    
    case '3':
        output += "three";
        break;
    case '4':
        output += "four";
        break;
    case '5':
        output += "five";
        break;
    case '6':
        output += "six";
        break;
    case '7':
        output += "seven";
        break;
    case '8':
        output += "eight";
        break;
    case '9':
        output += "nine";
        break;
}
        }


   
       Console.WriteLine(output);
    

    return res;

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(StringExpression(Console.ReadLine()));
    
  } 

}
