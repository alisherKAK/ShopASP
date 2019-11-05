namespace Shop.Controllers
{
    public class Fabric : IFabric<IShopService>
    {


        public IShopService Get()
        {
            return new ShopService(new ProductRepository());
        }
    }
}