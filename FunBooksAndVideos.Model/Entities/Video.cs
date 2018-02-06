using FunBooksAndVideos.Model.Interfaces;

namespace FunBooksAndVideos.Model.Entities
{
    public class Video : IPhysicalProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductCost { get; set; }
    }

}
