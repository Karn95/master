namespace FunBooksAndVideos.Model.Interfaces
{
    public interface IPhysicalProduct : IProduct
    {
        //Marker interface (empty interface) is pretty debatable
        //Some people consider this as anti-pattern and code smell
        //In this case the base interface has state so would be ok
        //Alternate options are abstract base class or decorate with attribute
    }
}
