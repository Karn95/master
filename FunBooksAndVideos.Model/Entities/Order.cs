using FunBooksAndVideos.Model.Interfaces;
using System.Collections.Generic;

namespace FunBooksAndVideos.Model.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<IProduct> ItemLines { get; set; }
    }
}
