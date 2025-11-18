using HR;
using m= HR.Mgr;

using FrontOffice;
class Program
{
    static void Main() 
    {
        m.IMangager manager1;
         manager1 = new m.Manager();
        m.IMangager manager2;
         manager2 = new m.Manager();
        m.IMangager manager3;
         manager3 = new m.Manager();
   
         CustomerEnquiry customerEnquiry =   new CustomerEnquiry();
    }
}