 using System;  
public class def 
{  
    public static void Main(string [] args)
    {  
   
        List<string> S = new List<string>()  
        {  
           "roses are red", "bottle also red", "violets blue", "Laptop"
        };

        // Query syntax

        var r = from P in S  
                where P.Contains("red")  
                select P;    
        foreach(var i in r)  
        {  
            Console.WriteLine(i);  
        }  

         // Method syntax

         var r1 = S.Where(a=> a.Contains("red")); 
        foreach(var i in r1)  
        {  
            Console.WriteLine(i);  
        }  
    }  
}  

