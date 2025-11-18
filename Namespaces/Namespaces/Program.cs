using HR;
using m = HR.Mgr;
using static System.Console;

using FrontOffice;
class Program
{
    static void Main() 
    {
        WriteLine("Magaer class");
        m.IMangager manager1;
         manager1 = new m.Manager();
        m.IMangager manager2;
         manager2 = new m.Manager();
        m.IMangager manager3;
         manager3 = new m.Manager();
        
        WriteLine("Customer Enquiry  class");
         CustomerEnquiry customerEnquiry =   new CustomerEnquiry();
    }
}