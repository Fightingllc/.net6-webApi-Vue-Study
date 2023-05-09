namespace FirstApi.Services;

public class ScopedService:IScopedService
{
    public int count {get; set;}
    public ScopedService()
    {
        
    }
    public void Plus()
    {
        count++;
    }
}
