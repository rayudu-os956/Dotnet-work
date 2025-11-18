namespace HR{
    namespace Mgr
    {
    public interface IMangager : IEmployee
    {
    
    }
    public class Manager : IMangager
    {
    
    }
    public class AsstManager : IMangager
    {
    
    }
        
    }
public interface IEmployee
{
    

}

public interface IMangager : IEmployee
{
    
}

public interface IExecutive : IEmployee
{
    
}





public class Executive : IExecutive
{
    
}
}