namespace FirstApi.Services;

public class IocService1:IIocService1
{
     public IocService1(
            ISingletonService singletonService,
            IScopedService scopedService,
            ITransientService transientService
        )
        {

        }


}
