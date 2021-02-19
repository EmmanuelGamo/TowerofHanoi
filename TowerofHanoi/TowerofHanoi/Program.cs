using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToweroofHanoi
{
      class TowersOfHanoiMain
    {
        public static int Main()
        {
            
            Console.Write("Enter the number of discs: ");
            string cnumdiscs = Console.ReadLine();
            int Ndiscs = Convert.ToInt32(cnumdiscs);
            double x = Math.Pow(2, Ndiscs) - 1;
            Console.WriteLine("Number of steps:{0}", x);
            discmovement(Ndiscs, 1, 3, 2); 
            Console.ReadLine();
            return 0;
        }
        private static void discmovement(int n, int from, int to, int space)
        {
            if (n > 0)    //using recursion
            {
        
                discmovement(n - 1, from, space, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
                discmovement(n - 1, space, to, from);
         
            }
            else
            {
                
            }
                    
        }

    }
   
        
       

        
    
  
}
