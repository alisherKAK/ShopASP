using System;

namespace Shop.Controllers
{
    public interface IFabric<T>
    {
        T Get();
    }
}
