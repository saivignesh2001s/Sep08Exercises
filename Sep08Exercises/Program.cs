using Microsoft.VisualBasic.FileIO;
using Sep08;
using System.Transactions;

namespace Sep08Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
        samde:
            Console.WriteLine("Enter the username");
            string p=Console.ReadLine();
            Console.WriteLine("Enter the password");
            string u=Console.ReadLine();
            var data = Tuple.Create<string,string>(p,u);
            Predicate<Tuple<string,string>> ps=(data1)=>{
                if(data1.Item1=="Sai" && data1.Item2 == "14012001s")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            if (ps(data))
            {
                List<Employee> m = new List<Employee>();
                List<Dept> m2 = new List<Dept>();
            earn:
                Console.WriteLine(" 1.Add\n 2.Delete\n 3.Edit");
                int y = Convert.ToInt32(Console.ReadLine());

               




                switch (y)
                {
                    case 1:
                    start:
                        Employee mu = new Employee(); 
                         m=mu.Adding(m);
                        Console.WriteLine("Enter Yes to add further");
                        string mk = Console.ReadLine();
                        if (mk == "Yes")
                        {
                            goto start;
                        }
                        break;
                    case 2:
                        Employee mp = new Employee();
                        Console.WriteLine("Enter employee id to delete");
                        int mkt = Convert.ToInt32(Console.ReadLine());
                        m = mp.Delete(mkt, m);
                        mp.Display(m);
                        break;
                    case 3:
                        Console.WriteLine("Enter employee id to edit");
                        int ktm = Convert.ToInt32(Console.ReadLine());
                        Employee mpt = new Employee();
                        m = mpt.Edit(ktm, m);
                        mpt.Display(m);

                        break;
                }

                Employee mt = new Employee();
                Console.WriteLine("Display all Employee names");
                numb1 ns = new numb1(mt.Display);
                ns(m);
                numb1 ns1 = new numb1(mt.Displaybymgr);
                ns1(m);
                Console.WriteLine("Enter Yes to restart");
                string pass = Console.ReadLine();
                if (pass == "Yes")
                {
                    goto earn;
                }
                Console.WriteLine("Add back in to the departments");
                Dept tu = new Dept();
                m2=tu.Addition(m2, m);
                tu.display(m2);
            }
            else
            {
                Console.WriteLine("Try again");
                goto samde;
            }
            Console.ReadLine();
        }
    }
}