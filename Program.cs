using System;

namespace Asignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Program program = new Program();
            program.Multi();
            program.Addsubmuldiv();
            program.Avg();
            program.Sum();
            program.check();
            program.stringword();
        }
       

        public void Multi()
        {
            int p = 1,q = 1,r = 1;
            Console.WriteLine("Enter the p,q,r Values:");

            Console.Write("Enter the value of p: ",p);
            p=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of q: ",q);
            q=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of r: ",r);
            r=Convert.ToInt32(Console.ReadLine());

            int s = p * q * r;
            Console.WriteLine("Multiplication of three numbers: " + s);
            
        }

        public void Addsubmuldiv()
        {
            int n1 = 1,n2 = 1;
            Console.WriteLine("enter  a number");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  number");
            n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1+n2);
            Console.WriteLine(n1-n2);
            Console.WriteLine(n1*n2);
            Console.WriteLine(n1/n2);        

        }

        public void Avg()
        {
            int l = 1,m = 1,n = 1;
            Console.WriteLine("Enter the Calculate & Average values:");

            Console.Write("Enter the value of l: ",l);
            l=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of m: ",m);
            m=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of n: ",n);
            n=Convert.ToInt32(Console.ReadLine());

            int avg = (l + m + n ) / 3;
            Console.WriteLine("Calculate & Average value is : " + avg);
           
        }



        public void Sum()
        {
            int u = 1,v = 1;
            Console.WriteLine("Enter the sum of values:");

            Console.Write("Enter the value of u: ",u);
            u=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of v: ",v);
            v=Convert.ToInt32(Console.ReadLine());

            if(u == v)
            {
                int w = (u + v) * (u + v) * (u + v);
                Console.WriteLine("Sum of Triple integers: " + w);
            }
            
        }
       

        bool check()
        {
            int a = 1,b = 1;
            Console.WriteLine("Enter the Positive sign and Negative sign values:");

            Console.Write("Enter the value of a: ",a);
            a=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of b: ",b);
            b=Convert.ToInt32(Console.ReadLine());

            if(a > 0 && b < 0)
            {
                Console.WriteLine("True");
                return true;
            }

            else
            {
                Console.WriteLine("False");
                return false;
            }
                
        }

       

        public void stringword()
        {
            string q = "";
            Console.WriteLine("Enter the string:");
            q = Console.ReadLine();
            Console.WriteLine("Enter the word to check given the above string:");
            string r = "";
            r = Console.ReadLine();

            Console.WriteLine(" After check given the above string is: " + q.Contains(r));
            
        } 
        
    }
}