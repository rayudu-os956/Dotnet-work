namespace ClassLibrary1;
//delegate type
public  delegate  int  MyDelegateType(int a,int b);
public class Publisher
{
//private delegate
    //private MyDelegateType myDelegate;
    //cretaing func
   // public event Func<int,int ,int>myEvent;
   public event Action<int,int>myEvent;
//cretae event
     //public event MyDelegateType myEvent;
    // {
    //     add
    //     {
    //         myDelegate += value; 
            
    //     }
    //     remove
    //     {
    //         myDelegate -= value;
            
    //     }
    //}
    public void RaiseEvent(int a , int b)
    {
        //step2:raise Event
        if(this.myEvent!=null) 
        {
           // int x = this.myEvent(a,b);
            // return x;
            this.myEvent(a,b);
        }
        // else
        // {
        //     return 0 ;
        // }
    }
}
