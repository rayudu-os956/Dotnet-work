// public abstract class Employee
// {
//     //fields

//     private int _empID;
//     private string _empName;

//     protected string _location;
//     //constructor

//     public Employee(int empID, string empName, string location)
//     {
//         this._empID = empID;
//         this._empName = empName;
//         this._location = location;

//     }

//     //abstract methods
//     public abstract string GetHealthInsuranceAmount();
  

//     //properties 

//     public int EmpID
//     {
//         set
//         {
//             _empID = value;
//         }
//         get
//         {
//             return _empID;
//         }
//     }

//     public string EmpName
//     {
//         set
//         {
//             _empName = value;
//         }
//         get
//         {
//             return _empName;
//         }
//     }
//       public string Location
//     {
//         set
//         {
//             _location = value;
//         }
//         get
//         {
//             return _location;
//         }
//     }


// }

public interface IEmployee
{
    string GetHealthInsuranceAmount();

    int EmpID {set;get;}
    string EmpName{set;get;}
    string Location{set;get;}
}