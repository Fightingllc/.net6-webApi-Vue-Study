namespace FirstApi.Services;

public class SingletonService: ISingletonService
{
    public SingletonService(int i)
    {
        I = i;
    }
    public int I {get;}
}
