namespace ClassLibrary1;
//delegate type
public  delegate  void  MyDelegateType(int a,int b);
public class Publisher
{
//private delegate
    private MyDelegateType myDelegate;
//cretae event
    public event MyDelegateType myEvent
    {
        add
        {
            myDelegate += value; 
            
        }
        remove
        {
            myDelegate -= value;
            
        }
    }
    public void RaiseEvent(int a , int b)
    {
        //step2:raise Event
        if(this.myDelegate!=null) 
        {
        this.myDelegate(a,b);
        }
    }
}
