using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Accounts acc = new Accounts(500, "D");
            Accounts azz=new Accounts(1000, "D");
            acc.accept(123, "Blessy", "savings");
            acc.show();*/
            
            /*Student s=new Student(13,"Brian",1,8,"cs");
            s.displayresult();*/

            Shapes s=new Shapes();
            s.area(2,3);
            s.area(5);
            s.area(2.5, 5.6);
           
        }
    }
}
