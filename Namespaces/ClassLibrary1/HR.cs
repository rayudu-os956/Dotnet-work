namespace HR{
public interface IEmployee
{
    

}

public interface IMangager : IEmployee
{
    
}

public interface IExecutive : IEmployee
{
    
}

public class Manager : IMangager
{
    
}

public class AsstManager : IMangager
{
    
}

public class Executive : IExecutive
{
    
}
}