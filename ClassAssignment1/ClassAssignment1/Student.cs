using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    internal class Student
    {
       public int rollno;
       public string name;
       public int class1;
      public  int sem;
      public  string branch;
        bool flag=false;

      public  int[] marks = new int[5] {23,56,78,95,67};
        
        
        public int this[int i]
        {
            get { return marks[i]; }
            set { marks[i] = value; }
        }

        public Student(int roll, string nam, int class11, int sem1, string branch1)
        {
            this.rollno = roll;
            this.name = nam;
            this.class1 = class11;
            this.sem = sem1;
            this.branch = branch1;

        }

        public void displayresult()
        {
            int sum = 0;
            int avg=0;
            for(int i = 0; i < marks.Length; i++)
            {
                 sum+=marks[i];
            }
            avg = sum / 5;
            Console.WriteLine(avg);
            for (int i=0;i<marks.Length; i++)
            {
                if (marks[i]<35)
                {
                    Console.WriteLine("Failed");
                    flag=true;
                    break;
                }
                
            }
            if(flag==false && avg<50)
            {
                Console.WriteLine("Failed");
            }
            else if(flag==false && avg>50)
            {
                Console.WriteLine("Passed");
            }
        }

        public void displaydata()
        {
            Console.WriteLine("Name: "+name+" RollNo: "+rollno);
            Console.WriteLine("Class "+class1+" sem: "+sem+" branch: "+branch);
        }



    }
}
