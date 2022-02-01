using System;
namespace payslip
{
    public class Employee
    {
        public void Calculator(double BP)
        {
            Console.WriteLine("Employee name");
            string Emp_name = Console.ReadLine();
            Console.WriteLine("Employee ID");
            int Emp_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Mail id ");
            string Mail_id = Console.ReadLine();
            Console.WriteLine("Mobile number ");
            long Mobile_no = Convert.ToInt64(Console.ReadLine());
            double DA = BP * 0.97;
            double HRA = BP * 0.1;
            double PF = BP * 0.12;
            double staff_club = BP * 0.01;
            double total = BP + DA + HRA - (PF + staff_club);
            printing(Emp_name, Emp_id, Address, Mail_id, Mobile_no, BP, DA, HRA, PF, staff_club, total);
            
        }
        public void printing(string Emp_name, int Emp_id, string Address, string Mail_id, long Mobile_no, double BP, double DA, double HRA, double PF, double staff_club, double total)
        {
            Console.WriteLine("............Pay slip............");
            Console.WriteLine("Employee Name \t" + Emp_name);
            Console.WriteLine("Employee ID \t" + Emp_id);
            Console.WriteLine("Address \t" + Address);
            Console.WriteLine("Mail id \t" + Mail_id);
            Console.WriteLine("Mobile_no \t" + Mobile_no);
            Console.WriteLine("............Salary Details............");
            Console.WriteLine("Basic Pay " + BP);
            Console.WriteLine("DA \t" + DA);
            Console.WriteLine("HRA \t" + HRA);
            Console.WriteLine("PF \t" + PF);
            Console.WriteLine("Staff Club \t" + staff_club);
            Console.WriteLine("......................................");
            Console.WriteLine("Total salary on hand " + total);

        }

    }
    public class Programmer : Employee
    {
        public void Programmer_man()
        {
            double BP = 100000;
            Calculator(BP);
        }
    }
    public class Assistant_professor : Employee
    {
        public void Asst_Pro()
        {
            double BP = 60000;
            Calculator(BP);
        }
    }
    public class Associate_professor : Employee
    {
        public void Asso_Pro()
        {
            double BP = 75000;
            Calculator(BP);
        }
    }
    public class Professor:Employee
    {
        public void Prof()
        {
            double BP = 90000;
            Calculator(BP);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Programmer\n2. Assistant Professor\n3. ASsociate Professor\n4. Professor");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Programmer p = new Programmer();
                p.Programmer_man();
            }
            else if (choice == 2)
            {
                Assistant_professor ap = new Assistant_professor();
                ap.Asst_Pro();
            }
            else if (choice == 3)
            {
                Associate_professor asp = new Associate_professor();
                asp.Asso_Pro();
            }
            else if (choice == 4)
            {
                Professor pro = new Professor();
                pro.Prof();
            }
        }
        
    }
}
