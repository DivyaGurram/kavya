using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Arthematic arthm = new Arthematic(20,40);

            Console.WriteLine("calling sub method : "+arthm.sub());

            Console.WriteLine("calling add method : "+arthm.add());


            arthm.setX(12);
            arthm.setY(10);
            Console.WriteLine("calling sub method : " + arthm.sub());

            Console.WriteLine("calling add method : " + arthm.add());

            Console.Read();
            
            


        }
    }
}
