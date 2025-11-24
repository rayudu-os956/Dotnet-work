namespace ClassLibrary1;
public class CustomEventargs : EventArgs
{
    public int a {get;set;}
    public int b {get;set;}
}
//delegate type
public  delegate  int  MyDelegateType(int a,int b);
public class Publisher
{
//private delegate
    //private MyDelegateType myDelegate;
    //cretaing func
   // public event Func<int,int ,int>myEvent;
   //
   
   // public event Action<int,int>myEvent;
   public event EventHandler<CustomEventargs>myEvent;
   //public event Predicate<int>myEvent;
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
    public void RaiseEvent(object sender,int a , int b)
    {
        //step2:raise Event
        if(this.myEvent!=null) 
        {
           // int x = this.myEvent(a,b);
            // return x;
            CustomEventargs customEventargs = new CustomEventargs(){a=a,b=b};
            this.myEvent(sender,customEventargs);
           // this.myEvent(a,b);
        }
        // else
        // {
        //     return 0 ;
        // }
    }
}
