using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.IO;

public class Test
{
	public static void Main()
	{
	    
	    long a = int.Parse(Console.ReadLine());
	    while(a>0)
	    {
	        string[] bb = Console.ReadLine().Split();
	        long b = int.Parse(bb[0]);
	        long c = int.Parse(bb[1]);
	        string[] e = Console.ReadLine().Split();
	       // List<int> f = new List<int>();
	        long f = 1;
	        long bbb = 0;
	        while(b>0)
	        {
	            if(f<1000000001){
	            f*=long.Parse(e[Convert.ToInt32(bbb)]);}
	          /// f.add(e[bbb])}
	           bbb++;
	           b--; 
	        }
	        string[] g = Console.ReadLine().Split();
	        List<long> h = new List<long>();
	        bbb=0;
	        while(c>0)
	        {
	            h.Add(int.Parse(g[Convert.ToInt32(bbb)]));
	            bbb++;;
	            c--;;
	        }
	        foreach(long k in h)
	        {
	            Console.Write(k/f +" ");
	        }
	        Console.WriteLine();
	        
	        a--;
	    }
	    
	   // Console.WriteLine("L");
	    
	    
	}
}
