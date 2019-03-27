using System;
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Done");
            
            for(int i=1;i<101;i++){
                String s="";
                if(i%3==0){
                    s+="Fizz";
                }
                if(i%5==0){
                    s+="Buzz";
                }
                if(s==""){
                    s=i.ToString();
                }
                Console.WriteLine(s);
            }
        }
    }
